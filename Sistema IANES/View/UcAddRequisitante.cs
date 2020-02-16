using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using System.Net.Mail;

namespace Sistema
{
    public partial class UcAddRequisitante : UserControl
    {
        //Usado para o Insert.
        Requisitante requisitanteadd = new Requisitante();

        public UcAddRequisitante()
        {
            InitializeComponent();
        }


        //Metodo para limpar todos os txt,cbo e error provider da tela.
        private void Limpar()
        {   
            txtNome.Clear();
            errNome.SetError(txtNome, "");

            txtEmail.Clear();
            errEmail.SetError(txtEmail, "");

            maskTBTelefone.Clear();
            errTelefone.SetError(maskTBTelefone, "");

            cboCargo.SelectedIndex = -1;
            errCargo.SetError(cboCargo, "");
        }


        //Btn voltar chama o metodo Limpar().
        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }


        //4 metodos para validar os campos inseridos pelo requisitante, error provider.
        private void TxtNome_Validating()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                errNome.SetError(txtNome, "Informe o Nome");
            }
        }
        private void TxtEmail_Validating()
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                errEmail.SetError(txtEmail, "Informe um E-mail Valido");
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
                errEmail.SetError(txtEmail, "Favor inserir um email válido!!");
                return false;
            }
        }
        private void MaskTelefone_Validating()
        {
            if (!maskTBTelefone.MaskCompleted)
            {
                errTelefone.SetError(maskTBTelefone, "Informe o Telefone");
            }
        }
        private void CboCargo_Validating()
        {
            if (string.IsNullOrWhiteSpace(cboCargo.Text))
            {
                errCargo.SetError(cboCargo, "Selecione um Cargo");
            }
        }


        //Método que, ao verificar que todos os campos NÃO estão vazios, chama o método INSERT da classe requisitante.
        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            if (!txtNome.Text.Equals("") && !txtEmail.Text.Equals("") &&
                IsEmailValid(txtEmail.Text) && maskTBTelefone.MaskCompleted &&
                !cboCargo.Text.Equals(""))
            {
                requisitanteadd.nome = txtNome.Text;
                requisitanteadd.email = txtEmail.Text;
                requisitanteadd.telefone = maskTBTelefone.Text;
                requisitanteadd.tipo = cboCargo.Text;

                if (requisitanteadd.Insert())
                {
                    MessageBox.Show(
                    "Requisitante inserido com sucesso.",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                Limpar();
            }
            else
            {
                TxtNome_Validating();
                TxtEmail_Validating();
                MaskTelefone_Validating();
                CboCargo_Validating();
            }
        }


        //Codigo para o txt Nome, digitar algo != null ou apertar Enter da foco em outro campo.
        //Evento KeyPress para proibir numeros no campo de txtnome.
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
                txtEmail.Focus();
            }
        }
        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        //Codigo para o txt Email, digitar algo != null ou apertar Enter da foco em outro campo.
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
                maskTBTelefone.Focus();
            }
        }
        private void TxtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == ' ';
        }

        //Codigo para o mask Telefone, digitar algo != null ou apertar Enter da foco em outro campo.
        //Evento KeyPress para proibir letras no campo de telefone.
        private void MaskTBTelefone_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(maskTBTelefone.Text))
            {
                maskTBTelefone.Text.Trim();
            }
            else
            {
                errTelefone.SetError(maskTBTelefone, "");
            }
        }
        private void MaskTBTelefone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cboCargo.Focus();
            }
        }
        private void MaskTBTelefone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar == ' ';
        }
        private void MaskTBTelefone_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                maskTBTelefone.Select(0, 0);
            });
        }


        //Codigo para o cbo Cargo, selecionar uma opcao != null ou apertar Enter da foco em outro campo.
        private void CboCargo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboCargo.SelectedItem != null)
            {
                errCargo.SetError(cboCargo, "");
                cboCargo.Focus();
            }
        }
        private void CboCargo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdicionar.Focus();
            }
        }
    }
}
