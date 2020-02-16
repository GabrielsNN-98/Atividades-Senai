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
    public partial class FrmProfessor : Form, ICadastro
    {
        static List<Professor> listProfessor;
        private int registro;
        private DateTime dataNascimento;
        private Conexao con;

        public FrmProfessor()
        {
            InitializeComponent();
            listProfessor = new List<Professor>();
            con = new Conexao();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BtnFechar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você deseja realmente salvar ?", "Salvando...",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result.Equals(DialogResult.Yes))
            {
                if (validarDados())
                {
                    Professor professor = new Professor();

                    professor.Registro = this.registro;
                    professor.Nome = TxtNome.Text;
                    professor.GrauForma = CmbGrauForma.SelectedItem.ToString();
                    professor.DtNasc = DtpDataNasc.Value.Date;

                    Disciplina.ListProfessor.Add(professor);

                    inserirDados(professor);

                    listProfessor.Add(professor);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = listProfessor;

                }
            }

        }

        private Boolean validarRegistro()
        {
            try
            {
                string sRegistro = TxtRegistro.Text;

                if (sRegistro.Trim().Equals(""))
                {
                    MessageBox.Show("Informe um registro.", "Atenção !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtRegistro.Text = "";
                    TxtRegistro.Focus();
                    return false;
                }
                else if (sRegistro.Trim().Length < 6)
                {
                    MessageBox.Show("Informe 6 dígitos.", "Atenção !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtRegistro.Text = "";
                    TxtRegistro.Focus();
                    return false;
                }

                else
                {
                    this.registro = Convert.ToInt32(sRegistro);
                    return true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                TxtRegistro.Text = "";
                TxtRegistro.Focus();
                return false;
            }
        }

        private Boolean validarIdade()
        {
            try
            {
                //tentativa
                dataNascimento = DtpDataNasc.Value;
                int idade = (DateTime.Today - dataNascimento.Date).Days / 365;

                if (idade < 20)
                {
                    MessageBox.Show("Idade mínima deve ser 20 anos!", "Atenção !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception exception)
            {
                //se gerar exceção
                MessageBox.Show(exception.Message);
                return false;
            }
        }

        private bool validarGrauForm()
        {
            if (CmbGrauForma.SelectedIndex == -1)
            {
                MessageBox.Show("Favor informar um grau de formação.", "Atenção !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você deseja realmente cancelar? (Todos os campos serão zerados.)", "Cancelar", MessageBoxButtons.YesNo);
            if (result.Equals(DialogResult.Yes))
            {
                TxtRegistro.Text = "";
                TxtNome.Text = "";
                DtpDataNasc.Value = DateTime.Today;
                CmbGrauForma.SelectedIndex = -1;
                TxtRegistro.Focus();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            switch (MessageBox.Show(this,"Você deseja realmente fechar ?", "Fechando...", MessageBoxButtons.YesNo, MessageBoxIcon.Stop))
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
            bool statusRegistro = validarRegistro();
            bool statusIdade = validarIdade();
            bool statusGrauForm = validarGrauForm();

            return statusRegistro && statusIdade && statusGrauForm;
        }

        public void lerDados()
        {
            throw new NotImplementedException();
        }

        public void excluir()
        {
            throw new NotImplementedException();
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
                cmd.Parameters.AddWithValue("@grau_forma", professor.GrauForma);

                cmd.ExecuteNonQuery();
                con.CloseConnection();
            }
        }
    }
}
