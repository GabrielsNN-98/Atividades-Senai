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

namespace Sistema
{
    public partial class FormTelaPrincipal : Form
    {
        Emprestimo EmprestimoConexao = new Emprestimo();

        static FormTelaPrincipal _obj;

        public FormTelaPrincipal()
        {
            InitializeComponent();
        }


        //Método que instancia o forms "TelaPrincipal".
        public static FormTelaPrincipal Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new FormTelaPrincipal();
                }
                return _obj;
            }
        }


        //Método que contém um panel para o UserControl "UcImgTelaPrincipal" com a imagem "Faculdade IANES".
        public Panel PanelTelaPrincipal
        {
            get { return PnlTelaPrincipal; }
            set { PnlTelaPrincipal = value; }
        }


        /*Método que contém um panel para o UserControl "UcBtnTelaPrincipal" com os botões "Gerenciar Funcionário", "Gerenciar Requisitante", 
        "Gerenciar Equipamento" e "Gerenciar Empréstimo".*/
        public Panel PanelBtnTelaPrincipal
        {
            get { return PnlBtnTelaPrincipal; }
            set { PnlBtnTelaPrincipal = value; }
        }


        //Método que contém o botão "Voltar".
        public Button BackButton
        {
            get { return btnVoltar; }
            set { btnVoltar = value; }
        }


        //Método que chama os UserControls "UcImgTelaPrincipal" e "UcBtnTelaPrincipal" e exibe-os no forms "TelaPrincipal".
        private void FormTelaPrincipal_Load(object sender, EventArgs e)
        {
            btnVoltar.Visible = false;
            _obj = this;


            //Atualiza a lista de status de entrega dos emprestimos feitos que estao pendentes e nao forma entregues no tempo (atrasado)
            EmprestimoConexao.Updatestatusatraso();


            UcBtnTelaPrincipal Uc1 = new UcBtnTelaPrincipal
            {
                Dock = DockStyle.Fill
            };
            PnlBtnTelaPrincipal.Controls.Add(Uc1);



            UcImgTelaPrincipal Uc2 = new UcImgTelaPrincipal
            {
                Dock = DockStyle.Fill
            };
            PnlTelaPrincipal.Controls.Add(Uc2);
        }


        //Método para o botão "Voltar" que retorna as telas anteriores quando clicado.
        private void BtnVoltar_Click(object sender, EventArgs e)
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


            if (!FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.ContainsKey("UcBtnTelaPrincipal"))
            {
                UcBtnTelaPrincipal uf = new UcBtnTelaPrincipal
                {
                    Dock = DockStyle.Fill
                };
                FormTelaPrincipal.Instance.PanelTelaPrincipal.Controls.Add(uf);
            }
            FormTelaPrincipal.Instance.PnlBtnTelaPrincipal.Controls["UcBtnTelaPrincipal"].BringToFront();


            btnVoltar.Visible = false;
        }
    }
}