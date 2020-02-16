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
    public partial class FrmDisciplina : Form, ICadastro
    {
        List<Disciplina> listDisciplina;
        List<Professor> listProfessor;
        private int cargaHoraria;
        Conexao con;

        public FrmDisciplina()
        {
            InitializeComponent();
            popularCmbProf();
            listDisciplina = new List<Disciplina>();
            listProfessor = new List<Professor>();
            con = new Conexao();
            inicializarCmbProfessor();

        }

        private void inicializarCmbProfessor()
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

                CmbProfessor.DataSource = listProfessor;
                CmbProfessor.DisplayMember = "nome";
                CmbProfessor.ValueMember = "id";

                con.CloseConnection();
            }
        }

        private void popularCmbProf()
        {
            foreach (Professor p in Disciplina.ListProfessor)
            {
                CmbProfessor.Items.Add(p.Nome);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
     
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você deseja realmente cancelar? (Todos os campos serão zerados.)", "Cancelar", MessageBoxButtons.YesNo);
            if (result.Equals(DialogResult.Yes))
            {
                TxtCargaHoraria.Text = "";
                TxtNome.Text = "";
                TxtCargaHoraria.Focus();
            }
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você deseja realmente salvar ?", "Salvando...",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.Yes))
            {
                if (validarCargaHoraria())
                {
                    Disciplina disciplina = new Disciplina();

                    disciplina.CargaHoraria = this.cargaHoraria;
                    disciplina.Nome = TxtNome.Text;
                    disciplina.NomeProfessor = CmbProfessor.SelectedItem.ToString();
                    disciplina.IdProfessor = Convert.ToInt32(CmbProfessor.SelectedValue);

                    inserirDados(disciplina); 
                    
                    listDisciplina.Add(disciplina);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = listDisciplina;

                }
            }
        }

        private Boolean validarCargaHoraria()
        {
            try
            {
                string sCargaHora = TxtCargaHoraria.Text;

                if (sCargaHora.Trim().Equals(""))
                {
                    MessageBox.Show("Informe uma carga horária.", "Atenção !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtCargaHoraria.Text = "";
                    TxtCargaHoraria.Focus();
                    return false;
                }
                else if (Convert.ToInt32(sCargaHora.Trim()) > 1000)
                {
                    MessageBox.Show("A carga horária não pode ser maior que 1000 horas", "Atenção !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtCargaHoraria.Text = "";
                    TxtCargaHoraria.Focus();
                    return false;
                }

                else
                {
                    this.cargaHoraria = Convert.ToInt32(sCargaHora);
                    return true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                TxtCargaHoraria.Text = "";
                TxtCargaHoraria.Focus();
                return false;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            switch (MessageBox.Show(this, "Você deseja realmente fechar ?", "Fechando...", MessageBoxButtons.YesNo, MessageBoxIcon.Stop))
            {
                case DialogResult.No:
                    e.Cancel = true;
                    break;
                default:
                    break;
            }
        }

        public void cadastrar()
        {
            throw new NotImplementedException();
        }

        public bool validarDados()
        {
            throw new NotImplementedException();
        }

        public void lerDados()
        {
            throw new NotImplementedException();
        }

        public void excluir()
        {
            throw new NotImplementedException();
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
