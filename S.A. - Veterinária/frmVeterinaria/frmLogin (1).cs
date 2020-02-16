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
        }
    }
}
