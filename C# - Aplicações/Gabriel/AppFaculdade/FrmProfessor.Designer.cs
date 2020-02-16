namespace AppFaculdade
{
    partial class FrmProfessor
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
            this.GbProfessor = new System.Windows.Forms.GroupBox();
            this.CmbGrauForma = new System.Windows.Forms.ComboBox();
            this.DtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.LblDtNasc = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblRegistro = new System.Windows.Forms.Label();
            this.TxtRegistro = new System.Windows.Forms.TextBox();
            this.LblGrauForma = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.GbProfessor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GbProfessor
            // 
            this.GbProfessor.Controls.Add(this.CmbGrauForma);
            this.GbProfessor.Controls.Add(this.DtpDataNasc);
            this.GbProfessor.Controls.Add(this.LblDtNasc);
            this.GbProfessor.Controls.Add(this.TxtNome);
            this.GbProfessor.Controls.Add(this.LblNome);
            this.GbProfessor.Controls.Add(this.LblRegistro);
            this.GbProfessor.Controls.Add(this.TxtRegistro);
            this.GbProfessor.Controls.Add(this.LblGrauForma);
            this.GbProfessor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GbProfessor.Location = new System.Drawing.Point(12, 99);
            this.GbProfessor.Name = "GbProfessor";
            this.GbProfessor.Size = new System.Drawing.Size(651, 187);
            this.GbProfessor.TabIndex = 9;
            this.GbProfessor.TabStop = false;
            this.GbProfessor.Text = "Dados";
            // 
            // CmbGrauForma
            // 
            this.CmbGrauForma.FormattingEnabled = true;
            this.CmbGrauForma.Items.AddRange(new object[] {
            "Fundamental - Incompleto",
            "Fundamental - Completo",
            "Médio - Incompleto",
            "Médio - Completo",
            "Superior - Incompleto",
            "Superior - Completo",
            "Pós-graduação - Incompleto",
            "Pós-graduação - Completo",
            "Mestrado - Incompleto",
            "Mestrado - Completo",
            "Doutorado - Incompleto",
            "Doutorado - Completo"});
            this.CmbGrauForma.Location = new System.Drawing.Point(9, 142);
            this.CmbGrauForma.Name = "CmbGrauForma";
            this.CmbGrauForma.Size = new System.Drawing.Size(156, 21);
            this.CmbGrauForma.TabIndex = 6;
            this.CmbGrauForma.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // DtpDataNasc
            // 
            this.DtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDataNasc.Location = new System.Drawing.Point(226, 142);
            this.DtpDataNasc.Name = "DtpDataNasc";
            this.DtpDataNasc.Size = new System.Drawing.Size(90, 20);
            this.DtpDataNasc.TabIndex = 7;
            // 
            // LblDtNasc
            // 
            this.LblDtNasc.AutoSize = true;
            this.LblDtNasc.Location = new System.Drawing.Point(223, 126);
            this.LblDtNasc.Name = "LblDtNasc";
            this.LblDtNasc.Size = new System.Drawing.Size(104, 13);
            this.LblDtNasc.TabIndex = 9;
            this.LblDtNasc.Text = "Data de Nascimento";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(226, 46);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(419, 20);
            this.TxtNome.TabIndex = 5;
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(223, 30);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(82, 13);
            this.LblNome.TabIndex = 7;
            this.LblNome.Text = "Nome Completo";
            // 
            // LblRegistro
            // 
            this.LblRegistro.AutoSize = true;
            this.LblRegistro.Location = new System.Drawing.Point(8, 30);
            this.LblRegistro.Name = "LblRegistro";
            this.LblRegistro.Size = new System.Drawing.Size(46, 13);
            this.LblRegistro.TabIndex = 3;
            this.LblRegistro.Text = "Registro";
            // 
            // TxtRegistro
            // 
            this.TxtRegistro.Location = new System.Drawing.Point(11, 46);
            this.TxtRegistro.Name = "TxtRegistro";
            this.TxtRegistro.Size = new System.Drawing.Size(122, 20);
            this.TxtRegistro.TabIndex = 4;
            // 
            // LblGrauForma
            // 
            this.LblGrauForma.AutoSize = true;
            this.LblGrauForma.Location = new System.Drawing.Point(6, 126);
            this.LblGrauForma.Name = "LblGrauForma";
            this.LblGrauForma.Size = new System.Drawing.Size(95, 13);
            this.LblGrauForma.TabIndex = 4;
            this.LblGrauForma.Text = "Grau de Formação";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(651, 150);
            this.dataGridView1.TabIndex = 10;
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
            // FrmProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(675, 482);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GbProfessor);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmProfessor";
            this.GbProfessor.ResumeLayout(false);
            this.GbProfessor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.GroupBox GbProfessor;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblRegistro;
        private System.Windows.Forms.TextBox TxtRegistro;
        private System.Windows.Forms.Label LblGrauForma;
        private System.Windows.Forms.ComboBox CmbGrauForma;
        private System.Windows.Forms.DateTimePicker DtpDataNasc;
        private System.Windows.Forms.Label LblDtNasc;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}