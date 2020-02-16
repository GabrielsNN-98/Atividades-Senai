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
    public partial class FrmVeterinaria : Form
    {
        public FrmVeterinaria()
        {
            InitializeComponent();
        }

        private void btnMarcarConsulta_Click(object sender, EventArgs e)
        {
            FrmConsulta objConsulta = new FrmConsulta();
            objConsulta.Show();
        }
    }
}
