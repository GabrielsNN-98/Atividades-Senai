using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class TelaDependente : Form
    {

        public Form Tela { get; set; }

        public TelaDependente()
        {
            InitializeComponent();
        }

        private void TelaDependente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Tela.Show();
        }

        private void TelaDependente_Load(object sender, EventArgs e)
        {
            dataGridDependentes.DataSource = new Dependente().Select();
        }

        private void dataGridDependentes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
