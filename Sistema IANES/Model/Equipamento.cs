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
    public class Equipamento
    {
        public int Id { get; set; }
        public string tipo { get; set; }
        public string status { get; set; }
        public string descricao { get; set; }
        public string marca { get; set; }
        public string serialFabrica { get; set; }



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
                    command.CommandText = "INSERT INTO equipamento ([serialFabrica],[status], [marca], [tipo], [descricao])" +
                                          "VALUES (@serialFabrica,@status,@marca,@tipo,@descricao); SELECT SCOPE_IDENTITY();";

                    command.Parameters.Add("serialFabrica", SqlDbType.VarChar).Value = serialFabrica;
                    command.Parameters.Add("status", SqlDbType.VarChar).Value = status;
                    command.Parameters.Add("marca", SqlDbType.VarChar).Value = marca;
                    command.Parameters.Add("tipo", SqlDbType.VarChar).Value = tipo;
                    command.Parameters.Add("descricao", SqlDbType.VarChar).Value = descricao;

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
                        "Erro no Sistema EquipamentoModel -> Insert: {0}",
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
            DataTable equipamento = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = Properties.Settings.Default.ConnectionString;

                    connection.Open();

                    SqlCommand command = new SqlCommand();

                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT * FROM equipamento;";

                    SqlDataReader query = command.ExecuteReader();

                    if (query.HasRows)
                    {
                        equipamento.Load(query);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    string.Format(
                        "Erro no Sistema EquipamentoModel -> Select: {0}",
                        ex.Message
                        ),
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }
            return equipamento;
        }


        //Metodo para dar update no BG
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
                    command.CommandText = "UPDATE equipamento SET tipo = @Tipo, marca = @marca, serialFabrica = @serialFabrica,descricao = @descricao WHERE Id = @Id;";

                    command.Parameters.Add("Id", SqlDbType.Int).Value = Id;
                    command.Parameters.Add("tipo", SqlDbType.VarChar).Value = tipo;
                    command.Parameters.Add("marca", SqlDbType.VarChar).Value = marca;
                    command.Parameters.Add("serialFabrica", SqlDbType.VarChar).Value = serialFabrica;
                    command.Parameters.Add("descricao", SqlDbType.VarChar).Value = descricao;

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
                        "Erro no sistema EquipamentoModel -> Update: {0}",
                        ex.Message
                    ),
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
        }

        public DataTable SelectEquipamento()
        {
            DataTable equipamento = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = Properties.Settings.Default.ConnectionString;

                    connection.Open();

                    SqlCommand command = new SqlCommand();

                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT * FROM equipamento WHERE status= 'Disponível'";

                    SqlDataReader query = command.ExecuteReader();

                    if (query.HasRows)
                    {
                        equipamento.Load(query);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    string.Format(
                        "Erro no Sistema EmprestimoModel -> SelectEquipamento: {0}",
                        ex.Message
                        ),
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }
            return equipamento;
        }
    }
}