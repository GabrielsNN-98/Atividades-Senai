using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;


namespace Sistema
{
    public partial class UcBtnEmprestimo : UserControl
    {
        Emprestimo EmprestimoConexao = new Emprestimo();

        public UcBtnEmprestimo()
        {
            InitializeComponent();
        }


        private void btnAddEmprestimo_Click(object sender, EventArgs e)
        {
            //Atualiza a lista de status de entrega dos emprestimos feitos que estao pendentes e nao forma entregues no tempo (atrasado)
            EmprestimoConexao.Updatestatusatraso();

            //Codigo para limpar os UC do PanelTelaPrincipal
            FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.Clear();

            if (!FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.ContainsKey("UCAddEmprestimo"))
            {
                UCAddEmprestimo uf = new UCAddEmprestimo();
                uf.Dock = DockStyle.Fill;
                FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.Add(uf);
            }
            FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls["UCAddEmprestimo"].BringToFront();
            FormTelaPrincipal.Instance.BackButton.Visible = true;
        }


        private void BtnEmprestimosFeitos_Click(object sender, EventArgs e)
        {
            //Atualiza a lista de status de entrega dos emprestimos feitos que estao pendentes e nao forma entregues no tempo (atrasado)
            EmprestimoConexao.Updatestatusatraso();

            //Codigo para limpar os UC do PanelTelaPrincipal
            FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.Clear();

            if (!FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.ContainsKey("UCEmpretimoFeito"))
            {
                UCPesquisarEmpretimoFeito uf = new UCPesquisarEmpretimoFeito();
                uf.Dock = DockStyle.Fill;
                FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.Add(uf);
            }
            FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls["UCEmpretimoFeito"].BringToFront();
            FormTelaPrincipal.Instance.BackButton.Visible = true;
        }


        private void BtnDevolucao_Click(object sender, EventArgs e)
        {
            //Atualiza a lista de status de entrega dos emprestimos feitos que estao pendentes e nao forma entregues no tempo (atrasado)
            EmprestimoConexao.Updatestatusatraso();

            //Codigo para limpar os UC do PanelTelaPrincipal
            FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.Clear();

            if (!FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.ContainsKey("UCDevolucao"))
            {
                UCDevolucao uf = new UCDevolucao();
                uf.Dock = DockStyle.Fill;
                FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.Add(uf);
            }
            FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls["UCDevolucao"].BringToFront();
            FormTelaPrincipal.Instance.BackButton.Visible = true;
        }
    }
}
