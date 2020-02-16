using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Model
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Tipo { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }

        //Método que abre uma conexão com o banco de dados e executa um INSERT.
        public bool InsertFuncionario()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = Properties.Settings.Default.ConnectionString;

                    connection.Open();

                    SqlCommand command = new SqlCommand
                    {
                        Connection = connection,
                        CommandType = CommandType.Text,
                        CommandText = "INSERT INTO funcionario ([nome], [cpf], [email], [telefone], [tipo], [login], [senha]) " +
                                      "VALUES (@nome,@cpf,@email,@telefone,@tipo,@login,@senha); SELECT SCOPE_IDENTITY();"
                    };

                    command.Parameters.Add("nome", SqlDbType.VarChar).Value = Nome;
                    command.Parameters.Add("cpf", SqlDbType.VarChar).Value = Cpf;
                    command.Parameters.Add("email", SqlDbType.VarChar).Value = Email;
                    command.Parameters.Add("telefone", SqlDbType.VarChar).Value = Telefone;
                    command.Parameters.Add("tipo", SqlDbType.VarChar).Value = Tipo;
                    command.Parameters.Add("login", SqlDbType.VarChar).Value = Login;
                    command.Parameters.Add("senha", SqlDbType.VarChar).Value = Senha;

                    Id = int.Parse(command.ExecuteScalar().ToString());

                    if (Id != 0)
                        return true;

                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    string.Format(
                        "Erro no Sistema FuncionarioModel -> Insert: {0}",
                        ex.Message
                    ),
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }
        }

        //Método que abre uma conexão com o banco de dados e executa um SELECT.
        public DataTable SelectFuncionario()
        {
            DataTable funcionario = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = Properties.Settings.Default.ConnectionString;

                    connection.Open();

                    SqlCommand command = new SqlCommand
                    {
                        Connection = connection,
                        CommandType = CommandType.Text,
                        CommandText = "SELECT id, nome, cpf, tipo FROM funcionario;"
                    };

                    SqlDataReader query = command.ExecuteReader();

                    if (query.HasRows)
                        funcionario.Load(query);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    string.Format(
                        "Erro no Sistema FuncionarioModel -> Select: {0}", 
                        ex.Message
                        ),
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }
            return funcionario;
        }

        //Método que abre uma conexão com o banco de dados e executa um UPDATE.
        public bool UpdateFuncionario()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = Properties.Settings.Default.ConnectionString;

                    connection.Open();

                    SqlCommand command = new SqlCommand
                    {
                        Connection = connection,
                        CommandType = CommandType.Text,
                        CommandText = "UPDATE funcionario " +
                                          "SET nome = @Nome, cpf = @Cpf, email = @Email, telefone = @Telefone, " +
                                          "tipo = @Tipo WHERE id = @Id;"
                    };

                    command.Parameters.Add("id", SqlDbType.Int).Value = Id;
                    command.Parameters.Add("nome", SqlDbType.VarChar).Value = Nome;
                    command.Parameters.Add("cpf", SqlDbType.VarChar).Value = Cpf;
                    command.Parameters.Add("email", SqlDbType.VarChar).Value = Email;
                    command.Parameters.Add("telefone", SqlDbType.VarChar).Value = Telefone;
                    command.Parameters.Add("tipo", SqlDbType.VarChar).Value = Tipo;

                    if (command.ExecuteNonQuery() == 1)
                        return true;

                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    string.Format(
                        "Erro no Sistema FuncionarioModel -> Update: {0}",
                        ex.Message
                    ),
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }
        }

    }
}
