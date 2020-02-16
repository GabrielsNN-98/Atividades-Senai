using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace View
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void sociosMenuItem_Click(object sender, EventArgs e)
        {
            /*Instanciar a classe passando valores, tem duas formas:
            1ª Construtor -> ( )
            2ª Set -> { }*/
            new TelaSocios
            {
                Tela = this
            }.Show();

            this.Hide();
        }

        private void DependentesMenuItem_Click(object sender, EventArgs e)
        {
            new TelaDependente
            {
                Tela = this
            }.Show();

            this.Hide();
        }
    }
}
