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
using Model;

namespace Sistema
{
    public partial class EditarRequisitante : Form
    {
        //Usado para o Update.
        Requisitante equipamentouppd = new Requisitante();

        public EditarRequisitante()
        {
            InitializeComponent();
        }
       
        //Fecha o FormEditar e volta para o UCPesquisarRequisitante
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Abre uma conexão com o BD para pegar valor do email,telefone e cargo do requisitante;
        private void SelecionarConexaoAdd()
        {
            btnVoltar.Focus();

            String source = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Ianes;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();

            String sqlSelectQuery = "SELECT * FROM requisitante WHERE Id=" + int.Parse(txtId.Text);
            SqlCommand cmd = new SqlCommand(sqlSelectQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtNome.Text = (dr["Nome"].ToString());
                txtEmail.Text = (dr["Email"].ToString());
                cboCargo.Text = (dr["tipo"].ToString());
                maskTBTelefone.Text = (dr["telefone"].ToString());
            }
            con.Close();
        }


        //Evento para chamar o select do banco de dados
        private void EditarRequisitante_Load(object sender, EventArgs e)
        {
            SelecionarConexaoAdd();
        }


        //Validate para cargo,nome,email e telefone para mostrar o error provider na tela.
        private void CboCargo_Validating()
        {
            if (string.IsNullOrWhiteSpace(cboCargo.Text))
            {
                errCargo.SetError(cboCargo, "Selecione um Cargo");
            }
        }
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
        private void MaskTBTelefone_Validating()
        {
            if (!maskTBTelefone.MaskCompleted)
            {
                errTelefone.SetError(maskTBTelefone, "Informe o Telefone");
            }
        }


        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!txtNome.Text.Trim().Equals("") && !txtEmail.Text.Trim().Equals("")
                && maskTBTelefone.MaskCompleted)
            {
                equipamentouppd.Id = int.Parse(txtId.Text);
                equipamentouppd.nome = txtNome.Text;
                equipamentouppd.email = txtEmail.Text;
                equipamentouppd.telefone = maskTBTelefone.Text;
                equipamentouppd.tipo = cboCargo.Text;

                if (equipamentouppd.Update())
                {
                    MessageBox.Show(
                        "Modificação feita com Sucesso!!!",
                        "",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "Falha ao atualizar dados!!!",
                        "AVISO",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show(
                   string.Format(
                       "Verifique os dados Inseridos!!!"),
                  "",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Hand);

                CboCargo_Validating();
                TxtNome_Validating();
                TxtEmail_Validating();
                MaskTBTelefone_Validating();

                SelecionarConexaoAdd();
            }
        }


        //Codigo para o cbo Cargo,digitar algo != null ou apertar Enter da foco no proximo txt.
        private void CboCargo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboCargo.SelectedItem != null)
            {
                errCargo.SetError(cboCargo, "");
                txtNome.Focus();
            }
        }
        private void CboCargo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNome.Focus();
            }
        }


        //Codigo para o txt Nome,digitar algo != null ou apertar Enter da foco no proximo txt.
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


        //Codigo para o txt Email,digitar algo != null ou apertar Enter da foco no proximo txt.
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


        //Codigo para o telefone,digitar algo != null ou apertar Enter da foco no proximo txt.
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
    }
}
