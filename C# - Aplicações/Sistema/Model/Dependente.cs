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
    public class Dependente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string DataNasc { get; set; }

        public DataTable Select()
        {
            DataTable dependentes = new DataTable();

            try
            {
                using (SqlConnection connection = new SqlConnection())
                {
                    connection.ConnectionString = Properties.Settings.Default.ConnectionString;

                    connection.Open();

                    SqlCommand command = new SqlCommand();

                    command.Connection = connection;
                    command.CommandType = CommandType.Text;
                    command.CommandText = "SELECT * FROM dependente;";

                    SqlDataReader query = command.ExecuteReader();

                    if (query.HasRows)
                        dependentes.Load(query);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    string.Format(
                        "Erro no Sistema DependenteModel -> Select: {0}",
                        ex.Message
                        ),
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            }
            return dependentes;
        }
    }
}
