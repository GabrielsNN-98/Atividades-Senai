namespace AppFaculdade
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alunoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.professorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disciplinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnProfessor = new System.Windows.Forms.Button();
            this.BtnDisciplina = new System.Windows.Forms.Button();
            this.BtnAluno = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(240, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alunoToolStripMenuItem,
            this.professorToolStripMenuItem,
            this.disciplinaToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // alunoToolStripMenuItem
            // 
            this.alunoToolStripMenuItem.Name = "alunoToolStripMenuItem";
            this.alunoToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.alunoToolStripMenuItem.Text = "Aluno";
            this.alunoToolStripMenuItem.Click += new System.EventHandler(this.alunoToolStripMenuItem_Click);
            // 
            // professorToolStripMenuItem
            // 
            this.professorToolStripMenuItem.Name = "professorToolStripMenuItem";
            this.professorToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.professorToolStripMenuItem.Text = "Professor";
            this.professorToolStripMenuItem.Click += new System.EventHandler(this.professorToolStripMenuItem_Click);
            // 
            // disciplinaToolStripMenuItem
            // 
            this.disciplinaToolStripMenuItem.Name = "disciplinaToolStripMenuItem";
            this.disciplinaToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.disciplinaToolStripMenuItem.Text = "Disciplina";
            this.disciplinaToolStripMenuItem.Click += new System.EventHandler(this.disciplinaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // BtnProfessor
            // 
            this.BtnProfessor.Image = global::AppFaculdade.Properties.Resources.icons8_sala_de_aula_48;
            this.BtnProfessor.Location = new System.Drawing.Point(55, 108);
            this.BtnProfessor.Name = "BtnProfessor";
            this.BtnProfessor.Size = new System.Drawing.Size(133, 52);
            this.BtnProfessor.TabIndex = 2;
            this.BtnProfessor.Text = "Professor";
            this.BtnProfessor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnProfessor.UseVisualStyleBackColor = true;
            this.BtnProfessor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnProfessor_MouseClick);
            // 
            // BtnDisciplina
            // 
            this.BtnDisciplina.Image = global::AppFaculdade.Properties.Resources.icons8_livros_48;
            this.BtnDisciplina.Location = new System.Drawing.Point(55, 166);
            this.BtnDisciplina.Name = "BtnDisciplina";
            this.BtnDisciplina.Size = new System.Drawing.Size(133, 52);
            this.BtnDisciplina.TabIndex = 3;
            this.BtnDisciplina.Text = "Disciplina";
            this.BtnDisciplina.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnDisciplina.UseVisualStyleBackColor = true;
            this.BtnDisciplina.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnDisciplina_MouseClick);
            // 
            // BtnAluno
            // 
            this.BtnAluno.Image = global::AppFaculdade.Properties.Resources.icons8_estudantes_48;
            this.BtnAluno.Location = new System.Drawing.Point(55, 50);
            this.BtnAluno.Name = "BtnAluno";
            this.BtnAluno.Size = new System.Drawing.Size(133, 52);
            this.BtnAluno.TabIndex = 1;
            this.BtnAluno.Text = "Aluno";
            this.BtnAluno.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAluno.UseVisualStyleBackColor = true;
            this.BtnAluno.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BtnAluno_MouseClick);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(240, 246);
            this.Controls.Add(this.BtnDisciplina);
            this.Controls.Add(this.BtnProfessor);
            this.Controls.Add(this.BtnAluno);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alunoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem professorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disciplinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button BtnAluno;
        private System.Windows.Forms.Button BtnProfessor;
        private System.Windows.Forms.Button BtnDisciplina;
    }
}

