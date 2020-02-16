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
    public partial class UCDevolucao : UserControl
    {
        Emprestimo EmprestimoConexao = new Emprestimo();

        public UCDevolucao()
        {
            InitializeComponent();
        }

        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        //Metodo para listar o listardataGridDevolucao().
        public void listardataGriDevolucao()
        {
            //Desativa a geração automatica de colunas
            dataGridDevolucao.AutoGenerateColumns = false;

            //Desativa os resize das linhas
            dataGridDevolucao.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridDevolucao.AllowUserToResizeRows = false;

            //Da select no banco de dados para mostrar dentro do datagridview
            dataGridDevolucao.DataSource = new Emprestimo().Select("SELECT * FROM emprestimo WHERE status != 'Entregue';");

            //Altera o titulo de todas as colunas para negrito.
            dataGridDevolucao.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);

            //Altera a ordem das linhas, do maior para o menor numero de ID, somente quando houver linhas na coluna.
            if (dataGridDevolucao.Rows != null && dataGridDevolucao.Rows.Count != 0)
            {
                dataGridDevolucao.Sort(dataGridDevolucao.Columns["ID"], System.ComponentModel.ListSortDirection.Descending);
            }

            //Centraliza os nomes (Head) de cada coluna id[0],codigo[1] e tipo de equipamento[4].
            dataGridDevolucao.Columns["ID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridDevolucao.Columns["Nome"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridDevolucao.Columns["DataFinalEmprestimo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridDevolucao.Columns["Status"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridDevolucao.Columns["Entregar"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        //Chama o metodo listardataGridEquipPesquisar() quando der load na página.
        private void UCDevolucao_Load(object sender, EventArgs e)
        {
            listardataGriDevolucao();

            //Atualiza a lista de status de entrega dos emprestimos feitos que estao pendentes e nao forma entregues no tempo (atrasado)
            EmprestimoConexao.Updatestatusatraso();
        }


                //Mostrar o ToolTip nos botões de verificar id.
        private void DataGridEmprestimosFeitos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridDevolucao.Columns[4].Index)
            {
                var cell = dataGridDevolucao.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText = "Entregar";
            }


            //Define a cor verde para o Status Entregue,laranja avermelhado para o Pendente e vermelho para Atrasado.
            int columnIndex = 3;
            foreach (DataGridViewRow row in dataGridDevolucao.Rows)
            {
                if (row.Cells[columnIndex].Value.ToString() == "Pendente")
                {
                    row.Cells[columnIndex].Style.BackColor = System.Drawing.Color.OrangeRed;
                }
                else if (row.Cells[columnIndex].Value.ToString() == "Atrasado")
                {
                    row.Cells[columnIndex].Style.BackColor = System.Drawing.Color.Red;
                }
                else if (row.Cells[columnIndex].Value.ToString() == "Entregue")
                {
                    row.Cells[columnIndex].Style.BackColor = System.Drawing.Color.ForestGreen;
                }
            }
        }


        //Código para abrir o UCEditarEquipamento ao clicar no icone/botão do Lápis.
        private void DataGridEmprestimosFeitos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 4)
            {
                FormEntrega();
            }
        }


        //Aciona o Form que verifica o nome dos requisitantes.
        private void FormEntrega()
        {
            EntregarEquipamento entregar = new EntregarEquipamento();
            entregar.txtIdEmprestimo.Text = this.dataGridDevolucao.CurrentRow.Cells[0].Value.ToString();
            entregar.txtIdRequisitante.Text = this.dataGridDevolucao.CurrentRow.Cells[1].Value.ToString();
            entregar.ShowDialog();
        }


        //Comandos para mudar a imagem do cursor do mouse ao entrar no botão informações.
        private void DataGridEmprestimosFeitos_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 4)
            {
                dataGridDevolucao.Cursor = Cursors.Hand;
            }
        }
        private void DataGridEmprestimosFeitos_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 4)
            {
                dataGridDevolucao.Cursor = Cursors.Default;
            }
        }


        //Código para mostrar o icone de informacao sobre os botões da coluna de id do requisitante.
        private void DataGridEmprestimosFeitos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            Image ImagemEditar = Properties.Resources.entrega;

            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 4)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.entrega.Width;
                var h = Properties.Resources.entrega.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(ImagemEditar, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }


        //Chama o método listardataGriDevolucao() quando clicar no botão atualizar.
        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            listardataGriDevolucao();

            //Atualiza a lista de status de entrega dos emprestimos feitos que estao pendentes e nao forma entregues no tempo (atrasado)
            EmprestimoConexao.Updatestatusatraso();
        }


        //Pesquisa na coluna Status do datagrid o status do emprestimo ATRASADO ou PENDENTE.
        private void CboStatusPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource filtro = new BindingSource();
            filtro.DataSource = dataGridDevolucao.DataSource;

            if (cboStatusPesquisa.Text == "Empréstimos Pendentes")
            {
                filtro.Filter = dataGridDevolucao.Columns[3].HeaderText + " LIKE 'Pendente'";
            }
            else if (cboStatusPesquisa.Text == "Empréstimos Atrasados")
            {
                filtro.Filter = dataGridDevolucao.Columns[3].HeaderText + " LIKE 'Atrasado'";
            }
            else if (cboStatusPesquisa.Text == "Todos os Empréstimos")
            {
                filtro.RemoveFilter();
            }
        }
    }
}
