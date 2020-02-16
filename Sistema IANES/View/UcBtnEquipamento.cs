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
    public partial class UcBtnEquipamento : UserControl
    {
        public UcBtnEquipamento()
        {
            InitializeComponent();
        }

        //Ao clicar abre o UC Equipamento no Panel Principal
        private void BtnAddEquip_Click(object sender, EventArgs e)
        {
            //Codigo para limpar os UC do PanelTelaPrincipal
            FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.Clear();

            if (!FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.ContainsKey("UcAddEquipamento"))
            {
                UcAddEquipamento uf = new UcAddEquipamento();
                uf.Dock = DockStyle.Fill;
                FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.Add(uf);
            }
            FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls["UcAddEquipamento"].BringToFront();
            FormTelaPrincipal.Instance.BackButton.Visible = true;
        }


        //Ao clicar abre o UC Pesquisar Equipamentos no Panel Principal
        private void BtnPesquisarEquip_Click(object sender, EventArgs e)
        {
            if (!FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.ContainsKey("UcPesquisarEquipamento"))
            {
                UcPesquisarEquipamento uf = new UcPesquisarEquipamento();
                uf.Dock = DockStyle.Fill;
                FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.Add(uf);
            }
            FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls["UcPesquisarEquipamento"].BringToFront();
            FormTelaPrincipal.Instance.BackButton.Visible = true;
        }
    }
}
