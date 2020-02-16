namespace AppFaculdade
{
    partial class FrmAluno
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
            this.LblRa = new System.Windows.Forms.Label();
            this.LblDtMatri = new System.Windows.Forms.Label();
            this.TxtRa = new System.Windows.Forms.TextBox();
            this.DtpDtMatri = new System.Windows.Forms.DateTimePicker();
            this.GbAluno = new System.Windows.Forms.GroupBox();
            this.DtpDataNasc = new System.Windows.Forms.DateTimePicker();
            this.LblDtNasc = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnFechar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.GbAluno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // LblRa
            // 
            this.LblRa.AutoSize = true;
            this.LblRa.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblRa.Location = new System.Drawing.Point(8, 30);
            this.LblRa.Name = "LblRa";
            this.LblRa.Size = new System.Drawing.Size(22, 13);
            this.LblRa.TabIndex = 3;
            this.LblRa.Text = "RA";
            this.LblRa.Click += new System.EventHandler(this.label1_Click);
            // 
            // LblDtMatri
            // 
            this.LblDtMatri.AutoSize = true;
            this.LblDtMatri.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblDtMatri.Location = new System.Drawing.Point(8, 126);
            this.LblDtMatri.Name = "LblDtMatri";
            this.LblDtMatri.Size = new System.Drawing.Size(93, 13);
            this.LblDtMatri.TabIndex = 4;
            this.LblDtMatri.Text = "Data de Matrícula";
            // 
            // TxtRa
            // 
            this.TxtRa.Location = new System.Drawing.Point(11, 45);
            this.TxtRa.Name = "TxtRa";
            this.TxtRa.Size = new System.Drawing.Size(122, 20);
            this.TxtRa.TabIndex = 4;
            // 
            // DtpDtMatri
            // 
            this.DtpDtMatri.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpDtMatri.Location = new System.Drawing.Point(11, 142);
            this.DtpDtMatri.Name = "DtpDtMatri";
            this.DtpDtMatri.Size = new System.Drawing.Size(90, 20);
            this.DtpDtMatri.TabIndex = 6;
            // 
            // GbAluno
            // 
            this.GbAluno.BackColor = System.Drawing.SystemColors.HotTrack;
            this.GbAluno.Controls.Add(this.DtpDataNasc);
            this.GbAluno.Controls.Add(this.LblDtNasc);
            this.GbAluno.Controls.Add(this.TxtNome);
            this.GbAluno.Controls.Add(this.LblNome);
            this.GbAluno.Controls.Add(this.LblRa);
            this.GbAluno.Controls.Add(this.DtpDtMatri);
            this.GbAluno.Controls.Add(this.TxtRa);
            this.GbAluno.Controls.Add(this.LblDtMatri);
            this.GbAluno.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.GbAluno.Location = new System.Drawing.Point(12, 99);
            this.GbAluno.Name = "GbAluno";
            this.GbAluno.Size = new System.Drawing.Size(651, 187);
            this.GbAluno.TabIndex = 7;
            this.GbAluno.TabStop = false;
            this.GbAluno.Text = "Dados";
            this.GbAluno.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            this.LblDtNasc.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblDtNasc.Location = new System.Drawing.Point(223, 126);
            this.LblDtNasc.Name = "LblDtNasc";
            this.LblDtNasc.Size = new System.Drawing.Size(104, 13);
            this.LblDtNasc.TabIndex = 9;
            this.LblDtNasc.Text = "Data de Nascimento";
            this.LblDtNasc.Click += new System.EventHandler(this.label1_Click_1);
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
            this.LblNome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblNome.Location = new System.Drawing.Point(223, 30);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(82, 13);
            this.LblNome.TabIndex = 7;
            this.LblNome.Text = "Nome Completo";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(651, 150);
            this.dataGridView1.TabIndex = 8;
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
            // FrmAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(675, 482);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.GbAluno);
            this.Controls.Add(this.BtnFechar);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAluno";
            this.Load += new System.EventHandler(this.FrmAluno_Load);
            this.GbAluno.ResumeLayout(false);
            this.GbAluno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnFechar;
        private System.Windows.Forms.Label LblRa;
        private System.Windows.Forms.Label LblDtMatri;
        private System.Windows.Forms.TextBox TxtRa;
        private System.Windows.Forms.DateTimePicker DtpDtMatri;
        private System.Windows.Forms.GroupBox GbAluno;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblDtNasc;
        private System.Windows.Forms.DateTimePicker DtpDataNasc;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnSalvar;
    }
}