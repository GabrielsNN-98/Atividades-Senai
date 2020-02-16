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

namespace Sistema
{
    public partial class UcAddEquipamento : UserControl
    {
        //Usado para o Insert.
        Equipamento equipamentoadd = new Equipamento();


        public UcAddEquipamento()
        {
            InitializeComponent();
        }


        //4 metodos para validar os campos inseridos pelo Funcionario.
        private void CboEquip_Validating()
        {
            if (string.IsNullOrWhiteSpace(cboEquip.Text))
            {
                errTipoEquip.SetError(cboEquip, "Selecione o equipamento");
            }
        }
        private void TxtMarca_Validating()
        {
            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                errMarca.SetError(txtMarca, "Informe a Marca");
            }
        }
        private void TxtSerial_Validating()
        {
            if (string.IsNullOrWhiteSpace(txtSerial.Text))
            {
                errSerial.SetError(txtSerial, "Informe o Serial de Fábrica");
            }
        }
        private void TxtDescricao_Validating()
        {
            if (txtDescricao.Text == "Max 200 carateres...")
            {
                txtDescricao.Text = "";
            }
        }


        //Valida campos VAZIOS ao clicar no botão de Adicionar Equipamento.
        private void BtnAddEquipamento_Click(object sender, EventArgs e)
        {
            if (!cboEquip.Text.Equals("") && !txtMarca.Text.Equals("") && !txtSerial.Text.Equals(""))
            {
                TxtDescricao_Validating();
                equipamentoadd.status = "Disponível";
                equipamentoadd.tipo = cboEquip.Text;
                equipamentoadd.descricao = txtDescricao.Text;
                equipamentoadd.marca = txtMarca.Text;
                equipamentoadd.serialFabrica = txtSerial.Text;

                if (equipamentoadd.Insert())
                {
                    MessageBox.Show(
                    "Equipamento inserido com sucesso.",
                    "",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);            
                }
                Limpar();
            }
            else
            {
                CboEquip_Validating();
                TxtMarca_Validating();
                TxtSerial_Validating();
            }
        }


        //Metodo para LIMPAR todos os Text,Combo Box e Error Provider.
        private void Limpar()
        {
            cboEquip.SelectedIndex = -1;
            errTipoEquip.SetError(cboEquip, "");

            txtDescricao.Clear();
            txtDescricao.Text = "Max 200 carateres...";
            txtDescricao.ForeColor = Color.DarkGray;

            txtMarca.Clear();
            errMarca.SetError(txtMarca, "");

            txtSerial.Clear();
            errSerial.SetError(txtSerial, "");
        }


        //Codigo para o ComboBox Equipamento, selecionar uma opcao != null ou apertar Enter da foco em outro campo.
        private void CboEquip_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboEquip.SelectedItem != null)
            {
                errTipoEquip.SetError(cboEquip, "");
                txtDescricao.Focus();
            }
        }
        private void CboEquip_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDescricao.Focus();
            }
        }


        //Codigo para o txt Descricao, digitar algo faz desaparecer o placeholder.
        //Apertar Enter da foco em outro campo.
        private void TxtDescricao_Enter(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "Max 200 carateres...")
            {
                txtDescricao.Text = null;
                txtDescricao.ForeColor = Color.Black;
            }
        }
        private void TxtDescricao_Leave(object sender, EventArgs e)
        {
            if (txtDescricao.Text == "")
            {
                txtDescricao.Text = "Max 200 carateres...";
                txtDescricao.ForeColor = Color.DarkGray;
            }
        }
        private void TxtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMarca.Focus();
            }
        }


        //Codigo para o txt Marca, digitar algo != null ou apertar Enter da foco em outro campo.
        private void txtMarca_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                txtMarca.Text.Trim();
            }
            else
            {
                errMarca.SetError(txtMarca, "");
            }
        }
        private void TxtMarca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSerial.Focus();
            }
        }


        //Codigo para o txt Serial, digitar algo != null ou apertar Enter da foco em outro campo.
        private void txtSerial_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSerial.Text))
            {
                txtSerial.Text.Trim();
            }
            else
            {
                errSerial.SetError(txtSerial, "");
            }
        }
        private void TxtSerial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAddEquipamento.Focus();
            }
        }
    }
}
