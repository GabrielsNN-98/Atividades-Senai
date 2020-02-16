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
    public class Emprestimo
    {
        public int Id { get; set; }
        public string local { get; set; }
        public DateTime dataHora { get; set; }
        public DateTime dataFinal { get; set; }
        public string descricao { get; set; }
        public string status { get; set; }
        public string idRequisitante { get; set; }
        public string idEquipamento { get; set; }

        //Metodo para Salvar do BD na tabela emprestimo.
        public bool InsertEmprestimo()
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
                    command.CommandText = "INSERT INTO emprestimo ([local],[dataHora], [dataFinal], [descricao], [status], [idRequisitante])" +
                                          "VALUES (@local,@dataHora,@dataFinal,@descricao,@status,@idRequisitante); SELECT SCOPE_IDENTITY();";

                    command.Parameters.Add("local", SqlDbType.VarChar).Value = local;
                    command.Parameters.Add("dataHora", SqlDbType.VarChar).Value = dataHora;
                    command.Parameters.Add("dataFinal", SqlDbType.VarChar).Value = dataFinal;
                    command.Parameters.Add("descricao", SqlDbType.VarChar).Value = descricao;
                    command.Parameters.Add("status", SqlDbType.VarChar).Value = "Pendente";
                    command.Parameters.Add("idrequisitante", SqlDbType.VarChar).Value = idRequisitante;

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
                        "Erro no Sistema EquipamentoModel -> InsertEmprestimo: {0}",
                        ex.Message
                        ),
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
                return false;
            }
        }



        //Metodo para pegar do BD os campos ja SALVOS na tabela emprestimo.
        public DataTable Select(string SelectEmprestimo)
        {
            DataTable emprestimo = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = Properties.Settings.Default.ConnectionString;

                    connection.Open();

                    SqlCommand command = new SqlCommand();

                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "" + SelectEmprestimo + "";

                    SqlDataReader query = command.ExecuteReader();

                    if (query.HasRows)
                    {
                        emprestimo.Load(query);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    string.Format(
                        "Erro no Sistema EmprestimoModel -> SelectDevolucaoEmprestimo: {0}",
                        ex.Message
                        ),
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }
            return emprestimo;
        }



        //Metodo para dar select na tablea item e retornar apenas o valor informado por C.
        public DataTable SelectEmprestimoItem(int idemprestimo)
        {
            DataTable emprestimo = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = Properties.Settings.Default.ConnectionString;

                    connection.Open();

                    SqlCommand command = new SqlCommand();

                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT dbo.equipamento.id, dbo.equipamento.tipo FROM dbo.equipamento " +
                                          "INNER JOIN dbo.item ON dbo.equipamento.id = dbo.item.idEquipamento " +
                                          "INNER JOIN dbo.emprestimo ON dbo.emprestimo.id = dbo.item.idEmprestimo " +
                                          "WHERE dbo.emprestimo.id=" + idemprestimo;

                    SqlDataReader query = command.ExecuteReader();

                    if (query.HasRows)
                    {
                        emprestimo.Load(query);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    string.Format(
                        "Erro no Sistema EmprestimoModel -> SelectemprestimoItem: {0}",
                        ex.Message
                        ),
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }
            return emprestimo;
        }



        //Metodo para dar update no BD na tabela emprestimo para dar update no emprestimo que foi entregue
        public bool Updatestatusentrega(int id)
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
                    command.CommandText = "UPDATE emprestimo SET status='Entregue' WHERE Id= " + id;

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
                        "Erro no sistema EmprestimoModel -> Updatestatusentregas: {0}",
                        ex.Message
                    ),
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                return false;
            }
        }



        //Metodo para dar update no BD na tabela emprestimo para dar update no emprestimo que nao foi entregue(estando pendente) e sua data de entrega e menor que a data atual
        public bool Updatestatusatraso()
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
                    command.CommandText = "UPDATE emprestimo SET status = 'Atrasado' WHERE dataFinal < (SELECT CONVERT (date, SYSDATETIME())) AND status = 'Pendente'";

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
                        "Erro no sistema EmprestimoModel -> Updatestatusatraso: {0}",
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