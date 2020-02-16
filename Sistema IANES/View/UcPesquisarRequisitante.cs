using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace Sistema
{
    public partial class UcPesquisarRequisitante : UserControl
    {
        public UcPesquisarRequisitante()
        {
            InitializeComponent();
        }


        //Metodo para listar o listardataGridEquipPesquisar().
        public void listardataGridEquipPesquisar()
        {
            //Desativa a geração automatica de colunas
            dataGridRequisitantePesquisar.AutoGenerateColumns = false;

            //Desativa os resize das linhas
            dataGridRequisitantePesquisar.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridRequisitantePesquisar.AllowUserToResizeRows = false;

            //Da select no banco de dados para mostrar dentro do datagridview
            dataGridRequisitantePesquisar.DataSource = new Requisitante().Select();

            //Altera o titulo de todas as colunas para negrito.
            dataGridRequisitantePesquisar.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);

            //Centraliza os nomes (Head) de cada coluna id[0],codigo[1] e tipo de equipamento[4].
            dataGridRequisitantePesquisar.Columns["ID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridRequisitantePesquisar.Columns["Nome"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridRequisitantePesquisar.Columns["Editar"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }


        //Chama o metodo listardataGridEquipPesquisar() quando der load na pagina.
        private void UcPesquisarRequisitante_Load(object sender, EventArgs e)
        {
            listardataGridEquipPesquisar();
        }
        
        
        //Chama o metodo listardataGridEquipPesquisar() quando clicar no botao atualizar.
        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            listardataGridEquipPesquisar();
        }


        //Código para mostrar o icone do lápis sobre os botões de Editar.
        private void DataGridRequisitantePesquisar_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            Image ImagemEditar = Properties.Resources.pencil_edit_icon;

            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 2)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.pencil_edit_icon.Width;
                var h = Properties.Resources.pencil_edit_icon.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(ImagemEditar, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }


        //Mostrar o ToolTip nos botões de editar.
        private void DataGridRequisitantePesquisar_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridRequisitantePesquisar.Columns[2].Index)
            {
                var cell = dataGridRequisitantePesquisar.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText = "Editar Requisitante";
            }
        }


        //Código para abrir o Forms de editar requisitante ao clicar no icone de Editar(Lápis).
        private void DataGridRequisitantePesquisar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 2)
            {
                FormEditarRequisitante();
            }
        }


        //Aciona o Form que edita os valores dos requisitantes.
        private void FormEditarRequisitante()
        {
            EditarRequisitante Editar = new EditarRequisitante();
            Editar.txtId.Text = this.dataGridRequisitantePesquisar.CurrentRow.Cells[0].Value.ToString();
            Editar.txtNome.Text = this.dataGridRequisitantePesquisar.CurrentRow.Cells[1].Value.ToString();
            Editar.ShowDialog();
        }


        //Comandos para mudar a imagem do cursor do mouse ao entrar no botão de editar.
        private void DataGridRequisitantePesquisar_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 2)
            {
                dataGridRequisitantePesquisar.Cursor = Cursors.Hand;
            }
        }
        private void DataGridRequisitantePesquisar_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 2)
            {
                dataGridRequisitantePesquisar.Cursor = Cursors.Default;
            }
        }


        //Método que cria um filtro para o DataGridView filtrando o campo "Nome".
        private void TxtNome_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridRequisitantePesquisar.DataSource;
            bs.Filter = dataGridRequisitantePesquisar.Columns[1].HeaderText + " LIKE '%" + txtNome.Text + "%'";
        }
    }
}
