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
    public partial class TelaSocios : Form
    {
        //Atributo -> Propriedades
        public Form Tela { get; set; }

        public TelaSocios()
        {
            InitializeComponent();
        }

        private void TelaSocios_FormClosing(object sender, FormClosingEventArgs e)
        {
            Tela.Show();
        }

        private void TelaSocios_Load(object sender, EventArgs e)
        {
            this.listarSocios();
        }

        private void listarSocios()
        {
            dataGridSocios.DataSource = new Socio().Select();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            /*ErrorProvider*/
            if (!txtNome.Text.Equals(""))
            {
                if (!txtCpf.Text.Equals(""))
                {
                    Socio socio = new Socio();

                    socio.Nome = txtNome.Text;
                    socio.Cpf = txtCpf.Text;

                    if (socio.Insert())
                    {
                        MessageBox.Show(
                            "Registro inserido com sucesso",
                            "AVISO",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );

                        this.listarSocios();

                        txtNome.Clear();
                        txtCpf.Clear();

                        txtNome.Focus();
                    }
                    else
                    {
                        MessageBox.Show(
                            "Falha ao inserir o registro",
                            "AVISO",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }
                }
                else
                {
                    MessageBox.Show(
                        "Favor digitar o campo CPF",
                        "AVISO",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Hand
                    );

                    txtCpf.Focus();
                }
            }
            else
            {
                MessageBox.Show(
                    "Favor digitar o campo Nome",
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Hand
                );

                txtNome.Focus();
            }
        }

        private void dataGridSocios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridSocios.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dataGridSocios.CurrentRow.Cells[1].Value.ToString();
            txtCpf.Text = dataGridSocios.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (!txtId.Text.Equals(""))
            {
                if (!txtNome.Text.Equals(""))
                {
                    if (!txtCpf.Text.Equals(""))
                    {
                        Socio socio = new Socio();

                        socio.Id = int.Parse(txtId.Text);
                        socio.Nome = txtNome.Text;
                        socio.Cpf = txtCpf.Text;

                        if (socio.Update())
                        {
                            MessageBox.Show(
                                "Registro atualizado com sucesso",
                                "AVISO",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );

                            this.listarSocios();

                            txtId.Clear();
                            txtNome.Clear();
                            txtCpf.Clear();

                            txtNome.Focus();

                        }
                        else
                        {
                            MessageBox.Show(
                                "Falha ao atualizar o registro",
                                "AVISO",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information
                            );
                        }
                    }
                    else
                    {
                        MessageBox.Show(
                            string.Format(
                                "Por favor preencha o campo Nome !!"
                            ),
                            "AVISO",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Hand
                        );

                        txtCpf.Focus();
                    }
                }
                else
                {
                    MessageBox.Show(
                        string.Format(
                            "Por favor preencha o campo Nome !!"
                        ),
                        "AVISO",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Hand
                    );

                    txtNome.Focus();
                }
            }
            else
            {
                MessageBox.Show(
                    string.Format(
                        "Por favor selecione um registro !!"
                    ),
                    "AVISO",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Hand
                );
            }
        }
    }
}
