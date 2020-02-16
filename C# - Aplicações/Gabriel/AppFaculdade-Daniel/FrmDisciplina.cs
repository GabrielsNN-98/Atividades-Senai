using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AppFaculdade
{
    public partial class FrmDisciplina : Form
    {
        private Conexao con;
        List<Professor> listProfessor;

        Disciplina disciplina;
        public FrmDisciplina()
        {
            InitializeComponent();
            con = new Conexao();
            listProfessor = new List<Professor>();
            inicializaCmbProfessor();
            disciplina = new Disciplina();
        }

        private void inicializaCmbProfessor()
        {
            String sql;
            sql = "select * from tb_professor";

            if (con.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.connection);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Professor professor = new Professor();

                    professor.Id = reader.GetInt32(0);
                    professor.Nome = reader.GetString(1);

                    listProfessor.Add(professor);
                }

                cmbProfessor.DataSource = listProfessor;
                cmbProfessor.DisplayMember = "nome";
                cmbProfessor.ValueMember = "id";

                con.CloseConnection();
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            disciplina.Nome = txtNome.Text;
            disciplina.CargaHoraria = Convert.ToInt32(txtCargaHoraria.Text);
            disciplina.IdProfessor = Convert.ToInt32(cmbProfessor.SelectedValue);

            inserirDados(disciplina);
        }

        private void inserirDados(Disciplina disciplina)
        {
            String sql;
            sql = "insert into tb_disciplina (nome, carga_horaria, id_professor) values (@nome, @carga_horaria, @id_professor)";

            if (con.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.connection);

                cmd.Parameters.AddWithValue("@nome", disciplina.Nome);
                cmd.Parameters.AddWithValue("@carga_horaria", disciplina.CargaHoraria);
                cmd.Parameters.AddWithValue("@id_professor", disciplina.IdProfessor);

                cmd.ExecuteNonQuery();
                con.CloseConnection();
            }
        }
    }
}
