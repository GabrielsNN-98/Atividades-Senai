using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sistema.Model;
using Sistema.Entidades;

namespace Sistema.View
{
    public partial class frmCadUsuario : Form
    {
        public frmCadUsuario()
        {
            InitializeComponent();
        }

        UsuarioEnt objTabela = new UsuarioEnt();

        //Método para realizar as ações proposta em novo
        private void btnNovo_Click(object sender, EventArgs e)
        {
            opc = "Novo";
            //Convocando método
            iniciarOpc();
        }

        //Criando atributo 
        private string opc = "";

        //Método para realizar as ações propostas na tela
        private void iniciarOpc()
        {
            switch (opc)
            {
                case "Novo":
                    {
                        HabilitarCampos();
                        LimparCampos();
                        break;
                    }

                case "Salvar":
                    {
                        try
                        {
                            objTabela.Nome = txtNome.Text;
                            objTabela.Usuario = txtUsuario.Text;
                            objTabela.Senha = txtSenha.Text;

                            //int x = UsuarioModel.Inserir(objTabela);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Occoreu um erro");
                            throw;
                        }
                        break;
                    }


                case "Excluir":
                    {
                        break;
                    }

                case "Editar":
                    {
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
        }

        //Métopdo para habilitar os campos
        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtUsuario.Enabled = true;
            txtSenha.Enabled = true;
        }

        //Método para deixar o campo vazio
        private void LimparCampos()
        {
            txtNome.Text = "";
            txtSenha.Text = "";
            txtUsuario.Text = "";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            opc = "Salvar";
            //Convocando método
            iniciarOpc();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            opc = "Excluir";
            //Convocando método
            iniciarOpc();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            opc = "Editar";
            //Convocando método
            iniciarOpc();
        }
    }
}

