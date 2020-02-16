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
    public partial class FrmProfessor : Form
    {
        private Conexao con;
        private Professor professor;
        public FrmProfessor()
        {
            InitializeComponent();
            professor = new Professor();
            con = new Conexao();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            professor.Nome = txtNome.Text;
            professor.Registro = Convert.ToInt32(txtRegistro.Text);
            professor.GrauFoma = cmbGrauForma.SelectedItem.ToString();
            professor.DtNasc = dtpDataNasc.Value;

            inserirDados(professor);
        }

        private void inserirDados(Professor professor)
        {
            String sql;
            sql = "insert into tb_professor (nome, dt_nascimento, registro, grau_forma) values (@nome, @dt_nascimento, @registro, @grau_forma)";

            if (con.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.connection);

                cmd.Parameters.AddWithValue("@nome", professor.Nome);
                cmd.Parameters.AddWithValue("@dt_nascimento", professor.DtNasc);
                cmd.Parameters.AddWithValue("@registro", professor.Registro);
                cmd.Parameters.AddWithValue("@grau_forma", professor.GrauFoma);

                cmd.ExecuteNonQuery();
                con.CloseConnection();
            }
        }
    }
}
