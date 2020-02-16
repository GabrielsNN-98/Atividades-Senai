namespace frmVeterinaria
{
    partial class FrmCliente
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
            this.lblNome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbDados = new System.Windows.Forms.GroupBox();
            this.mTxtTel = new System.Windows.Forms.MaskedTextBox();
            this.mTxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.dtpDtNasc = new System.Windows.Forms.DateTimePicker();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDtNasc = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.grbDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(15, 40);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(82, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome Completo";
            this.lblNome.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 31);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // grbDados
            // 
            this.grbDados.Controls.Add(this.mTxtTel);
            this.grbDados.Controls.Add(this.mTxtCpf);
            this.grbDados.Controls.Add(this.dtpDtNasc);
            this.grbDados.Controls.Add(this.txtNome);
            this.grbDados.Controls.Add(this.lblDtNasc);
            this.grbDados.Controls.Add(this.lblTelefone);
            this.grbDados.Controls.Add(this.lblCpf);
            this.grbDados.Controls.Add(this.lblNome);
            this.grbDados.Location = new System.Drawing.Point(29, 79);
            this.grbDados.Name = "grbDados";
            this.grbDados.Size = new System.Drawing.Size(383, 221);
            this.grbDados.TabIndex = 3;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "Dados";
            this.grbDados.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // mTxtTel
            // 
            this.mTxtTel.Location = new System.Drawing.Point(100, 114);
            this.mTxtTel.Mask = "(00) 0 0000-0000";
            this.mTxtTel.Name = "mTxtTel";
            this.mTxtTel.Size = new System.Drawing.Size(100, 20);
            this.mTxtTel.TabIndex = 9;
            // 
            // mTxtCpf
            // 
            this.mTxtCpf.Location = new System.Drawing.Point(100, 79);
            this.mTxtCpf.Mask = "000.000.000-00";
            this.mTxtCpf.Name = "mTxtCpf";
            this.mTxtCpf.Size = new System.Drawing.Size(100, 20);
            this.mTxtCpf.TabIndex = 8;
            // 
            // dtpDtNasc
            // 
            this.dtpDtNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtNasc.Location = new System.Drawing.Point(125, 148);
            this.dtpDtNasc.Name = "dtpDtNasc";
            this.dtpDtNasc.Size = new System.Drawing.Size(100, 20);
            this.dtpDtNasc.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(103, 37);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 4;
            // 
            // lblDtNasc
            // 
            this.lblDtNasc.AutoSize = true;
            this.lblDtNasc.Location = new System.Drawing.Point(15, 154);
            this.lblDtNasc.Name = "lblDtNasc";
            this.lblDtNasc.Size = new System.Drawing.Size(104, 13);
            this.lblDtNasc.TabIndex = 3;
            this.lblDtNasc.Text = "Data de Nascimento";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(15, 121);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 2;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(15, 82);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 1;
            this.lblCpf.Text = "CPF";
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 342);
            this.Controls.Add(this.grbDados);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FrmCliente";
            this.Text = "FrmCliente";
            this.grbDados.ResumeLayout(false);
            this.grbDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grbDados;
        private System.Windows.Forms.DateTimePicker dtpDtNasc;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDtNasc;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.MaskedTextBox mTxtCpf;
        private System.Windows.Forms.MaskedTextBox mTxtTel;
    }
}