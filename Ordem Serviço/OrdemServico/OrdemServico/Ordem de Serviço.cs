using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OrdemServico
{
    public partial class Form1 : Form
    {
        int Id { get; set; }
        string Cliente { get; set; }
        string RespTecnico { get; set; }
        string Descricao { get; set; }
        string DiagTecnico { get; set; }
        DateTime Abetura { get; set; }
        DateTime Fechamento { get; set; }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
