using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using Model;

namespace Sistema
{
    public partial class EditarFuncionario : Form
    {
        Funcionario funcionario = new Funcionario();

        public EditarFuncionario()
        {
            InitializeComponent();
        }

        //Fecha o EditarFuncionário e volta para o UCPesquisarFuncionário.
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Método que abre uma conexão com o banco de dados e executa um SELECT exclusivo para o EditarFuncionário.
        private void SelectEditar()
        {
            btnVoltar.Focus();

            String source = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Ianes;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();

            String sqlSelectQuery = "SELECT * FROM funcionario WHERE Id=" + int.Parse(txtIdFuncEditar.Text);
            SqlCommand cmd = new SqlCommand(sqlSelectQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                txtNomeFuncEditar.Text = (dr["nome"].ToString());
                txtCpfFuncEditar.Text = (dr["cpf"].ToString());
                txtTelefoneFuncEditar.Text = (dr["telefone"].ToString());
                txtEmailFuncEditar.Text = (dr["email"].ToString());
            }
            con.Close();
        }

        //Método para chamar o método SELECT acima.
        private void EditarFuncionario_Load(object sender, EventArgs e)
        {
            SelectEditar();
        }

        //Método de validação para o campo "Nome" do forms "EditarFuncionário" que "seta" um erro quando o mesmo foi deixado vazio.
        private void NomeUpdate_Validating()
        {
            if (string.IsNullOrWhiteSpace(txtNomeFuncEditar.Text))
            {
                errEmailUpdate.SetError(txtNomeFuncEditar, "Campo não pode ser vazio");
            }
        }

        //Método de validação para o campo "CPF" do forms "EditarFuncionário" que "seta" um erro quando o mesmo foi deixado vazio.
        private void CpfUpdate_Validating()
        {
            if (string.IsNullOrWhiteSpace(txtCpfFuncEditar.Text))
            {
                errCpfUpdate.SetError(txtCpfFuncEditar, "Campo não pode ser vazio");
            }
        }

        //Método de validação para o campo "Telefone" do forms "EditarFuncionário" que "seta" um erro quando o mesmo foi deixado vazio.
        private void TelefoneUpdate_Validating()
        {
            if (string.IsNullOrWhiteSpace(txtTelefoneFuncEditar.Text))
            {
                errTelefoneUpdate.SetError(txtTelefoneFuncEditar, "Campo não pode ser vazio");
            }
        }

        //Método de validação para o campo "E-Mail" do forms "EditarFuncionário" que "seta" um erro quando o mesmo foi deixado vazio.
        private void EmailUpdate_Validating()
        {
            if (string.IsNullOrWhiteSpace(txtEmailFuncEditar.Text))
            {
                errEmailUpdate.SetError(txtEmailFuncEditar, "Campo não pode ser vazio");
            }
        }
        public bool IsEmailValid(string emailaddress)
        {
            try
            {
                MailAddress m = new MailAddress(emailaddress);
                return true;
            }
            catch (FormatException)
            {
                errEmailUpdate.SetError(txtEmailFuncEditar, "Favor inserir um email válido !!");
                return false;
            }
        }

