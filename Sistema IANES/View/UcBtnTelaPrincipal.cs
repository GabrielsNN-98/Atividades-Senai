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
    public partial class UcBtnTelaPrincipal : UserControl
    {
        public UcBtnTelaPrincipal()
        {
            InitializeComponent();
        }

        //Método do botão "Gerenciar Funcionário" que exibe o UserControl "UcBtnFuncionario". 
        private void BtnFuncionario_Click(object sender, EventArgs e)
        {
            if (!FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.ContainsKey("UcImgTelaPrincipal"))
            {
                UcBtnFuncionario uf = new UcBtnFuncionario
                {
                    Dock = DockStyle.Fill
                };
                FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.Add(uf);
            }
            FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls["UcImgTelaPrincipal"].BringToFront();
            FormTelaPrincipal.Instance.BackButton.Visible = true;


            if (!FormTelaPrincipal.Instance.PanelBtnTelaPrincipal.Controls.ContainsKey("UcBtnFuncionario"))
            {
                UcBtnFuncionario uf1 = new UcBtnFuncionario
                {
                    Dock = DockStyle.Fill
                };
                FormTelaPrincipal.Instance.PanelBtnTelaPrincipal.Controls.Add(uf1);
            }
            FormTelaPrincipal.Instance.PanelBtnTelaPrincipal.Controls["UcBtnFuncionario"].BringToFront();
            FormTelaPrincipal.Instance.BackButton.Visible = true;
        }

        //Método do botão "Gerenciar Requisitante" que exibe o UserControl "UcBtnRequisitante".
        private void BtnRequisitante_Click(object sender, EventArgs e)
        {
            if (!FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.ContainsKey("UcImgTelaPrincipal"))
            {
                UcImgTelaPrincipal uf = new UcImgTelaPrincipal
                {
                    Dock = DockStyle.Fill
                };
                FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.Add(uf);
            }
            FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls["UcImgTelaPrincipal"].BringToFront();
            FormTelaPrincipal.Instance.BackButton.Visible = true;


            if (!FormTelaPrincipal.Instance.PanelBtnTelaPrincipal.Controls.ContainsKey("UcBtnRequisitante"))
            {
                UcBtnRequisitante uf1 = new UcBtnRequisitante
                {
                    Dock = DockStyle.Fill
                };
                FormTelaPrincipal.Instance.PanelBtnTelaPrincipal.Controls.Add(uf1);
            }
            FormTelaPrincipal.Instance.PanelBtnTelaPrincipal.Controls["UcBtnRequisitante"].BringToFront();
            FormTelaPrincipal.Instance.BackButton.Visible = true;
        }

        //Método do botão "Gerenciar Equipamento" que exibe o UserControl "UcBtnEquipamento".
        private void BtnEquipamento_Click(object sender, EventArgs e)
        {
            if (!FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.ContainsKey("UcImgTelaPrincipal"))
            {
                UcImgTelaPrincipal uf = new UcImgTelaPrincipal
                {
                    Dock = DockStyle.Fill
                };
                FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.Add(uf);
            }
            FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls["UcImgTelaPrincipal"].BringToFront();
            FormTelaPrincipal.Instance.BackButton.Visible = true;


            if (!FormTelaPrincipal.Instance.PanelBtnTelaPrincipal.Controls.ContainsKey("UcBtnEquipamento"))
            {
                UcBtnEquipamento uf1 = new UcBtnEquipamento
                {
                    Dock = DockStyle.Fill
                };
                FormTelaPrincipal.Instance.PanelBtnTelaPrincipal.Controls.Add(uf1);
            }
            FormTelaPrincipal.Instance.PanelBtnTelaPrincipal.Controls["UcBtnEquipamento"].BringToFront();
            FormTelaPrincipal.Instance.BackButton.Visible = true;
        }

        //Método do botão "Gerenciar Empréstimo" que exibe o UserControl "UcBtnEmprestimo".
        private void BtnEmprestimo_Click(object sender, EventArgs e)
        {
            if (!FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.ContainsKey("UcImgTelaPrincipal"))
            {
                UcImgTelaPrincipal uf = new UcImgTelaPrincipal
                {
                    Dock = DockStyle.Fill
                };
                FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.Add(uf);
            }
            FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls["UcImgTelaPrincipal"].BringToFront();
            FormTelaPrincipal.Instance.BackButton.Visible = true;


            if (!FormTelaPrincipal.Instance.PanelBtnTelaPrincipal.Controls.ContainsKey("UcBtnEmprestimo"))
            {
                UcBtnEmprestimo uf1 = new UcBtnEmprestimo
                {
                    Dock = DockStyle.Fill
                };
                FormTelaPrincipal.Instance.PanelBtnTelaPrincipal.Controls.Add(uf1);
            }
            FormTelaPrincipal.Instance.PanelBtnTelaPrincipal.Controls["UcBtnEmprestimo"].BringToFront();
            FormTelaPrincipal.Instance.BackButton.Visible = true;
        }
    }
}
