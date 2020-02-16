using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Model;

namespace Sistema
{
    public partial class EditarEquipamento : Form
    {
        //Usado para o Update.
        Equipamento equipamentouppd = new Equipamento();

        public EditarEquipamento()
        {
            InitializeComponent();
        }


        //Fecha o FormEditar e volta para o UCcontrolPesquisarEquip
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Abre uma conexão com o BD para pegar valor de marca,descricao e Nº de série;
        private void SelecionarConexaoAdd()
        {
            btnVoltar.Focus();

            String source = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=Ianes;Integrated Security=True";
            SqlConnection con = new SqlConnection(source);
            con.Open();

            String sqlSelectQuery = "SELECT * FROM equipamento WHERE Id=" + int.Parse(txtId.Text);
            SqlCommand cmd = new SqlCommand(sqlSelectQuery, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtMarca.Text = (dr["marca"].ToString());
                txtNumeroSerie.Text = (dr["serialFabrica"].ToString());
                txtDescricao.Text = (dr["descricao"].ToString());
            }
            con.Close();
        }


        //Evento para chamar o select do banco de dados
        private void EditarEquipamento_Load(object sender, EventArgs e)
        {
            SelecionarConexaoAdd();
        }


        //Validate para marca e NºSerial para mostrar o error provider na tela.
        private void MarcaMudar_Validating()
        {
            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                errMarcaMudar.SetError(txtMarca, "Campo inserido vazio");
            }
        }
        private void NSerialMudar_Validating()
        {
            if (string.IsNullOrWhiteSpace(txtNumeroSerie.Text))
            {
                errNSerialMudar.SetError(txtNumeroSerie, "Campo inserido vazio");
            }
        }


        //Abre uma conexão com o BD para pegar valor de marca,descricao e Nº de série.
        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            if (!txtMarca.Text.Trim().Equals("") && !txtNumeroSerie.Text.Trim().Equals(""))
            {
                equipamentouppd.Id              = int.Parse(txtId.Text);
                equipamentouppd.tipo            = cboTipoEquip.Text;
                equipamentouppd.marca           = txtMarca.Text;
                equipamentouppd.serialFabrica   = txtNumeroSerie.Text;
                equipamentouppd.descricao       = txtDescricao.Text;

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

                MarcaMudar_Validating();
                NSerialMudar_Validating();
                SelecionarConexaoAdd();
            }
        }


        //Codigo para o cbo TipoEquip,digitar algo != null ou apertar Enter da foco no btnSalvar.
        private void CboTipoEquip_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cboTipoEquip.SelectedItem != null)
            {
                errCboTipoMudar.SetError(cboTipoEquip, "");
                txtMarca.Focus();
            }
        }
        private void CboTipoEquip_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtMarca.Focus();
            }
        }


        //Codigo para o txt Marca, digitar algo != null ou apertar Enter da foco em outro campo.
        private void TxtMarca_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                txtMarca.Text.Trim();
            }
            else
            {
                errMarcaMudar.SetError(txtMarca, "");
            }
        }
        private void TxtMarca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNumeroSerie.Focus();
            }
        }


        //Codigo para o txt NºSerie, digitar algo != null ou apertar Enter da foco em outro campo.
        private void TxtNumeroSerie_KeyUp(object sender, KeyEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNumeroSerie.Text))
            {
                txtNumeroSerie.Text.Trim();
            }
            else
            {
                errNSerialMudar.SetError(txtNumeroSerie, "");
            }
        }
        private void TxtNumeroSerie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDescricao.Focus();
            }
        }


        //Codigo para o txt Descricao,apertar Enter da foco no btnSalvar.
        private void TxtDescricao_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSalvar.Focus();
            }
        }
    }
}