        //Método que, ao verificar que todos os campos NÃO estão vazios, chama o método UPDATE da classe Funcionário.
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNomeFuncEditar.Text) && (!string.IsNullOrEmpty(txtCpfFuncEditar.Text))
                && (!string.IsNullOrEmpty(txtEmailFuncEditar.Text)) && IsEmailValid(txtEmailFuncEditar.Text) &&
               (!string.IsNullOrEmpty(txtTelefoneFuncEditar.Text)))
            {
                funcionario.Id = int.Parse(txtIdFuncEditar.Text);
                funcionario.Nome = txtNomeFuncEditar.Text;
                funcionario.Email = txtEmailFuncEditar.Text;
                funcionario.Cpf = txtCpfFuncEditar.Text;
                funcionario.Telefone = txtTelefoneFuncEditar.Text;
                funcionario.Tipo = cmbCargoFuncEditar.Text;

                if (funcionario.UpdateFuncionario())
                {
                    MessageBox.Show(
                        "Alterações salvas com sucesso !!",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "Falha ao alterar os dados !!",
                        "AVISO",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show(
                    string.Format(
                        "Um ou mais campos estão vazios, favor preenchê-los !!"),
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Hand);

                NomeUpdate_Validating();
                CpfUpdate_Validating();
                TelefoneUpdate_Validating();
                EmailUpdate_Validating();

                SelectEditar();
            }
        }

        //Métodos para o campo "Cargo" do forms "EditarFuncionário" que ao selecionar um item, limpa o ícone de erro e dá o foco no botão "Salvar".
        private void CmbCargoFuncEditar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbCargoFuncEditar != null)
            {
                errCargoUpdate.SetError(cmbCargoFuncEditar, "");
                btnSalvar.Focus();
            }
        }
        private void CmbCargoFuncEditar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar.Focus();
            }
        }

        //Métodos para o campo "Nome" do forms "EditarFuncionário" que ao adicionar algum caractere válido, limpa o ícone de erro e dá o foco no campo "CPF".
        private void TxtNomeFuncEditar_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNomeFuncEditar.Text))
            {
                txtNomeFuncEditar.Text.Trim();
            }
            else
            {
                errNomeUpdate.SetError(txtNomeFuncEditar, "");
            }
        }
        private void TxtNomeFuncEditar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCpfFuncEditar.Focus();
            }
        }

        //Métodos para o campo "CPF" do forms "EditarFuncionário" que ao adicionar algum caractere válido, limpa o ícone de erro e dá o foco no campo "Telefone".
        private void TxtCpfFuncEditar_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCpfFuncEditar.Text))
            {
                txtCpfFuncEditar.Text.Trim();
            }
            else
            {
                errCpfUpdate.SetError(txtCpfFuncEditar, "");
            }
        }
        private void TxtCpfFuncEditar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTelefoneFuncEditar.Focus();
            }
        }

        //Métodos para o campo "Telefone" do forms "EditarFuncionário" que ao adicionar algum caractere válido, limpa o ícone de erro e dá o foco no campo "E-Mail".
        private void TxtTelefoneFuncEditar_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefoneFuncEditar.Text))
            {
                txtTelefoneFuncEditar.Text.Trim();
            }
            else
            {
                errTelefoneUpdate.SetError(txtTelefoneFuncEditar, "");
            }
        }
        private void TxtTelefoneFuncEditar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmailFuncEditar.Focus();
            }
        }

        //Métodos para o campo "E-Mail" do forms "EditarFuncionário" que ao adicionar algum caractere válido, limpa o ícone de erro e dá o foco no campo "Cargo".
        private void TxtEmailFuncEditar_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmailFuncEditar.Text))
            {
                txtEmailFuncEditar.Text.Trim();
            }
            else
            {
                errEmailUpdate.SetError(txtEmailFuncEditar, "");
            }
        }
        private void TxtEmailFuncEditar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbCargoFuncEditar.Focus();
            }
        }

        //Métodos para o campo "CPF" do forms "EditarFuncionário" que movem o cursor do mouse de volta para o inicío do campo. 
        private void TxtCpfFuncEditar_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtCpfFuncEditar.Select(0, 0);
            });
        }
        private void TxtCpfFuncEditar_MouseClick(object sender, MouseEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtCpfFuncEditar.Select(0, 0);
            });
        }

        //Métodos para o campo "Telefone" do forms "EditarFuncionário" que movem o cursor do mouse de volta para o inicío do campo.
        private void TxtTelefoneFuncEditar_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtTelefoneFuncEditar.Select(0, 0);
            });
        }
        private void TxtTelefoneFuncEditar_MouseClick(object sender, MouseEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtTelefoneFuncEditar.Select(0, 0);
            });
        }

        //Método de validação para o campo "Nome" que impede a inserção de números no mesmo.
        private void TxtNomeFuncEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Método de validação para o campo "E-Mail" que impede o uso da tecla SPACE no mesmo.
        private void TxtEmailFuncEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }

}
