namespace AppFaculdade
{
    partial class FrmDisciplina
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
            this.GbDisciplina = new System.Windows.Forms.GroupBox();
            this.CmbProfessor = new System.Windows.Forms.ComboBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblCargaHoraria = new System.Windows.Forms.Label();
            this.TxtCargaHoraria = new System.Windows.Forms.TextBox();
            this.LblProfessor = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.GbDisciplina.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GbDisciplina
            // 
            this.GbDisciplina.Controls.Add(this.CmbProfessor);
            this.GbDisciplina.Controls.Add(this.TxtNome);
            this.GbDisciplina.Controls.Add(this.LblNome);
            this.GbDisciplina.Controls.Add(this.LblCargaHoraria);
            this.GbDisciplina.Controls.Add(this.TxtCargaHoraria);
            this.GbDisciplina.Controls.Add(this.LblProfessor);
            this.GbDisciplina.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GbDisciplina.Location = new System.Drawing.Point(12, 99);
            this.GbDisciplina.Name = "GbDisciplina";
            this.GbDisciplina.Size = new System.Drawing.Size(651, 187);
            this.GbDisciplina.TabIndex = 8;
            this.GbDisciplina.TabStop = false;
            this.GbDisciplina.Text = "Dados";
            this.GbDisciplina.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // CmbProfessor
            // 
            this.CmbProfessor.FormattingEnabled = true;
            this.CmbProfessor.Location = new System.Drawing.Point(11, 142);
            this.CmbProfessor.Name = "CmbProfessor";
            this.CmbProfessor.Size = new System.Drawing.Size(346, 21);
            this.CmbProfessor.TabIndex = 6;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(226, 46);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(355, 20);
            this.TxtNome.TabIndex = 5;
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(223, 30);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(35, 13);
            this.LblNome.TabIndex = 7;
            this.LblNome.Text = "Nome";
            // 
            // LblCargaHoraria
            // 
            this.LblCargaHoraria.AutoSize = true;
            this.LblCargaHoraria.Location = new System.Drawing.Point(8, 30);
            this.LblCargaHoraria.Name = "LblCargaHoraria";
            this.LblCargaHoraria.Size = new System.Drawing.Size(72, 13);
            this.LblCargaHoraria.TabIndex = 3;
            this.LblCargaHoraria.Text = "Carga Horária";
            // 
            // TxtCargaHoraria
            // 
            this.TxtCargaHoraria.Location = new System.Drawing.Point(11, 46);
            this.TxtCargaHoraria.Name = "TxtCargaHoraria";
            this.TxtCargaHoraria.Size = new System.Drawing.Size(122, 20);
            this.TxtCargaHoraria.TabIndex = 4;
            // 
            // LblProfessor
            // 
            this.LblProfessor.AutoSize = true;
            this.LblProfessor.Location = new System.Drawing.Point(8, 126);
            this.LblProfessor.Name = "LblProfessor";
            this.LblProfessor.Size = new System.Drawing.Size(51, 13);
            this.LblProfessor.TabIndex = 4;
            this.LblProfessor.Text = "Professor";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(651, 150);
            this.dataGridView1.TabIndex = 11;
            // 
            // BtnFechar
            // 
            this.BtnFechar.Image = global::AppFaculdade.Properties.Resources.icons8_sair_48;
            this.BtnFechar.Location = new System.Drawing.Point(362, 12);
            this.BtnFechar.Name = "BtnFechar";
            this.BtnFechar.Size = new System.Drawing.Size(110, 55);
            this.BtnFechar.TabIndex = 3;
            this.BtnFechar.Text = "&Fechar";
            this.BtnFechar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFechar.UseVisualStyleBackColor = true;
            this.BtnFechar.Click += new System.EventHandler(this.BtnFechar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Image = global::AppFaculdade.Properties.Resources.icons8_excluir_48;
            this.BtnCancelar.Location = new System.Drawing.Point(185, 12);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(110, 55);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "&Cancelar";
            this.BtnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Image = global::AppFaculdade.Properties.Resources.icons8_salvar_48;
            this.BtnSalvar.Location = new System.Drawing.Point(12, 12);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(110, 55);
            this.BtnSalvar.TabIndex = 1;
            this.BtnSalvar.Text = "&Salvar";
            this.BtnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // FrmDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(675, 482);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GbDisciplina);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDisciplina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmDisciplina";
            this.GbDisciplina.ResumeLayout(false);
            this.GbDisciplina.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.GroupBox GbDisciplina;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblCargaHoraria;
        private System.Windows.Forms.TextBox TxtCargaHoraria;
        private System.Windows.Forms.Label LblProfessor;
        private System.Windows.Forms.ComboBox CmbProfessor;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}