namespace OrdemServico
{
    partial class Form1
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
            this.lblCliente = new System.Windows.Forms.Label();
            this.lblRespTec = new System.Windows.Forms.Label();
            this.lblAbertura = new System.Windows.Forms.Label();
            this.lblFechamento = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblDiagTec = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtRespTec = new System.Windows.Forms.TextBox();
            this.dtpAbertura = new System.Windows.Forms.DateTimePicker();
            this.dtpFechamento = new System.Windows.Forms.DateTimePicker();
            this.rTxtDescricao = new System.Windows.Forms.RichTextBox();
            this.rTxtDiagTec = new System.Windows.Forms.RichTextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCliente.Location = new System.Drawing.Point(12, 19);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(51, 17);
            this.lblCliente.TabIndex = 0;
            this.lblCliente.Text = "Cliente";
            // 
            // lblRespTec
            // 
            this.lblRespTec.AutoSize = true;
            this.lblRespTec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblRespTec.Location = new System.Drawing.Point(12, 77);
            this.lblRespTec.Name = "lblRespTec";
            this.lblRespTec.Size = new System.Drawing.Size(144, 17);
            this.lblRespTec.TabIndex = 1;
            this.lblRespTec.Text = "Responsável Técnico";
            // 
            // lblAbertura
            // 
            this.lblAbertura.AutoSize = true;
            this.lblAbertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAbertura.Location = new System.Drawing.Point(437, 45);
            this.lblAbertura.Name = "lblAbertura";
            this.lblAbertura.Size = new System.Drawing.Size(63, 17);
            this.lblAbertura.TabIndex = 2;
            this.lblAbertura.Text = "Abertura";
            // 
            // lblFechamento
            // 
            this.lblFechamento.AutoSize = true;
            this.lblFechamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblFechamento.Location = new System.Drawing.Point(558, 45);
            this.lblFechamento.Name = "lblFechamento";
            this.lblFechamento.Size = new System.Drawing.Size(86, 17);
            this.lblFechamento.TabIndex = 3;
            this.lblFechamento.Text = "Fechamento";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDescricao.Location = new System.Drawing.Point(12, 141);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(71, 17);
            this.lblDescricao.TabIndex = 4;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblDiagTec
            // 
            this.lblDiagTec.AutoSize = true;
            this.lblDiagTec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDiagTec.Location = new System.Drawing.Point(283, 141);
            this.lblDiagTec.Name = "lblDiagTec";
            this.lblDiagTec.Size = new System.Drawing.Size(136, 17);
            this.lblDiagTec.TabIndex = 5;
            this.lblDiagTec.Text = "Diagnóstico Técnico";
            // 
            // txtCliente
            // 
            this.txtCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtCliente.Location = new System.Drawing.Point(15, 39);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(385, 23);
            this.txtCliente.TabIndex = 6;
            // 
            // txtRespTec
            // 
            this.txtRespTec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtRespTec.Location = new System.Drawing.Point(15, 97);
            this.txtRespTec.Name = "txtRespTec";
            this.txtRespTec.Size = new System.Drawing.Size(385, 23);
            this.txtRespTec.TabIndex = 7;
            // 
            // dtpAbertura
            // 
            this.dtpAbertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpAbertura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAbertura.Location = new System.Drawing.Point(440, 65);
            this.dtpAbertura.Name = "dtpAbertura";
            this.dtpAbertura.Size = new System.Drawing.Size(95, 23);
            this.dtpAbertura.TabIndex = 8;
            // 
            // dtpFechamento
            // 
            this.dtpFechamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpFechamento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechamento.Location = new System.Drawing.Point(559, 65);
            this.dtpFechamento.Name = "dtpFechamento";
            this.dtpFechamento.Size = new System.Drawing.Size(95, 23);
            this.dtpFechamento.TabIndex = 9;
            // 
            // rTxtDescricao
            // 
            this.rTxtDescricao.Location = new System.Drawing.Point(15, 161);
            this.rTxtDescricao.Name = "rTxtDescricao";
            this.rTxtDescricao.Size = new System.Drawing.Size(250, 231);
            this.rTxtDescricao.TabIndex = 10;
            this.rTxtDescricao.Text = "";
            // 
            // rTxtDiagTec
            // 
            this.rTxtDiagTec.Location = new System.Drawing.Point(286, 161);
            this.rTxtDiagTec.Name = "rTxtDiagTec";
            this.rTxtDiagTec.Size = new System.Drawing.Size(254, 231);
            this.rTxtDiagTec.TabIndex = 11;
            this.rTxtDiagTec.Text = "";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSalvar.Location = new System.Drawing.Point(552, 221);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(108, 31);
            this.btnSalvar.TabIndex = 12;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelar.Location = new System.Drawing.Point(550, 258);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 31);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(670, 434);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.rTxtDiagTec);
            this.Controls.Add(this.rTxtDescricao);
            this.Controls.Add(this.dtpFechamento);
            this.Controls.Add(this.dtpAbertura);
            this.Controls.Add(this.txtRespTec);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lblDiagTec);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblFechamento);
            this.Controls.Add(this.lblAbertura);
            this.Controls.Add(this.lblRespTec);
            this.Controls.Add(this.lblCliente);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Label lblRespTec;
        private System.Windows.Forms.Label lblAbertura;
        private System.Windows.Forms.Label lblFechamento;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblDiagTec;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtRespTec;
        private System.Windows.Forms.DateTimePicker dtpAbertura;
        private System.Windows.Forms.DateTimePicker dtpFechamento;
        private System.Windows.Forms.RichTextBox rTxtDescricao;
        private System.Windows.Forms.RichTextBox rTxtDiagTec;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
    }
}

