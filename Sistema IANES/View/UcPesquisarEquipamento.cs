using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;


namespace Sistema
{

    public partial class UcPesquisarEquipamento : UserControl
    {
        public UcPesquisarEquipamento()
        {
            InitializeComponent();
        }


        //Metodo para listar o listardataGridEquipPesquisar().
        public void listardataGridEquipPesquisar()
        {
            //Desativa a geração automatica de colunas
            dataGridEquipPesquisar.AutoGenerateColumns = false;

            //Desativa os resize das linhas
            dataGridEquipPesquisar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridEquipPesquisar.AllowUserToResizeRows = false;

            //Da select no banco de dados para mostrar dentro do datagridview
            dataGridEquipPesquisar.DataSource = new Equipamento().Select();

            //Altera o titulo de todas as colunas para negrito.
            dataGridEquipPesquisar.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);

            //Altera a ordem das linhas, do maior para o menor numero de ID, somente quando houver linhas na coluna.
            if (dataGridEquipPesquisar.Rows != null && dataGridEquipPesquisar.Rows.Count != 0)
            {
                dataGridEquipPesquisar.Sort(dataGridEquipPesquisar.Columns["ID"], System.ComponentModel.ListSortDirection.Descending);
            }

            //Centraliza os nomes (Head) de cada coluna id[0],codigo[1] e tipo de equipamento[4].
            dataGridEquipPesquisar.Columns["ID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridEquipPesquisar.Columns["TipoEquip"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridEquipPesquisar.Columns["Status"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridEquipPesquisar.Columns["Editar"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }


        //Chama o metodo listardataGridEquipPesquisar() quando der load na pagina.
        private void UcPesquisarEquipamentoTelaPrincipal_Load(object sender, EventArgs e)
        {
            listardataGridEquipPesquisar();
        }


        //Chama o metodo listardataGridEquipPesquisar() quando clicar no botao atualizar.
        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            listardataGridEquipPesquisar();
        }


        //Código para mostrar o icone do lápis sobre o botão e Editar Equipamento.
        private void DataGridEquipPesquisar_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            Image ImagemEditar = Properties.Resources.pencil_edit_button;

            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 3)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.pencil_edit_button.Width;
                var h = Properties.Resources.pencil_edit_button.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(ImagemEditar, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }


        //Mostrar o ToolTip nos botões de editar.
        private void DataGridEquipPesquisar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridEquipPesquisar.Columns[3].Index)
            {
                var cell = dataGridEquipPesquisar.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText = "Editar Equipamento";
            }

            //Define a cor verde para o Status Disponível e laranja avermelhado para o Status Indisponível.
            int columnIndex = 2;
            foreach (DataGridViewRow row in dataGridEquipPesquisar.Rows)
            {
                if (row.Cells[columnIndex].Value.ToString() == "Disponível")
                {
                    row.Cells[columnIndex].Style.BackColor = System.Drawing.Color.ForestGreen;
                }
                else
                {
                    row.Cells[columnIndex].Style.BackColor = System.Drawing.Color.OrangeRed;
                }
            }
        }


        //Código para abrir o UCEditarEquipamento ao clicar no icone de Editar(Lápis).
        private void DataGridEquipPesquisar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 3)
            {
                FormEditarEquipamento();
            }
        }


        //Aciona o Form que edita os valores de cada linha.
        private void FormEditarEquipamento()
        {
            EditarEquipamento Editar = new EditarEquipamento();
            Editar.txtId.Text = this.dataGridEquipPesquisar.CurrentRow.Cells[0].Value.ToString();
            Editar.cboTipoEquip.Text = this.dataGridEquipPesquisar.CurrentRow.Cells[1].Value.ToString();
            Editar.txtStatus.Text = this.dataGridEquipPesquisar.CurrentRow.Cells[2].Value.ToString();
            Editar.ShowDialog();
        }


        //Pesquisa na coluna Status do datagrid a disponibilidade do item.
        private void CboStatusPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridEquipPesquisar.DataSource;

            if (cboStatusPesquisa.Text == "Equipamentos Indisponíveis")
            {
                bs.Filter = dataGridEquipPesquisar.Columns[2].HeaderText + " LIKE 'Indisponível'";
            }
            else if (cboStatusPesquisa.Text == "Equipamentos Disponíveis")
            {
                bs.Filter = dataGridEquipPesquisar.Columns[2].HeaderText + " LIKE 'Disponível'";
            }
            else
            {
                bs.RemoveFilter();
            }
        }


        //Comandos para mudar a imagem do cursor do mouse ao entrar no botão de editar.
        private void dataGridEquipPesquisar_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
           if (e.RowIndex >= 0 && e.ColumnIndex >= 3)
            {
                dataGridEquipPesquisar.Cursor = Cursors.Hand;
            }
        }
        private void dataGridEquipPesquisar_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 3)
            {
                dataGridEquipPesquisar.Cursor = Cursors.Default;
            }
        }
    }
}