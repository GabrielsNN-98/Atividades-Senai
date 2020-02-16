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
    public partial class UCAddEmprestimo : UserControl
    {
        public UCAddEmprestimo()
        {
            InitializeComponent();
        }


        //Metodo para listar o listardataGridRequisitante().
        public void listardataGridRequisitante()
        {
            //Desativa a geração automatica de colunas
            dataGridRequisitante.AutoGenerateColumns = false;

            //Desativa os resize das linhas
            dataGridRequisitante.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridRequisitante.AllowUserToResizeRows = false;

            //Da select no banco de dados para mostrar dentro do datagridview
            dataGridRequisitante.DataSource = new Requisitante().SelectRequisitante();

            //Altera o titulo de todas as colunas para negrito.
            dataGridRequisitante.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);

            //Centraliza os nomes (Head) de cada coluna id[0],codigo[1] e tipo de equipamento[4].
            dataGridRequisitante.Columns["ID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridRequisitante.Columns["Nome"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }


        //Chama o metodo listardataGridRequisitante() quando der load na pagina.
        private void UCAddEmprestimo_Load(object sender, EventArgs e)
        {
            listardataGridRequisitante();
        }


        //Método que cria um filtro para o DataGridView filtrando o campo "Nome".
        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            BindingSource bs = new BindingSource();
            bs.DataSource = dataGridRequisitante.DataSource;
            bs.Filter = dataGridRequisitante.Columns[1].HeaderText + " LIKE '%" + txtNome.Text + "%'";
        }


        //Aciona o Form que seleciona os equipamentos para o emprestimo.
        private void FormEditarRequisitante()
        {
            RealizarEmprestimo Editar = new RealizarEmprestimo();
            Editar.txtId.Text = this.dataGridRequisitante.CurrentRow.Cells[0].Value.ToString();
            Editar.txtNome.Text = this.dataGridRequisitante.CurrentRow.Cells[1].Value.ToString();
            Editar.ShowDialog();
        }


        //Evento para abrir o form de editar requisitante quando for clicado 2 vezes na linha desejada.
        private void dataGridRequisitante_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Codigo para bloquear o Header de bugar no doubleclick.
            if (e.RowIndex == -1)
                return;

            FormEditarRequisitante();
        }


        //Evento para bloquear digitar número no campo de pesquisar nome.
        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        //Chama o método listardataGridRequisitante() quando clicar no botão atualizar.
        private void BtnAtualizar_Click(object sender, EventArgs e)
        {
            listardataGridRequisitante();
        }
    }
}
