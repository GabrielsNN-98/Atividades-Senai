using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_07_05
{
    public partial class FrmHamburguer : Form
    {
        public FrmHamburguer()
        {
            InitializeComponent();
            rBtnOutros.Checked = true;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            String estado = "";

            if (CmbEstado.SelectedIndex != -1)
            {
                estado = CmbEstado.SelectedItem.ToString();
            }
            
            int iEstado = CmbEstado.SelectedIndex;

            String conheceu = "";

            List<String> listNewsletter = new List<String>();

            if (rBtnFacebook.Checked)
            {
                conheceu = rBtnFacebook.Text;
            }
            else if (rBtnJornal.Checked)
            {
                conheceu = rBtnJornal.Text;

            }else if(rBtnOutros.Checked)
            {
                conheceu = rBtnOutros.Text;
            }
            else if (rBtnTV.Checked)
            {
                conheceu = rBtnTV.Text;
            }
            else
            {
                MessageBox.Show("conheceu: Marque uma opção");
            }

            if (ChbEmail.Checked)
            {
                listNewsletter.Add(ChbEmail.Text);
            }
            if (ChbLigacao.Checked)
            {
                listNewsletter.Add(ChbLigacao.Text);
            }
            if (ChbSMS.Checked)
            {
                listNewsletter.Add(ChbSMS.Text);
            }

            foreach (String nome in listNewsletter)
            {
                MessageBox.Show("newsletter: " + nome);
            }
            MessageBox.Show("index: " + iEstado +", estado"+ estado);
            MessageBox.Show("conheceu: " + conheceu);
        }
    }
}
