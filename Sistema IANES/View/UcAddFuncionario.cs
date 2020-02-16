using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using Model;

namespace Sistema
{
    public partial class UcAddFuncionario : UserControl
    {
        readonly Funcionario funcionario = new Funcionario();

        public UcAddFuncionario()
        {
            InitializeComponent();

        }

        //Método de validação para o campo "Nome" do UserControl "UcAdicionarFuncionário" que "seta" um erro quando o mesmo foi deixado vazio.
        private void TxtNome_Validating()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                errNome.SetError(txtNome, "Favor inserir um nome !");
            }
        }

        //Método de validação para o campo "CPF" do UserControl "UcAdicionarFuncionário" que "seta" um erro quando o mesmo foi deixado vazio.
        private void TxtCpf_Validating()
        {
            if (!txtCpf.MaskCompleted)
            {
                errCpf.SetError(txtCpf, "Favor inserir o CPF !");
            }
        }

        /*Método de validação para o campo "E-Mail" do UserControl "UcAdicionarFuncionário" que "seta" erros quando o mesmo foi deixado vazio
        e quando não for inserido um email válido (nesse caso inválido se deve a falta dos caracteres característicos numa string de Email.)*/
        private void TxtEmail_Validating()
        {
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                errEmail.SetError(txtEmail, "Favor inserir um email !");
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
                errEmail.SetError(txtEmail, "Favor inserir um email válido !!");
                return false;
            }
        }

        //Método de validação para o campo "Telefone" do UserControl "UcAdicionarFuncionário" que "seta" um erro quando o mesmo foi deixado vazio.
        private void TxtTelefone_Validating()
        {
            if (!txtTelefone.MaskCompleted)
            {
                errTelefone.SetError(txtTelefone, "Favor inserir um telefone");
            }
        }

        //Método de validação para o campo "Cargo" do UserControl "UcAdicionarFuncionário" que "seta" um erro quando o mesmo foi deixado vazio.
        private void GrpCargo_Validating()
        {
            if (string.IsNullOrWhiteSpace(cmbCargo.Text))
            {
                errCargo.SetError(cmbCargo, "Favor selecionar um cargo !");
            }
        }

        //Método de validação para o campo "Login" do UserControl "UcAdicionarFuncionário" que "seta" um erro quando o mesmo foi deixado vazio.
        private void TxtLogin_Validating()
        {
            if (string.IsNullOrEmpty(txtLogin.Text))
            {
                errLogin.SetError(txtLogin, "Favor inserir um login válido");
            }
        }

        //Método de validação para o campo "Senha" do UserControl "UcAdicionarFuncionário" que "seta" um erro quando o mesmo foi deixado vazio.
        private void TxtSenha_Validating()
        {
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                errSenha.SetError(txtSenha, "Favor inserir uma senha");
            }
        }

        //Método de validação para o campo "Confirmar Senha" que "seta" um erro quando a "string" deste campo NÃO é igual a "string" do campo "Senha"
        private void TxtConfirmarSenha_Validating()
        {
            if (txtConfirmSenha.Text != txtSenha.Text)
            {
                errConfirmSenha.SetError(txtConfirmSenha, "As senhas não coincidem !");
            }
        }

        //Método que limpa TODOS os campos e erros.
        private void Limpar()
        {
            errNome.SetError(txtNome, null);
            txtNome.Clear();

            errCpf.SetError(txtCpf, null);
            txtCpf.Clear();

            errEmail.SetError(txtEmail, null);
            txtEmail.Clear();

            errTelefone.SetError(txtTelefone, null);
            txtTelefone.Clear();

            errCargo.SetError(cmbCargo, null);
            cmbCargo.SelectedIndex = -1;

            errLogin.SetError(txtLogin, null);
            txtLogin.Clear();

            errSenha.SetError(txtSenha, null);
            txtSenha.Clear();

            errConfirmSenha.SetError(txtConfirmSenha, null);
            txtConfirmSenha.Clear();


        }

        //Método que, ao verificar que todos os campos NÃO estão vazios, chama o método INSERT da classe Funcionário.
        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtNome.Text) && txtCpf.MaskCompleted && (!string.IsNullOrEmpty(txtEmail.Text)) 
                && IsEmailValid(txtEmail.Text) && txtTelefone.MaskCompleted && (!string.IsNullOrEmpty(cmbCargo.Text)) 
                && (!string.IsNullOrEmpty(txtLogin.Text)) && (!string.IsNullOrEmpty(txtSenha.Text)) 
                && txtConfirmSenha.Text == txtSenha.Text)
            {
                funcionario.Nome = txtNome.Text;
                funcionario.Cpf = txtCpf.Text;
                funcionario.Email = txtEmail.Text;
                funcionario.Tipo = cmbCargo.Text;
                funcionario.Telefone = txtTelefone.Text;
                funcionario.Login = txtLogin.Text;
                funcionario.Senha = txtSenha.Text;

                if (funcionario.InsertFuncionario())
                {
                    MessageBox.Show(
                    "Funcionário adicionado com sucesso !!",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                    Limpar();
                }
            }
            else
            {
                TxtNome_Validating();
                TxtCpf_Validating();
                TxtEmail_Validating();
                TxtTelefone_Validating();
                GrpCargo_Validating();
                TxtLogin_Validating();
                TxtSenha_Validating();
                TxtConfirmarSenha_Validating();
            }
        }

        //Métodos para o campo "Nome" do UserControl "UcAdicionarFuncionario" que ao adicionar algum caractere válido, limpa o ícone de erro e dá o foco no campo "CPF".
        private void TxtNome_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                txtNome.Text.Trim();
            }
            else
            {
                errNome.SetError(txtNome, "");
            }
        }
        private void TxtNome_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtCpf.Focus();
            }
        }

        //Métodos para o campo "CPF" do UserControl "UcAdicionarFuncionario" que ao adicionar algum caractere válido, limpa o ícone de erro e dá o foco no campo "E-Mail".
        private void TxtCpf_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCpf.Text))
            {
                txtCpf.Text.Trim();
            }
            else
            {
                errCpf.SetError(txtCpf, "");
            }
        }
        private void TxtCpf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtEmail.Focus();
            }
        }

        //Métodos para o campo "E-Mail" do UserControl "UcAdicionarFuncionario" que ao adicionar algum caractere válido, limpa o ícone de erro e dá o foco no campo "Telefone".
        private void TxtEmail_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text.Trim();
            }
            else
            {
                errEmail.SetError(txtEmail, "");
            }
        }
        private void TxtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTelefone.Focus();
            }
        }

        //Métodos para o campo "Telefone" do UserControl "UcAdicionarFuncionario" que ao adicionar algum caractere válido, limpa o ícone de erro e dá o foco no campo "Cargo".
        private void TxtTelefone_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTelefone.Text))
            {
                txtTelefone.Text.Trim();
            }
            else
            {
                errTelefone.SetError(txtTelefone, "");
            }
        }
        private void TxtTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmbCargo.Focus();
            }
        }

        //Método que, ao clicar no botão "Cancelar", limpa todos os campos.
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        //Métodos para o campo "CPF" do UserControl "UcAdicionarFuncionario" que movem o cursor do mouse de volta para o inicío do campo. 
        private void TxtCpf_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtCpf.Select(0, 0);
            });
        }
        private void TxtCpf_MouseClick(object sender, MouseEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtCpf.Select(0, 0);
            });
        }

        //Métodos para o campo "Telefone" do UserControl "UcAdicionarFuncionario" que movem o cursor do mouse de volta para o inicío do campo.
        private void TxtTelefone_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtTelefone.Select(0, 0);
            });
        }
        private void TxtTelefone_MouseClick(object sender, MouseEventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                txtTelefone.Select(0, 0);
            });
        }

        //Método de validação para o campo "Nome" que impede a inserção de números no mesmo.
        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Métodos para o campo "Cargo" do UserControl "UcAdicionarFuncionario" que ao selecionar um item, limpa o ícone de erro e dá o foco no campo "Login".
        private void CmbCargo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtLogin.Focus();
            }
        }
        private void CmbCargo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbCargo.SelectedItem != null)
            {
                errCargo.SetError(cmbCargo, "");
                btnAdicionar.Focus();
            }
        }

        //Métodos para o campo "Login" do UserControl "UcAdicionarFuncionario" que ao adicionar algum caractere válido, limpa o ícone de erro e dá o foco no campo "Senha".
        private void TxtLogin_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                txtLogin.Text.Trim();
            }
            else
            {
                errLogin.SetError(txtLogin, "");
            }
        }
        private void TxtLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSenha.Focus();
            }
        }

        //Métodos para o campo "Senha" do UserControl "UcAdicionarFuncionario" que ao adicionar algum caractere válido, limpa o ícone de erro e dá o foco no campo "Confirmar Senha".
        private void TxtSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                txtSenha.Text.Trim();
            }
            else
            {
                errSenha.SetError(txtSenha, "");
            }
        }
        private void TxtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtConfirmSenha.Focus();
            }
        }

        //Métodos para o campo "Confirmar Senha" do UserControl "UcAdicionarFuncionario" que ao adicionar algum caractere válido, limpa o ícone de erro e dá o foco no botão "Adicionar".
        private void TxtConfirmSenha_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtConfirmSenha.Text))
            {
                txtConfirmSenha.Text.Trim();
            }
            else
            {
                errConfirmSenha.SetError(txtConfirmSenha, "");
            }
        }
        private void TxtConfirmSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdicionar.Focus();
            }
        }

        //Método de validação para o campo "E-Mail" que impede o uso da tecla SPACE no mesmo.
        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //Método de validação para o campo "Login" que impede o uso da tecla SPACE no mesmo.
        private void TxtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
