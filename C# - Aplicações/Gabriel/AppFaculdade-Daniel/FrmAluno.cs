using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AppFaculdade
{
    public partial class FrmAluno : Form, ICadastro
    {
        List<Aluno> listAluno;

        private int ra;
        private int idAluno = 0;
        private DateTime dataNascimento, dataMatricula;
        private Conexao con;
        
        public FrmAluno()
        {
            InitializeComponent();

            listAluno = new List<Aluno>();
            con = new Conexao();
            atualizaGridViewAluno();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente fechar a aplicação?",
                "Saindo...", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (resultado == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente salvar?",
                "Salvando...", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);

            if (resultado == DialogResult.Yes)
            {
                if (validarDados())
                {
                    Aluno aluno = new Aluno();

                    aluno.Ra = this.ra;
                    aluno.Nome = txtNome.Text;
                    aluno.DtNasc = dtpDataNasc.Value;
                    aluno.DtMatr = dtpDataMatric.Value;

                    inserirDados(aluno);
                    
                }
            }
        }

        private void atualizaGridViewAluno()
        {
            dataGridViewAluno.DataSource = null;
            dataGridViewAluno.Rows.Clear();

            String sql;
            sql = "select * from tb_aluno";

            if (con.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                String[] linhaDados = new String[5];

                while (reader.Read())
                {
                    //percorre cada uma das colunas
                    for (int a = 0; a < 5; a++)
                    {
                        //verifica o tipo de dados da coluna
                        if (reader.GetFieldType(a).ToString() == "System.Int32")
                        {
                            linhaDados[a] = reader.GetInt32(a).ToString();                        
                        }
                        if (reader.GetFieldType(a).ToString() == "System.String")
                        {
                            linhaDados[a] = reader.GetString(a).ToString();
                        }
                        if (reader.GetFieldType(a).ToString() == "System.DateTime")
                        {
                            linhaDados[a] = reader.GetDateTime(a).Date.ToString();
                        }
                    }

                    dataGridViewAluno.Rows.Add(linhaDados);
                }
                dataGridViewAluno.Refresh();
                
                con.CloseConnection();
            }
        }        

        private Boolean validarDataMatricula()
        {
            try
            {
                dataMatricula = dtpDataMatric.Value;

                if(dataMatricula.Date <= (DateTime.Today).Date)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Data de Matrícula inválida!",
                        "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    
                    return false;
                }
            }catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
        }

        private Boolean validarIdade()
        {
            try
            {
                dataNascimento = dtpDataNasc.Value;
                int idade = (DateTime.Today - dataNascimento.Date).Days/365;

                if(idade < 17)
                {
                    MessageBox.Show("Idade mínima deve ser 17 anos!",
                        "Atenção", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
            finally
            {
                MessageBox.Show("Entrou no Finally");
            }            
            
        }

        private Boolean validarRa()
        {
            try
            {
                String sRa = txtRa.Text;

                if (sRa.Trim().Equals(""))
                {
                    MessageBox.Show("Informe um RA.");
                    txtRa.Focus();
                    return false;
                }
                else if (sRa.Trim().Length < 6)
                {
                    MessageBox.Show("Informe no mínimo 6 dígitos");
                    txtRa.Focus();
                    txtRa.Text = "";
                    return false;
                }
                else
                {
                    this.ra = Convert.ToInt32(sRa);
                    return true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                txtRa.Text = "";
                txtRa.Focus();
                return false;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente cancelar?",
                "Cancelando...", MessageBoxButtons.YesNo,
                MessageBoxIcon.Stop);

            if (resultado == DialogResult.Yes)
            {
                txtRa.Text = "";
                txtNome.Text = "";
                dtpDataNasc.Value = DateTime.Today;
                dtpDataMatric.Value = DateTime.Today;
            }
        }

        public void cadastrar()
        {
            throw new NotImplementedException();
        }

        public bool validarDados()
        {
            bool statusRa = validarRa();
            bool statusIdade = validarIdade();
            bool statusDataMatricula = validarDataMatricula();

            return statusRa && statusIdade && statusDataMatricula;
        }

        public void lerDados()
        {
            throw new NotImplementedException();
        }

        public void excluir()
        {
            throw new NotImplementedException();
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            if (!txtPesqId.Text.Trim().Equals(""))
            {
                pesquisarById(int.Parse(txtPesqId.Text.Trim()));
            }
            else if (!txtPesqRa.Text.Trim().Equals(""))
            {
                pesquisarByRa(int.Parse(txtPesqRa.Text.Trim()));
            }
            else
            {
                pesquisarByNome(txtPesqNome.Text.Trim());
            }
        }

        private void pesquisarById(int id)
        {
            dataGridViewAluno.DataSource = null;
            dataGridViewAluno.Rows.Clear();

            String sql;
            sql = "select * from tb_aluno where id = @id";

            if (con.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.connection);
                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataReader reader = cmd.ExecuteReader();

                String[] linhaDados = new String[5];

                while (reader.Read())
                {
                    //percorre cada uma das colunas
                    for (int a = 0; a < 5; a++)
                    {
                        //verifica o tipo de dados da coluna
                        if (reader.GetFieldType(a).ToString() == "System.Int32")
                        {
                            linhaDados[a] = reader.GetInt32(a).ToString();
                        }
                        if (reader.GetFieldType(a).ToString() == "System.String")
                        {
                            linhaDados[a] = reader.GetString(a).ToString();
                        }
                        if (reader.GetFieldType(a).ToString() == "System.DateTime")
                        {
                            linhaDados[a] = reader.GetDateTime(a).Date.ToString();
                        }
                    }

                    dataGridViewAluno.Rows.Add(linhaDados);
                }
                dataGridViewAluno.Refresh();

                con.CloseConnection();
            }
        }

        private void pesquisarByRa(int ra)
        {
            dataGridViewAluno.DataSource = null;
            dataGridViewAluno.Rows.Clear();

            String sql;
            sql = "select * from tb_aluno where ra = @ra";

            if (con.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.connection);
                cmd.Parameters.AddWithValue("@ra", ra);

                MySqlDataReader reader = cmd.ExecuteReader();

                String[] linhaDados = new String[5];

                while (reader.Read())
                {
                    //percorre cada uma das colunas
                    for (int a = 0; a < 5; a++)
                    {
                        //verifica o tipo de dados da coluna
                        if (reader.GetFieldType(a).ToString() == "System.Int32")
                        {
                            linhaDados[a] = reader.GetInt32(a).ToString();
                        }
                        if (reader.GetFieldType(a).ToString() == "System.String")
                        {
                            linhaDados[a] = reader.GetString(a).ToString();
                        }
                        if (reader.GetFieldType(a).ToString() == "System.DateTime")
                        {
                            linhaDados[a] = reader.GetDateTime(a).Date.ToString();
                        }
                    }

                    dataGridViewAluno.Rows.Add(linhaDados);
                }
                dataGridViewAluno.Refresh();

                con.CloseConnection();
            }
        }

        private void pesquisarByNome(string nome)
        {
            dataGridViewAluno.DataSource = null;
            dataGridViewAluno.Rows.Clear();

            String sql;
            sql = "select * from tb_aluno where nome like '%"+nome+"%'";

            if (con.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.connection);
                
                MySqlDataReader reader = cmd.ExecuteReader();

                String[] linhaDados = new String[5];

                while (reader.Read())
                {
                    //percorre cada uma das colunas
                    for (int a = 0; a < 5; a++)
                    {
                        //verifica o tipo de dados da coluna
                        if (reader.GetFieldType(a).ToString() == "System.Int32")
                        {
                            linhaDados[a] = reader.GetInt32(a).ToString();
                        }
                        if (reader.GetFieldType(a).ToString() == "System.String")
                        {
                            linhaDados[a] = reader.GetString(a).ToString();
                        }
                        if (reader.GetFieldType(a).ToString() == "System.DateTime")
                        {
                            linhaDados[a] = reader.GetDateTime(a).Date.ToString();
                        }
                    }

                    dataGridViewAluno.Rows.Add(linhaDados);
                }
                dataGridViewAluno.Refresh();

                con.CloseConnection();
            }
        }

        private void DataGridViewAluno_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataGridViewAluno.Rows[e.RowIndex].Cells[0].Value.ToString());
            if(e.ColumnIndex == 5)
            {
                if (MessageBox.Show("Deseja realmente editar este registro",
                    "Editando...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    editarDados(id);
                }
            }
            else if(e.ColumnIndex == 6)
            {
                if(MessageBox.Show("Deseja realmente excluir este registro",
                    "Excluindo...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    excluirDados(id);
                }                
            }
        }

        private void editarDados(int id)
        {
            String sql;
            sql = "select * from tb_aluno where id = @id";

            if (con.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.connection);
                cmd.Parameters.AddWithValue("@id", id);

                MySqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    txtRa.Text = reader.GetInt32(1).ToString();
                    txtNome.Text = reader.GetString(2).ToString();
                    dtpDataNasc.Value = reader.GetDateTime(3);
                    dtpDataMatric.Value = reader.GetDateTime(4);
                    idAluno = id;
                }

                con.CloseConnection();
            }
        }

        private void excluirDados(int id)
        {
            String sql;
            sql = "delete from tb_aluno where id = @id";

            if (con.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.connection);

                cmd.Parameters.AddWithValue("@id", id);
                
                cmd.ExecuteNonQuery();
                con.CloseConnection();
                atualizaGridViewAluno();
            }
        }

        private void inserirDados(Aluno aluno)
        {
            String sql = "";

            if(idAluno == 0)
            {
                sql = "insert into tb_aluno (nome, dt_nascimento, dt_matricula, ra) values (@nome, @dt_nascimento, @dt_matricula, @ra)";
            }else if (idAluno > 0)
            {
                sql = "update tb_aluno set nome = @nome, dt_nascimento = @dt_nascimento, dt_matricula = @dt_matricula, ra = @ra where id = @id";
            }
            

            if (con.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.connection);

                cmd.Parameters.AddWithValue("@nome", aluno.Nome);
                cmd.Parameters.AddWithValue("@dt_nascimento", aluno.DtNasc);
                cmd.Parameters.AddWithValue("@dt_matricula", aluno.DtMatr);
                cmd.Parameters.AddWithValue("@ra", aluno.Ra);
                if(idAluno > 0)
                {
                    cmd.Parameters.AddWithValue("@id", idAluno);
                    idAluno = 0;
                }

                cmd.ExecuteNonQuery();
                con.CloseConnection();
                atualizaGridViewAluno();
            }
        }
    }
}
