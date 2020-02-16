using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmVeterinaria
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogar_Click(object sender, EventArgs e)
        {
            if (txtLogin.Text.Equals("Thor"))
            {
                if (int.Parse(txtSenha.Text) == 12345)
                {
                    FrmSecretario objSecretario = new FrmSecretario();
                    objSecretario.Show();

                }
            }else if (txtLogin.Text.Equals("Hela"))
            {
                if (int.Parse(txtSenha.Text) == 54321)
                {
                    FrmVeterinaria objVeterinaria = new FrmVeterinaria();
                    objVeterinaria.Show();
                }
            }

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txtLogin.Text, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                MessageBox.Show(txtSenha.Text, "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtLogin_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtLogin.Text))
            {
                e.Cancel = true;
                txtLogin.Focus();
                epLogin.SetError(txtLogin, "Por favor insira um nome de usuário !");
            }
            else
            {
                e.Cancel = true;
                epLogin.SetError(txtLogin, null);
            }
        }

        private void txtSenha_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                e.Cancel = true;
                txtSenha.Focus();
                epSenha.SetError(txtSenha, "Por favor insira uma senha !");
            }
            else
            {
                e.Cancel = true;
                epSenha.SetError(txtSenha, null);
            }

        }

        private void btnSair_Click(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
            Close();
        }
    }
}
