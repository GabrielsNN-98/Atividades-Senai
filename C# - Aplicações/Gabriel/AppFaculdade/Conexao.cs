using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace AppFaculdade
{
    class Conexao
    {
        public static MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public Conexao()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "db_faculdade";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";
            connection = new MySqlConnection(connectionString);
        }

        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        Console.WriteLine("Cannot connect to server. Contact administrator.");
                        break;
                    case 1045:
                        Console.WriteLine("Invalid username/password, please try again.");
                        break;
                }
                return false;
            }
        }

        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
