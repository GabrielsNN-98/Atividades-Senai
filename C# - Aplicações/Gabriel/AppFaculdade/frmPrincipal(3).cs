using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFaculdade
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAluno_MouseClick(object sender, MouseEventArgs e)
        {
            FrmAluno frmAluno = new FrmAluno();
            frmAluno.Show();
        }

        private void BtnProfessor_MouseClick(object sender, MouseEventArgs e)
        {
            FrmProfessor frmProfessor = new FrmProfessor();
            frmProfessor.Show();
        }

        private void BtnDisciplina_MouseClick(object sender, MouseEventArgs e)
        {
            FrmDisciplina frmDisciplina = new FrmDisciplina();
            frmDisciplina.Show();
        }

        private void alunoToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            FrmAluno frmAluno = new FrmAluno();
            frmAluno.Show();
        }

        private void professorToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            FrmProfessor frmProfessor = new FrmProfessor();
            frmProfessor.Show();
        }

        private void disciplinaToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            FrmDisciplina frmDisciplina = new FrmDisciplina();
            frmDisciplina.Show();
        }

        private void sairToolStripMenuItem_DoubleClick(object sender, EventArgs e)
        {
            Close();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAluno frmAluno = new FrmAluno();
            frmAluno.Show();
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProfessor frmProfessor = new FrmProfessor();
            frmProfessor.Show();
        }

        private void disciplinaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDisciplina frmDisciplina = new FrmDisciplina();
            frmDisciplina.Show();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
