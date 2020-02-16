using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Model;
using System.Globalization;

namespace Sistema
{
    public partial class UCPesquisarEmpretimoFeito : UserControl
    {
        public UCPesquisarEmpretimoFeito()
        {
            InitializeComponent();
        }
        Emprestimo EmprestimoConexao = new Emprestimo();

        //Metodo para listar o listardataGridEquipPesquisar().
        public void listarDataGridEmprestimosFeitos()
        {
            //Desativa a geração automatica de colunas
            dataGridEmprestimosFeitos.AutoGenerateColumns = false;

            //Da select no banco de dados para mostrar dentro do datagridview
            dataGridEmprestimosFeitos.DataSource = new Emprestimo().Select("SELECT * FROM emprestimo;");

            //Altera o titulo de todas as colunas para negrito.
            dataGridEmprestimosFeitos.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);

            //Altera a ordem das linhas, do maior para o menor numero de emprestimos, somente quando houver linhas na coluna.
            if (dataGridEmprestimosFeitos.Rows != null && dataGridEmprestimosFeitos.Rows.Count != 0)
            {
                dataGridEmprestimosFeitos.Sort(dataGridEmprestimosFeitos.Columns["ID"], System.ComponentModel.ListSortDirection.Descending);
            }

            //Centraliza os nomes (Head) de todas as colunas.
            dataGridEmprestimosFeitos.Columns["ID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridEmprestimosFeitos.Columns["Nome"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridEmprestimosFeitos.Columns["DataEmprestimo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridEmprestimosFeitos.Columns["DataFinalEmprestimo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridEmprestimosFeitos.Columns["Status"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridEmprestimosFeitos.Columns["VerificarInformacoes"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }


        //Chama o metodo listarDataGridEmprestimosFeitos() quando der load na página.
        private void UCEmpretimoFeito_Load(object sender, EventArgs e)
        {
            listarDataGridEmprestimosFeitos();


            //Atualiza a lista de status de entrega dos emprestimos feitos que estao pendentes e nao forma entregues no tempo (atrasado)
            EmprestimoConexao.Updatestatusatraso();
        }


        //Chama o método listarDataGridEmprestimosFeitos() quando clicar no botão atualizar.
        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            cboStatusPesquisa.SelectedIndex = -1;
            listarDataGridEmprestimosFeitos();

            //Atualiza a lista de status de entrega dos emprestimos feitos que estao pendentes e nao forma entregues no tempo (atrasado)
            EmprestimoConexao.Updatestatusatraso();
        }


        //Evento para bloquear digitar número no campo de pesquisar nome.
        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        //Mostrar o ToolTip nos botões de verificar id.
        private void DataGridEmprestimosFeitos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridEmprestimosFeitos.Columns[5].Index)
            {
                var cell = dataGridEmprestimosFeitos.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText = "Mais Informações";
            }


            //Define a cor verde para o Status Entregue,laranja avermelhado para o Pendente e vermelho para Atrasado.
            int columnIndex = 4;
            foreach (DataGridViewRow row in dataGridEmprestimosFeitos.Rows)
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


        //Pesquisa na coluna Status do datagrid o status do emprestimo.
        private void CboStatusPesquisa_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindingSource filtro = new BindingSource();
            filtro.DataSource = dataGridEmprestimosFeitos.DataSource;

            if (cboStatusPesquisa.Text == "Empréstimos Entregues")
            {
                filtro.Filter = dataGridEmprestimosFeitos.Columns[4].HeaderText + " LIKE 'Entregue'";
            }
            else if (cboStatusPesquisa.Text == "Empréstimos Pendentes")
            {
                filtro.Filter = dataGridEmprestimosFeitos.Columns[4].HeaderText + " LIKE 'Pendente'";
            }
            else if (cboStatusPesquisa.Text == "Empréstimos Atrasados")
            {
                filtro.Filter = dataGridEmprestimosFeitos.Columns[4].HeaderText + " LIKE 'Atrasado'";
            }
            else if (cboStatusPesquisa.Text == "Todos os Empréstimos")
            {
                filtro.RemoveFilter();
            }
        }


        //Código para abrir o UCEditarEquipamento ao clicar no icone do Lápis.
        private void DataGridEmprestimosFeitos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 5)
            {
                FormInformacao();
            }
        }


        //Aciona o Form que verifica o informacoes sobre o emprestimo.
        private void FormInformacao()
        {
            InformacoesEmprestimos informacoes = new InformacoesEmprestimos();
            informacoes.txtIdRequisitante.Text = this.dataGridEmprestimosFeitos.CurrentRow.Cells[1].Value.ToString();
            informacoes.txtIdEmprestimo.Text = this.dataGridEmprestimosFeitos.CurrentRow.Cells[0].Value.ToString();
            informacoes.ShowDialog();
        }


        //Comandos para mudar a imagem do cursor do mouse ao entrar no botão informações.
        private void DataGridEmprestimosFeitos_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 5)
            {
                dataGridEmprestimosFeitos.Cursor = Cursors.Hand;
            }
        }
        private void DataGridEmprestimosFeitos_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 5)
            {
                dataGridEmprestimosFeitos.Cursor = Cursors.Default;
            }
        }


        //Código para mostrar o icone de informacao sobre os botões da coluna de id do requisitante.
        private void DataGridEmprestimosFeitos_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            Image ImagemEditar = Properties.Resources.icons8_informações1;

            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 5)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.icons8_informações1.Width;
                var h = Properties.Resources.icons8_informações1.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(ImagemEditar, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }
    }
}
