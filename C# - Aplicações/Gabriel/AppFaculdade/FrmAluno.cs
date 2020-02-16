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
    public partial class FrmAluno : Form, ICadastro
    {
        List<Aluno> listAluno;
        private int ra;
        private DateTime dataNascimento, dataMatricula;
        private Conexao con;

        public FrmAluno()
        {
            InitializeComponent();
            listAluno = new List<Aluno>();
            con = new Conexao();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
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
                    Aluno aluno = new Aluno();

                    aluno.Ra = this.ra;
                    aluno.Nome = TxtNome.Text;
                    aluno.DtNasc = DtpDataNasc.Value.Date;
                    aluno.DtMatri = DtpDtMatri.Value.Date;

                    inserirDados(aluno);

                    listAluno.Add(aluno);

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = listAluno;
                }
            }
        }

        private Boolean validarRa()
        {
            try
            {
                string sRa = TxtRa.Text;

                if (sRa.Trim().Equals(""))
                {
                    MessageBox.Show("Informe um RA.","Atenção !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    TxtRa.Text = "";
                    TxtRa.Focus();
                    return false;
                }
                else if (sRa.Trim().Length < 6)
                {
                    MessageBox.Show("Informe 6 dígitos.");
                    TxtRa.Text = "";
                    TxtRa.Focus();
                    return false;
                }

                else
                {
                    this.ra = Convert.ToInt32(sRa);
                    return true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                TxtRa.Text = "";
                TxtRa.Focus();
                return false;
            }
        }

        private Boolean validarIdade()
        {
            try
            {
                //tentativa
                dataNascimento = DtpDataNasc.Value;
                int idade = (DateTime.Today - dataNascimento.Date).Days/365;

                if (idade < 17)
                {
                    MessageBox.Show("Idade mínima deve ser 17 anos!", "Atenção !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch(Exception exception)
            {
                //se gerar exceção
                MessageBox.Show(exception.Message);
                return false;
            }
            //finally
            //{
                //executar independente se entrar no try ou no catch
            //}
        }

        private Boolean validarDataMatricula()
        {
            try
            {
                dataMatricula = DtpDtMatri.Value;

                if (dataMatricula.Date <= (DateTime.Today).Date)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Data de matrícula inválida !", "Atenção !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
                return false;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Você deseja realmente cancelar ? (Todos os campos serão zerados.)", "Cancelando...",
            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result.Equals(DialogResult.Yes))
            {
                TxtRa.Text = "";
                TxtNome.Text = "";
                DtpDtMatri.Value = DateTime.Today;
                DtpDataNasc.Value = DateTime.Today;
                TxtRa.Focus();
            }
        }

        private void FrmAluno_Load(object sender, EventArgs e)
        {
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            // Confirm user wants to close
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
            bool statusRa = validarRa();
            bool statusIdade = validarIdade();
            bool statusDataMatricula = validarDataMatricula();

            return statusRa && statusIdade && statusDataMatricula;

        }

        public void lerDados()
        {
            throw new NotImplementedException();
        }

        public void excluir()
        {
            throw new NotImplementedException();
        }

        private void inserirDados(Aluno aluno)
        {
            String sql;
            sql = "insert into tb_aluno (nome, dt_nascimento, dt_matricula, ra) values (@nome, @dt_nascimento, @dt_matricula, @ra)";

            if (con.OpenConnection())
            {
                MySqlCommand cmd = new MySqlCommand(sql, Conexao.connection);

                cmd.Parameters.AddWithValue("@nome", aluno.Nome);
                cmd.Parameters.AddWithValue("@dt_nascimento", aluno.DtNasc);
                cmd.Parameters.AddWithValue("@dt_matricula", aluno.DtMatri);
                cmd.Parameters.AddWithValue("@ra", aluno.Ra);

                cmd.ExecuteNonQuery();
                con.CloseConnection();
            }
        }
    }
}
