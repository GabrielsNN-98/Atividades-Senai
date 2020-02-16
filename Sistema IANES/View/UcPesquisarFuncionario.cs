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
    public partial class UcPesquisarFuncionario : UserControl
    {
        public UcPesquisarFuncionario()
        {
            InitializeComponent();
        }

        //Método que realiza o método SELECT da classe Funcionario e que contém várias configurações do DataGridView "dataGridFuncionario".
        private void ListarDataGrid()
        {
            dataGridFuncionario.DataSource = new Funcionario().SelectFuncionario();
            dataGridFuncionario.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridFuncionario.AllowUserToResizeRows = false;
            dataGridFuncionario.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            dataGridFuncionario.Columns["ColumnId"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridFuncionario.Columns["ColumnNome"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridFuncionario.Columns["ColumnCPF"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridFuncionario.Columns["ColumnCargo"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridFuncionario.Columns["ColumnEditar"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        //Métodos que chamam o DataGridView "dataGridFuncionario"
        private void UcPesquisarFuncionario_Load(object sender, EventArgs e)
        {
            ListarDataGrid();
        }
        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            ListarDataGrid();
        }

        //Método que cria um filtro para o DataGridView "dataGridFuncionario" pelo campo "Nome" executando o comando LIKE.
        private void TxtNomeFuncPesquisa_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridFuncionario.DataSource;
            bs.Filter = dataGridFuncionario.Columns[2].HeaderText + " LIKE '%" + txtNomeFuncPesquisa.Text + "%'";
        }

        //Método que cria um filtro para o DataGridView "dataGridFuncionario" pelo campo "CPF" executando o comando LIKE.
        private void TxtCpfFuncPesquisa_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridFuncionario.DataSource;
            bs.Filter = dataGridFuncionario.Columns[3].HeaderText + " LIKE '%" + txtCpfFuncPesquisa.Text + "%'";
        }

        //Método de validação para o campo "Nome" que impede a inserção de números no mesmo.
        private void TxtNomeFuncPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Métodos para o campo "CPF" do UserControl "UcAdicionarFuncionario" que movem o cursor do mouse de volta para o inicío do campo.
        private void TxtCpfFuncPesquisa_MouseClick(object sender, MouseEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtCpfFuncPesquisa.Select(0, 0);
            });
        }
        private void TxtCpfFuncPesquisa_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtCpfFuncPesquisa.Select(0, 0);
            });
        }

        /*Método que chama o forms "EditarFuncionario" e "seta" os valores correspondentes a linha selecionada no DataGridView "dataGridFuncionario"
         nos campos "ID" e "Cargo" no forms "EditarFuncionario".*/ 
        private void FormEditarFuncionario()
        {
            EditarFuncionario Editar = new EditarFuncionario();
            Editar.txtIdFuncEditar.Text = this.dataGridFuncionario.CurrentRow.Cells[1].Value.ToString();
            Editar.cmbCargoFuncEditar.Text = this.dataGridFuncionario.CurrentRow.Cells[4].Value.ToString();
            Editar.ShowDialog();
        }

        //Método da coluna "Editar" no DataGridView "dataGridFuncionario" que chama o forms "EditarFuncionario".
        private void DataGridFuncionario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 0)
            {
                FormEditarFuncionario();
            }
        }

        //Métodos para mudar o cursor do mouse na coluna "Editar" do DataGridView "dataGridFuncionario".
        private void DataGridFuncionario_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                dataGridFuncionario.Cursor = Cursors.Hand;
            }
        }
        private void DataGridFuncionario_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 0)
            {
                dataGridFuncionario.Cursor = Cursors.Default;
            }
        }

        //Método para colocar uma imagem numa célula do DataGridView "dataGridFuncionario".
        private void DataGridFuncionario_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            Image ImagemEditar = Properties.Resources.pencil_edit_button;

            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 0)
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

        //Método para adicionar um ToolTip a coluna botão do DataGridView "dataGridFuncionario".
        private void DataGridFuncionario_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridFuncionario.Columns[0].Index)
            {
                var cell = dataGridFuncionario.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText = "Editar Funcionário";
            }
        }
    }
}
