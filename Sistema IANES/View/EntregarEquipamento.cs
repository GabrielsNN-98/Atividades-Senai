using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Model;


namespace Sistema
{
    public partial class EntregarEquipamento : Form
    {
        Emprestimo EmprestimoUPD = new Emprestimo();

        public EntregarEquipamento()
        {
            InitializeComponent();
        }


        //Metodo para listar o dataGridEquipEmprestados().
        public void listardataGridEquipamentosEmprestados()
        {

            //Desativa a geração automatica de colunas
            dataGridEquipEmprestados.AutoGenerateColumns = false;

            //Desativa os resize das linhas
            dataGridEquipEmprestados.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            // DataGridColumnStyle.AllowUserToResizeRows = false;

            //Converte o valor do txtIdEmprestimo para int
            int idemprestimo = Convert.ToInt32(txtIdEmprestimo.Text);
            //Da select no banco de dados para mostrar dentro do datagridview
            dataGridEquipEmprestados.DataSource = new Emprestimo().SelectEmprestimoItem(idemprestimo);

            //Altera o titulo de todas as colunas para negrito.
            dataGridEquipEmprestados.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);

            //Altera a ordem das linhas, do menor para o maior numero de ID, somente quando houver linhas na coluna.
            if (dataGridEquipEmprestados.Rows != null && dataGridEquipEmprestados.Rows.Count != 0)
            {
                dataGridEquipEmprestados.Sort(dataGridEquipEmprestados.Columns["ID"], System.ComponentModel.ListSortDirection.Ascending);
            }

            //Centraliza os nomes (Head) de cada coluna id[0],codigo[1] e tipo de equipamento[4].
            dataGridEquipEmprestados.Columns["ID"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridEquipEmprestados.Columns["Tipoequip"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }


        //Abre uma conexão com o BD para pegar o nome do requisitante e a descricao do emprestimo;
        private void SelecionarConexaoAdd()
        {
            String source = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Ianes;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();

            String sqlSelectQuery = "SELECT * FROM requisitante WHERE Id=" + int.Parse(txtIdRequisitante.Text);
            SqlCommand cmd = new SqlCommand(sqlSelectQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtNome.Text = (dr["Nome"].ToString());
            }
            con.Close();



            String sources = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Ianes;Integrated Security=True";
            SqlConnection cons = new SqlConnection(sources);
            cons.Open();

            String sqlSelectQuerys = "SELECT * FROM emprestimo WHERE Id=" + int.Parse(txtIdEmprestimo.Text);
            SqlCommand cmds = new SqlCommand(sqlSelectQuerys, cons);
            SqlDataReader drs = cmds.ExecuteReader();
            if (drs.Read())
            {
                txtDescricao.Text = (drs["descricao"].ToString());
                cboLocalSala.Text = (drs["local"].ToString());
            }
            cons.Close();
        }


        //Evento para dar load na pagina.
        private void EntregarEquipamento_Load(object sender, EventArgs e)
        {
            SelecionarConexaoAdd();
            listardataGridEquipamentosEmprestados();
        }


        //Fecha o EntregarEquipamento e volta para o UCDevolucao.
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Abre uma conexão com o BD para salvar os dados da entrega.
        private void BtnEntregar_Click(object sender, EventArgs e)
        {
            //Converte o valor do txtIdEmprestimo para int
            int idemprestimo = Convert.ToInt32(txtIdEmprestimo.Text);

            //Mensagens de sucesso ou falha na devolucao do produto
            if (EmprestimoUPD.Updatestatusentrega(idemprestimo))
            {
                MessageBox.Show(
                    "Devolução feita com Sucesso!!!",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show(
                    "Falha ao Devolver Equipamentos!!!",
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);
            }


            //Conexao com o bd para UPDATE nos equipamentos na tabela equipamento status
            SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=Ianes;Integrated Security=True");
            for (int i = 0; i < dataGridEquipEmprestados.Rows.Count; i++)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(@"UPDATE equipamento SET equipamento.status = 'Disponível' WHERE equipamento.id = '" + dataGridEquipEmprestados.Rows[i].Cells["ID"].Value + "'", con);
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }
    }
}

