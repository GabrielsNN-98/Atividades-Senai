using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Model
{
    public class Requisitante
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string tipo { get; set; }



        //Metodo para inserir(salvar) os dados no BD.
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
                    command.CommandText = "INSERT INTO requisitante ([nome],[email], [telefone], [tipo])" +
                                          "VALUES (@nome,@email,@telefone,@tipo); SELECT SCOPE_IDENTITY();";

                    command.Parameters.Add("nome", SqlDbType.VarChar).Value = nome;
                    command.Parameters.Add("email", SqlDbType.VarChar).Value = email;
                    command.Parameters.Add("telefone", SqlDbType.VarChar).Value = telefone;
                    command.Parameters.Add("tipo", SqlDbType.VarChar).Value = tipo;

                    Id = int.Parse(command.ExecuteScalar().ToString());

                    if (Id != 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    string.Format(
                        "Erro no Sistema RequisitanteModel -> Insert: {0}",
                        ex.Message
                        ),
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
                return false;
            }
        }



        //Metodo para pegar do BD os campos ja SALVOS.
        public DataTable Select()
        {
            DataTable requisitante = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = Properties.Settings.Default.ConnectionString;

                    connection.Open();

                    SqlCommand command = new SqlCommand();

                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT * FROM requisitante;";

                    SqlDataReader query = command.ExecuteReader();

                    if (query.HasRows)
                    {
                        requisitante.Load(query);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    string.Format(
                        "Erro no Sistema RequisitanteModel -> Select: {0}",
                        ex.Message
                        ),
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }
            return requisitante;
        }




        //Metodo para dar update no BD
        public bool Update()
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
                    command.CommandText = "UPDATE requisitante SET nome = @nome, email = @email, telefone = @telefone, tipo = @tipo WHERE Id = @Id;";

                    command.Parameters.Add("Id", SqlDbType.Int).Value = Id;
                    command.Parameters.Add("nome", SqlDbType.VarChar).Value = nome;
                    command.Parameters.Add("email", SqlDbType.VarChar).Value = email;
                    command.Parameters.Add("telefone", SqlDbType.VarChar).Value = telefone;
                    command.Parameters.Add("tipo", SqlDbType.VarChar).Value = tipo;

                    if (command.ExecuteNonQuery() == 1)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    string.Format(
                        "Erro no sistema RequisitanteModel -> Update: {0}",
                        ex.Message
                    ),
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
        }

        //Metodo para pegar do BD os campos ja SALVOS na tabela requisitante.
        public DataTable SelectRequisitante()
        {
            DataTable requisitante = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = Properties.Settings.Default.ConnectionString;

                    connection.Open();

                    SqlCommand command = new SqlCommand();

                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT * FROM requisitante;";

                    SqlDataReader query = command.ExecuteReader();

                    if (query.HasRows)
                    {
                        requisitante.Load(query);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    string.Format(
                        "Erro no Sistema EmprestimoModel -> SelectRequisitante: {0}",
                        ex.Message
                        ),
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }
            return requisitante;
        }


    }
}
