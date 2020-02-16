namespace FrmMatricula
{
    partial class FrmMatricula
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
            this.lblMatricula = new System.Windows.Forms.Label();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.DadosAluno = new System.Windows.Forms.GroupBox();
            this.NotasAluno = new System.Windows.Forms.GroupBox();
            this.txtNota4 = new System.Windows.Forms.TextBox();
            this.txtNota1 = new System.Windows.Forms.TextBox();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.lblNota4 = new System.Windows.Forms.Label();
            this.txtNota2 = new System.Windows.Forms.TextBox();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.txtNota3 = new System.Windows.Forms.TextBox();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.DadosAluno.SuspendLayout();
            this.NotasAluno.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMatricula
            // 
            this.lblMatricula.AutoSize = true;
            this.lblMatricula.Location = new System.Drawing.Point(22, 33);
            this.lblMatricula.Name = "lblMatricula";
            this.lblMatricula.Size = new System.Drawing.Size(52, 13);
            this.lblMatricula.TabIndex = 0;
            this.lblMatricula.Text = "Matrícula";
            this.lblMatricula.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(88, 30);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(321, 20);
            this.txtMatricula.TabIndex = 1;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(22, 65);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(88, 62);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(419, 20);
            this.txtNome.TabIndex = 3;
            // 
            // DadosAluno
            // 
            this.DadosAluno.Controls.Add(this.lblMatricula);
            this.DadosAluno.Controls.Add(this.txtNome);
            this.DadosAluno.Controls.Add(this.txtMatricula);
            this.DadosAluno.Controls.Add(this.lblNome);
            this.DadosAluno.Location = new System.Drawing.Point(12, 12);
            this.DadosAluno.Name = "DadosAluno";
            this.DadosAluno.Size = new System.Drawing.Size(526, 107);
            this.DadosAluno.TabIndex = 4;
            this.DadosAluno.TabStop = false;
            // 
            // NotasAluno
            // 
            this.NotasAluno.Controls.Add(this.txtNota4);
            this.NotasAluno.Controls.Add(this.txtNota1);
            this.NotasAluno.Controls.Add(this.lblNota1);
            this.NotasAluno.Controls.Add(this.lblNota4);
            this.NotasAluno.Controls.Add(this.txtNota2);
            this.NotasAluno.Controls.Add(this.lblNota2);
            this.NotasAluno.Controls.Add(this.txtNota3);
            this.NotasAluno.Controls.Add(this.lblNota3);
            this.NotasAluno.Location = new System.Drawing.Point(12, 125);
            this.NotasAluno.Name = "NotasAluno";
            this.NotasAluno.Size = new System.Drawing.Size(139, 155);
            this.NotasAluno.TabIndex = 5;
            this.NotasAluno.TabStop = false;
            this.NotasAluno.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtNota4
            // 
            this.txtNota4.Location = new System.Drawing.Point(73, 120);
            this.txtNota4.Name = "txtNota4";
            this.txtNota4.Size = new System.Drawing.Size(44, 20);
            this.txtNota4.TabIndex = 6;
            // 
            // txtNota1
            // 
            this.txtNota1.Location = new System.Drawing.Point(73, 27);
            this.txtNota1.Name = "txtNota1";
            this.txtNota1.Size = new System.Drawing.Size(44, 20);
            this.txtNota1.TabIndex = 6;
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(15, 30);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(39, 13);
            this.lblNota1.TabIndex = 6;
            this.lblNota1.Text = "Nota 1";
            // 
            // lblNota4
            // 
            this.lblNota4.AutoSize = true;
            this.lblNota4.Location = new System.Drawing.Point(15, 123);
            this.lblNota4.Name = "lblNota4";
            this.lblNota4.Size = new System.Drawing.Size(39, 13);
            this.lblNota4.TabIndex = 6;
            this.lblNota4.Text = "Nota 4";
            // 
            // txtNota2
            // 
            this.txtNota2.Location = new System.Drawing.Point(73, 58);
            this.txtNota2.Name = "txtNota2";
            this.txtNota2.Size = new System.Drawing.Size(44, 20);
            this.txtNota2.TabIndex = 6;
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(15, 62);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(39, 13);
            this.lblNota2.TabIndex = 6;
            this.lblNota2.Text = "Nota 2";
            // 
            // txtNota3
            // 
            this.txtNota3.Location = new System.Drawing.Point(73, 91);
            this.txtNota3.Name = "txtNota3";
            this.txtNota3.Size = new System.Drawing.Size(44, 20);
            this.txtNota3.TabIndex = 6;
            // 
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(15, 94);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(39, 13);
            this.lblNota3.TabIndex = 6;
            this.lblNota3.Text = "Nota 3";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Castellar", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(259, 238);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 23);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(171, 137);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(86, 35);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            this.btnCalcular.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnCalcular_MouseClick);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(263, 137);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(86, 35);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(355, 137);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(86, 35);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnSair_MouseClick);
            // 
            // FrmMatricula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 362);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.NotasAluno);
            this.Controls.Add(this.DadosAluno);
            this.Name = "FrmMatricula";
            this.Text = "Matricula";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DadosAluno.ResumeLayout(false);
            this.DadosAluno.PerformLayout();
            this.NotasAluno.ResumeLayout(false);
            this.NotasAluno.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatricula;
        private System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox DadosAluno;
        private System.Windows.Forms.GroupBox NotasAluno;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtNota4;
        private System.Windows.Forms.TextBox txtNota1;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.Label lblNota4;
        private System.Windows.Forms.TextBox txtNota2;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.TextBox txtNota3;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

