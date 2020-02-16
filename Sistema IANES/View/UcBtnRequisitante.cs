using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema
{
    public partial class UcBtnRequisitante : UserControl
    {
        public UcBtnRequisitante()
        {
            InitializeComponent();
        }


        //Ao clicar abre o UcAddRequisitante no Panel Principal.
        private void BtnAddEquip_Click(object sender, EventArgs e)
        {
            //Codigo para limpar os UC do PanelTelaPrincipal
            FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.Clear();

            if (!FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.ContainsKey("UcAddRequisitante"))
            {
                UcAddRequisitante uf = new UcAddRequisitante();
                uf.Dock = DockStyle.Fill;
                FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.Add(uf);
            }
            FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls["UcAddRequisitante"].BringToFront();
            FormTelaPrincipal.Instance.BackButton.Visible = true;
        }


        //Ao clicar abre o UcPesquisarRequisitante no Panel Principal.
        private void BtnPesquisarEquip_Click(object sender, EventArgs e)
        {
            if (!FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.ContainsKey("UcPesquisarRequisitante"))
            {
                UcPesquisarRequisitante uf = new UcPesquisarRequisitante();
                uf.Dock = DockStyle.Fill;
                FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.Add(uf);
            }
            FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls["UcPesquisarRequisitante"].BringToFront();
            FormTelaPrincipal.Instance.BackButton.Visible = true;
        }
    }
}
