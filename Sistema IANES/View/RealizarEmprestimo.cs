using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;


namespace Sistema
{
    public partial class RealizarEmprestimo : Form
    {
        Emprestimo EmprestimoAdd = new Emprestimo();

        public RealizarEmprestimo()
        {
            InitializeComponent();
        }

        //Fecha o FormRealizarEmprestimo e volta para o UCAddEmprestimo.
        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Botão para salvar o emprestimo
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!cboLocalSala.Text.Equals("") && dataGridEmprestimo.Rows != null &&
                dataGridEmprestimo.Rows.Count != 0)
            {
                DateTime DatadoEmprestimo = DateTime.Now.Date;
                EmprestimoAdd.local = cboLocalSala.Text;
                EmprestimoAdd.dataHora = DatadoEmprestimo;
                EmprestimoAdd.dataFinal = dtPickerEmprestimo.Value.Date;
                EmprestimoAdd.descricao = txtDescricao.Text;
                EmprestimoAdd.idRequisitante = txtId.Text;

                if (EmprestimoAdd.InsertEmprestimo())
                {
                    MessageBox.Show(
                    "Emprestimo feito com Sucesso",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "Falha ao Emprestar Equipamentos!!!",
                        "AVISO",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Hand);
                }
            }
            else
            {
                CboLocalSala_Validating();
                DataGridEmprestimo_Validating();
            }


