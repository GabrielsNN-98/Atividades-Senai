using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmMatricula
{
    public partial class FrmMatricula : Form
    {
        AlunoEM aluno;
        String resultado;
        float media;

        public FrmMatricula()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnCalcular_MouseClick(object sender, MouseEventArgs e)
        {
            int matricula = Convert.ToInt32(txtMatricula.Text);
            String nome = txtNome.Text;

            aluno = new AlunoEM(matricula, nome);

            aluno.Nota1 = Convert.ToInt32(txtNota1.Text);
            aluno.Nota2 = Convert.ToInt32(txtNota2.Text);
            aluno.Nota3 = Convert.ToInt32(txtNota3.Text);
            aluno.Nota4 = Convert.ToInt32(txtNota4.Text);

            media = aluno.calcularMedia();

            resultado = aluno.statusAluno(media);
            lblResultado.Text = resultado;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtMatricula.Text = "";
            txtNome.Text = "";
            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtNota4.Text = "";
            lblResultado.Text = "";

        }

        private void btnSair_MouseClick(object sender, MouseEventArgs e)
        {
            Close();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

        }
    }
}
