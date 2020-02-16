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
    public class Socio
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }

        public DataTable Select()
        {
            DataTable socios = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = Properties.Settings.Default.ConnectionString;

                    connection.Open();

                    SqlCommand command = new SqlCommand();

                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT * FROM socio;";

                    /*ExecuteNonQuery  
                      ExecuteReader utilizado em SELECT com vários (0..N) registros. 
                      ExecuteScalar*/
                    SqlDataReader query = command.ExecuteReader();

                    //se o IF tiver apenas UM comando, não é necessário as chaves 
                    //mas o comando deve estar logo abaixo do IF.
                    if (query.HasRows)
                        socios.Load(query);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    string.Format(
                        "Erro no Sistema SocioModel -> Select: {0}", 
                        ex.Message
                        ),
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }
            return socios;
        }

        public bool Insert()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = Properties.Settings.Default.ConnectionString;

                    connection.Open();

                    SqlCommand command = new SqlCommand();

                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "INSERT INTO socio ([nome], [cpf]) " +
                                          "VALUES (@nome,@cpf); SELECT SCOPE_IDENTITY();";
                    /*Scope identity é uma função que retorna o ID do último registro inserido*/

                    command.Parameters.Add("nome", SqlDbType.VarChar).Value = Nome;
                    command.Parameters.Add("cpf", SqlDbType.VarChar).Value = Cpf;

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
                        "Erro no Sistema SocioModel -> Insert: {0}",
                        ex.Message
                    ),
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }
        }

        public bool Update()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    //Criar conexão
                    connection.ConnectionString = Properties.Settings.Default.ConnectionString;

                    //Abre a conexão
                    connection.Open();

                    //Defino qual comando será executado
                    SqlCommand command = new SqlCommand();

                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "UPDATE socio " +
                                          "SET nome = @nome, cpf = @cpf " +
                                          "WHERE id = @id;";

                    command.Parameters.Add("id", SqlDbType.Int).Value = Id;
                    command.Parameters.Add("nome", SqlDbType.VarChar).Value = Nome;
                    command.Parameters.Add("cpf", SqlDbType.VarChar).Value = Cpf;

                    //Executar o comando e verificar se tudo deu certo
                    if (command.ExecuteNonQuery() == 1)
                        return true;

                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    string.Format(
                        "Erro no Sistema SocioModel -> Update: {0}",
                        ex.Message
                    ),
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );

                return false;
            }
        }

        public bool Delete()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = Properties.Settings.Default.ConnectionString;

                    connection.Open();

                    SqlCommand command = new SqlCommand();

                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "DELETE socio " +
                                          "WHERE id = @id;";

                    command.Parameters.Add("id", SqlDbType.Int).Value = Id;

                    if (command.ExecuteNonQuery() == 1)
                        return true;

                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    string.Format(
                        "Erro no Sistema SocioModel -> Delete: {0}",
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
