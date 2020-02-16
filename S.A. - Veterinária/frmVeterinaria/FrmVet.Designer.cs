namespace frmVeterinaria
{
    partial class FrmVet
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.grbDados = new System.Windows.Forms.GroupBox();
            this.mTxtTel = new System.Windows.Forms.MaskedTextBox();
            this.mTxtCpf = new System.Windows.Forms.MaskedTextBox();
            this.dtpDtNasc = new System.Windows.Forms.DateTimePicker();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDtNasc = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.grbPesquisa = new System.Windows.Forms.GroupBox();
            this.txtRegistroPesq = new System.Windows.Forms.TextBox();
            this.lblRegistroPesq = new System.Windows.Forms.Label();
            this.txtNomePesq = new System.Windows.Forms.TextBox();
            this.lblNomePesq = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.grbDados.SuspendLayout();
            this.grbPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(95, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(81, 31);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(8, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(81, 31);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // grbDados
            // 
            this.grbDados.Controls.Add(this.txtRegistro);
            this.grbDados.Controls.Add(this.lblRegistro);
            this.grbDados.Controls.Add(this.mTxtTel);
            this.grbDados.Controls.Add(this.mTxtCpf);
            this.grbDados.Controls.Add(this.dtpDtNasc);
            this.grbDados.Controls.Add(this.txtNome);
            this.grbDados.Controls.Add(this.lblDtNasc);
            this.grbDados.Controls.Add(this.lblTelefone);
            this.grbDados.Controls.Add(this.lblCpf);
            this.grbDados.Controls.Add(this.lblNome);
            this.grbDados.Location = new System.Drawing.Point(8, 49);
            this.grbDados.Name = "grbDados";
            this.grbDados.Size = new System.Drawing.Size(729, 105);
            this.grbDados.TabIndex = 5;
            this.grbDados.TabStop = false;
            this.grbDados.Text = "Dados";
            // 
            // mTxtTel
            // 
            this.mTxtTel.Location = new System.Drawing.Point(314, 69);
            this.mTxtTel.Mask = "(00) 0 0000-0000";
            this.mTxtTel.Name = "mTxtTel";
            this.mTxtTel.Size = new System.Drawing.Size(100, 20);
            this.mTxtTel.TabIndex = 9;
            // 
            // mTxtCpf
            // 
            this.mTxtCpf.Location = new System.Drawing.Point(48, 69);
            this.mTxtCpf.Mask = "000.000.000-00";
            this.mTxtCpf.Name = "mTxtCpf";
            this.mTxtCpf.Size = new System.Drawing.Size(100, 20);
            this.mTxtCpf.TabIndex = 8;
            this.mTxtCpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mTxtCpf_MaskInputRejected);
            // 
            // dtpDtNasc
            // 
            this.dtpDtNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDtNasc.Location = new System.Drawing.Point(605, 69);
            this.dtpDtNasc.Name = "dtpDtNasc";
            this.dtpDtNasc.Size = new System.Drawing.Size(100, 20);
            this.dtpDtNasc.TabIndex = 7;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(103, 25);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(441, 20);
            this.txtNome.TabIndex = 4;
            // 
            // lblDtNasc
            // 
            this.lblDtNasc.AutoSize = true;
            this.lblDtNasc.Location = new System.Drawing.Point(470, 72);
            this.lblDtNasc.Name = "lblDtNasc";
            this.lblDtNasc.Size = new System.Drawing.Size(104, 13);
            this.lblDtNasc.TabIndex = 3;
            this.lblDtNasc.Text = "Data de Nascimento";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(259, 72);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(49, 13);
            this.lblTelefone.TabIndex = 2;
            this.lblTelefone.Text = "Telefone";
            this.lblTelefone.Click += new System.EventHandler(this.lblTelefone_Click);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(15, 72);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(27, 13);
            this.lblCpf.TabIndex = 1;
            this.lblCpf.Text = "CPF";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(15, 25);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(82, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome Completo";
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(565, 28);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(46, 13);
            this.lblRegistro.TabIndex = 10;
            this.lblRegistro.Text = "Registro";
            // 
            // txtRegistro
            // 
            this.txtRegistro.Location = new System.Drawing.Point(617, 22);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.Size = new System.Drawing.Size(100, 20);
            this.txtRegistro.TabIndex = 11;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(656, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(81, 31);
            this.btnSair.TabIndex = 6;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // grbPesquisa
            // 
            this.grbPesquisa.Controls.Add(this.btnPesquisar);
            this.grbPesquisa.Controls.Add(this.txtID);
            this.grbPesquisa.Controls.Add(this.lblID);
            this.grbPesquisa.Controls.Add(this.txtRegistroPesq);
            this.grbPesquisa.Controls.Add(this.lblRegistroPesq);
            this.grbPesquisa.Controls.Add(this.lblNomePesq);
            this.grbPesquisa.Controls.Add(this.txtNomePesq);
            this.grbPesquisa.Location = new System.Drawing.Point(8, 169);
            this.grbPesquisa.Name = "grbPesquisa";
            this.grbPesquisa.Size = new System.Drawing.Size(729, 52);
            this.grbPesquisa.TabIndex = 7;
            this.grbPesquisa.TabStop = false;
            this.grbPesquisa.Text = "Pesquisar";
            // 
            // txtRegistroPesq
            // 
            this.txtRegistroPesq.Location = new System.Drawing.Point(165, 18);
            this.txtRegistroPesq.Name = "txtRegistroPesq";
            this.txtRegistroPesq.Size = new System.Drawing.Size(100, 20);
            this.txtRegistroPesq.TabIndex = 11;
            // 
            // lblRegistroPesq
            // 
            this.lblRegistroPesq.AutoSize = true;
            this.lblRegistroPesq.Location = new System.Drawing.Point(113, 21);
            this.lblRegistroPesq.Name = "lblRegistroPesq";
            this.lblRegistroPesq.Size = new System.Drawing.Size(46, 13);
            this.lblRegistroPesq.TabIndex = 10;
            this.lblRegistroPesq.Text = "Registro";
            // 
            // txtNomePesq
            // 
            this.txtNomePesq.Location = new System.Drawing.Point(324, 18);
            this.txtNomePesq.Name = "txtNomePesq";
            this.txtNomePesq.Size = new System.Drawing.Size(357, 20);
            this.txtNomePesq.TabIndex = 4;
            // 
            // lblNomePesq
            // 
            this.lblNomePesq.AutoSize = true;
            this.lblNomePesq.Location = new System.Drawing.Point(283, 21);
            this.lblNomePesq.Name = "lblNomePesq";
            this.lblNomePesq.Size = new System.Drawing.Size(35, 13);
            this.lblNomePesq.TabIndex = 0;
            this.lblNomePesq.Text = "Nome";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(15, 21);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 12;
            this.lblID.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(39, 18);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(58, 20);
            this.txtID.TabIndex = 13;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(687, 10);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(36, 35);
            this.btnPesquisar.TabIndex = 14;
            this.btnPesquisar.Text = "P";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(8, 227);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.Size = new System.Drawing.Size(729, 200);
            this.dgvDados.TabIndex = 8;
            // 
            // FrmVet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 439);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.grbPesquisa);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.grbDados);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Name = "FrmVet";
            this.Text = "Dados";
            this.grbDados.ResumeLayout(false);
            this.grbDados.PerformLayout();
            this.grbPesquisa.ResumeLayout(false);
            this.grbPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox grbDados;
        private System.Windows.Forms.MaskedTextBox mTxtTel;
        private System.Windows.Forms.MaskedTextBox mTxtCpf;
        private System.Windows.Forms.DateTimePicker dtpDtNasc;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDtNasc;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.GroupBox grbPesquisa;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtRegistroPesq;
        private System.Windows.Forms.Label lblRegistroPesq;
        private System.Windows.Forms.Label lblNomePesq;
        private System.Windows.Forms.TextBox txtNomePesq;
        private System.Windows.Forms.DataGridView dgvDados;
    }
}