            //Conexao com o bd para  inserir/UPDATE nos equipamentos na tabela ITEM, e UPDATE na tabela equipamento status
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Ianes;Integrated Security=True");
            for (int i = 0; i < dataGridEmprestimo.Rows.Count; i++)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"INSERT INTO item (idEquipamento) VALUES('" + dataGridEmprestimo.Rows[i].Cells["IDEmpre"].Value + "')", con);
                SqlCommand cmds = new SqlCommand(@"UPDATE equipamento SET equipamento.status = 'Indisponível' WHERE equipamento.id = '" + dataGridEmprestimo.Rows[i].Cells["IDEmpre"].Value + "'", con);
                SqlCommand cmdss = new SqlCommand(@"UPDATE item SET item.idEmprestimo = emprestimo.id FROM emprestimo WHERE item.id = (SELECT MAX(id) FROM item) AND emprestimo.id = (SELECT MAX(id) FROM emprestimo)", con);
                cmd.ExecuteNonQuery();
                cmds.ExecuteNonQuery();
                cmdss.ExecuteNonQuery();
                con.Close();
            }
        }



        //Abre uma conexão com o BD para pegar valor do email,telefone e cargo do requisitante;
        private void SelecionarConexaoAdd()
        {
            String source = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Ianes;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();

            String sqlSelectQuery = "SELECT * FROM requisitante WHERE Id=" + int.Parse(txtId.Text);
            SqlCommand cmd = new SqlCommand(sqlSelectQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtCargo.Text = (dr["tipo"].ToString());
            }
            con.Close();
        }



        //Metodo para listar o listardataGridEquipamento().
        public void listardataGridEquipamento()
        {
            //Desativa a geração automatica de colunas
            dataGridEquipamento.AutoGenerateColumns = false;

            //Da select no banco de dados para mostrar dentro do datagridview
            dataGridEquipamento.DataSource = new Equipamento().SelectEquipamento();

            //Altera o titulo de todas as colunas para negrito.
            dataGridEquipamento.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);

            //Centraliza os nomes (Head) de cada coluna.
            dataGridEquipamento.Columns["IDEquip"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridEquipamento.Columns["TipoEquip"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridEquipamento.Columns["AddEquip"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }


        //Metodo para listar o listardataGridEmprestimo().
        public void listardataGridEmprestimo()
        {
            //Desativa a geração automatica de colunas
            dataGridEmprestimo.AutoGenerateColumns = false;

            //Altera o titulo de todas as colunas para negrito.
            dataGridEmprestimo.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);

            //Centraliza os nomes (Head) de cada coluna.
            dataGridEmprestimo.Columns["IDEmpre"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridEmprestimo.Columns["TipoEmpre"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridEmprestimo.Columns["ExcluirEmpre"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            //Altera a posição do error provider.
            errorProviderDatagrid.SetIconAlignment(dataGridEmprestimo, System.Windows.Forms.ErrorIconAlignment.TopLeft);
        }



        //Evento que roda ao dar LOAD na pagina chamando outros metodos.
        private void RealizarEmprestimo_Load(object sender, EventArgs e)
        {
            DateTime DatadeEntrega = DateTime.Now.AddDays(5);
            dtPickerEmprestimo.Value = DatadeEntrega;

            SelecionarConexaoAdd();
            listardataGridEquipamento();
            listardataGridEmprestimo();
        }



        //Evento para bloquear a data de entrega nos dias de sábado ou domingo.
        private void DtPickerEmprestimo_ValueChanged(object sender, EventArgs e)
        {
            DayOfWeek DataFinaldaEntrega = dtPickerEmprestimo.Value.DayOfWeek;

            if (DataFinaldaEntrega == DayOfWeek.Saturday)
            {
                DateTime DatadeEntrega = dtPickerEmprestimo.Value.AddDays(2);
                dtPickerEmprestimo.Value = DatadeEntrega;
            }
            else if (DataFinaldaEntrega == DayOfWeek.Sunday)
            {
                DateTime DatadeEntrega = dtPickerEmprestimo.Value.AddDays(1);
                dtPickerEmprestimo.Value = DatadeEntrega;
            }

        }



        //Código para enviar o equipamento selecionado para o datagridemprestimo ao clicar no botão.
        private void DataGridEquipamento_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 2)
            {
                foreach (DataGridViewRow row in this.dataGridEquipamento.SelectedRows)
                {
                    object[] rowData = new object[row.Cells.Count];
                    for (int i = 0; i < rowData.Length; ++i)
                    {
                        rowData[i] = row.Cells[i].Value;
                    }
                    this.dataGridEmprestimo.Rows.Add(rowData);
                    this.dataGridEquipamento.Rows.RemoveAt(row.Index);
                }
            }
        }
        //Código para excluir a linha do equipamento selecionado ao clicar no botão.
        private void DataGridEmprestimo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }
            if (e.ColumnIndex == 2)
            {
                foreach (DataGridViewRow row in this.dataGridEmprestimo.SelectedRows)
                {
                    this.dataGridEmprestimo.Rows.RemoveAt(row.Index);
                }
            }
        }



        //Evento para mostrar o icone de add sobre o botão de adicionar e remover sobre o botão de remover ..
        private void DataGridEquipamento_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            Image ImagemEditar = Properties.Resources.add;

            if (e.RowIndex < 0)
            {
                return;
            }

            if (e.ColumnIndex == 2)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.add.Width;
                var h = Properties.Resources.add.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(ImagemEditar, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }
        private void DataGridEmprestimo_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            Image ImagemEditar = Properties.Resources.remove;

            if (e.RowIndex < 0)
            {
                return;
            }


            if (e.ColumnIndex == 2)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var w = Properties.Resources.remove.Width;
                var h = Properties.Resources.remove.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

                e.Graphics.DrawImage(ImagemEditar, new Rectangle(x, y, w, h));
                e.Handled = true;
            }
        }



        //Comandos para mudar a imagem do cursor do mouse ao entrar no botão de adicionar equipamento ou remover equipamento.
        private void DataGridEquipamento_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 2)
            {
                dataGridEquipamento.Cursor = Cursors.Hand;
            }
        }
        private void DataGridEquipamento_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 2)
            {
                dataGridEquipamento.Cursor = Cursors.Default;
            }
        }
        private void DataGridEmprestimo_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 2)
            {
                dataGridEmprestimo.Cursor = Cursors.Hand;
            }
        }
        private void DataGridEmprestimo_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 2)
            {
                dataGridEmprestimo.Cursor = Cursors.Default;
            }
        }



        //ToolTip ao passar o mouse sobre o botão de adicionar equipamento ou remover equipamento.
        private void DataGridEquipamento_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridEquipamento.Columns[2].Index)
            {
                var cell = dataGridEquipamento.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText = "Adicionar Equipamento";
            }
        }
        private void DataGridEmprestimo_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == dataGridEmprestimo.Columns[2].Index)
            {
                var cell = dataGridEmprestimo.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.ToolTipText = "Remover Equipamento";
            }
        }



        //Insere uma frase ao passar o mause no error provider.
        private void CboLocalSala_Validating()
        {
            if (string.IsNullOrWhiteSpace(cboLocalSala.Text))
            {
                errorProviderLocal.SetError(cboLocalSala, "Insira o Local/Sala");
            }
        }
        private void DataGridEmprestimo_Validating()
        {
            if (dataGridEmprestimo.Rows.Count == 0)
            {
                errorProviderDatagrid.SetError(dataGridEmprestimo, "Necessário Inserir um Produto");
            }
        }



        //Codigo para o cbo sala, digitar algo != null ou apertar Enter da foco em outro campo, tambem remove o error provider caso esteja correto.
        private void cboLocalSala_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboLocalSala.SelectedItem != null)
            {
                errorProviderLocal.SetError(cboLocalSala, "");
                txtDescricao.Focus();
            }
        }
        private void cboLocalSala_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDescricao.Focus();
            }
        }
        private void TxtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                dataGridEquipamento.Focus();
            }
        }
        private void DataGridEmprestimo_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridEmprestimo.Rows != null && dataGridEmprestimo.Rows.Count != 0)
            {
                errorProviderDatagrid.SetError(dataGridEmprestimo, "");
            }
        }
    }
}
