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
    public partial class UcBtnFuncionario : UserControl
    {
        public UcBtnFuncionario()
        {
            InitializeComponent();
        }

        //Método do botão "Adicionar Funcionário" que exibe o UserControl "UcAdicionarFuncionario".
        private void BtnAdicionarFuncionario_Click(object sender, EventArgs e)
        {
            FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.Clear();
            if (!FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.ContainsKey("UcAdicionarFuncionario"))
            {
                UcAddFuncionario uf = new UcAddFuncionario
                {
                    Dock = DockStyle.Fill
                };
                FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.Add(uf);
            }
            FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls["UcAdicionarFuncionario"].BringToFront();
            FormTelaPrincipal.Instance.BackButton.Visible = true;
        }

        //Método do botão "Pesquisar Funcionário" que exibe o UserControl "UcPesquisarFuncionario".
        private void BtnPesquisarFuncionario_Click(object sender, EventArgs e)
        {
            if (!FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.ContainsKey("UcPesquisarFuncionario"))
            {
                UcPesquisarFuncionario uf = new UcPesquisarFuncionario
                {
                    Dock = DockStyle.Fill
                };
                FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.Add(uf);
            }
            FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls["UcPesquisarFuncionario"].BringToFront();
            FormTelaPrincipal.Instance.BackButton.Visible = true;
        }
    }
}
