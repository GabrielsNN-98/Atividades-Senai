namespace Sistema
{
    partial class UcAddFuncionario
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcAddFuncionario));
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.grpCargo = new System.Windows.Forms.GroupBox();
            this.cmbCargo = new System.Windows.Forms.ComboBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.errNome = new System.Windows.Forms.ErrorProvider(this.components);
            this.errCpf = new System.Windows.Forms.ErrorProvider(this.components);
            this.errEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTelefone = new System.Windows.Forms.ErrorProvider(this.components);
            this.errCargo = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpLoginSenha = new System.Windows.Forms.GroupBox();
            this.txtConfirmSenha = new System.Windows.Forms.TextBox();
            this.lblConfirmSenha = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.errLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.errSenha = new System.Windows.Forms.ErrorProvider(this.components);
            this.errConfirmSenha = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpCargo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errNome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCpf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTelefone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCargo)).BeginInit();
            this.grpLoginSenha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSenha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errConfirmSenha)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(334, 385);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(126, 51);
            this.btnCancelar.TabIndex = 20;
            this.btnCancelar.TabStop = false;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAdicionar.Image = global::Sistema.Properties.Resources.add__5_;
            this.btnAdicionar.Location = new System.Drawing.Point(497, 385);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(126, 51);
            this.btnAdicionar.TabIndex = 19;
            this.btnAdicionar.TabStop = false;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // grpCargo
            // 
            this.grpCargo.Controls.Add(this.cmbCargo);
            this.grpCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.grpCargo.Location = new System.Drawing.Point(41, 208);
            this.grpCargo.Name = "grpCargo";
            this.grpCargo.Size = new System.Drawing.Size(261, 152);
            this.grpCargo.TabIndex = 18;
            this.grpCargo.TabStop = false;
            this.grpCargo.Text = "Cargo";
            // 
            // cmbCargo
            // 
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.FormattingEnabled = true;
            this.cmbCargo.Items.AddRange(new object[] {
            "Coordenador Geral",
            "Estagiário em Administração",
            "Estagiário em T.I.",
            "Auxiliar Administrativo",
            "Técnico T.I."});
            this.cmbCargo.Location = new System.Drawing.Point(6, 23);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(216, 26);
            this.cmbCargo.TabIndex = 21;
            this.cmbCargo.TabStop = false;
            this.cmbCargo.SelectionChangeCommitted += new System.EventHandler(this.CmbCargo_SelectionChangeCommitted);
            this.cmbCargo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbCargo_KeyDown);
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTelefone.Location = new System.Drawing.Point(504, 126);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(65, 18);
            this.lblTelefone.TabIndex = 14;
            this.lblTelefone.Text = "Telefone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblEmail.Location = new System.Drawing.Point(38, 126);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(50, 18);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "E-Mail";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCpf.Location = new System.Drawing.Point(504, 61);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(38, 18);
            this.lblCpf.TabIndex = 12;
            this.lblCpf.Text = "CPF";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNome.Location = new System.Drawing.Point(38, 62);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(49, 18);
            this.lblNome.TabIndex = 11;
            this.lblNome.Text = "Nome";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtTelefone.Location = new System.Drawing.Point(506, 146);
            this.txtTelefone.Mask = "(00) 00000-0000";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.ResetOnSpace = false;
            this.txtTelefone.Size = new System.Drawing.Size(117, 24);
            this.txtTelefone.TabIndex = 10;
            this.txtTelefone.TabStop = false;
            this.txtTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTelefone.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtTelefone_MouseClick);
            this.txtTelefone.Enter += new System.EventHandler(this.TxtTelefone_Enter);
            this.txtTelefone.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtTelefone_KeyDown);
            this.txtTelefone.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtTelefone_KeyUp);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtEmail.Location = new System.Drawing.Point(41, 146);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(351, 24);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.TabStop = false;
            this.txtEmail.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtEmail_KeyDown);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmail_KeyPress);
            this.txtEmail.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtEmail_KeyUp);
            // 
            // txtCpf
            // 
            this.txtCpf.AllowPromptAsInput = false;
            this.txtCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtCpf.Location = new System.Drawing.Point(507, 83);
            this.txtCpf.Mask = "000,000,000-00";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.ResetOnSpace = false;
            this.txtCpf.Size = new System.Drawing.Size(116, 24);
            this.txtCpf.TabIndex = 8;
            this.txtCpf.TabStop = false;
            this.txtCpf.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCpf.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtCpf_MouseClick);
            this.txtCpf.Enter += new System.EventHandler(this.TxtCpf_Enter);
            this.txtCpf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCpf_KeyDown);
            this.txtCpf.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtCpf_KeyUp);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtNome.Location = new System.Drawing.Point(41, 83);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(431, 24);
            this.txtNome.TabIndex = 7;
            this.txtNome.TabStop = false;
            this.txtNome.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNome_KeyDown);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNome_KeyPress);
            this.txtNome.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtNome_KeyUp);
            // 
            // errNome
            // 
            this.errNome.ContainerControl = this;
            // 
            // errCpf
            // 
            this.errCpf.ContainerControl = this;
            // 
            // errEmail
            // 
            this.errEmail.ContainerControl = this;
            // 
            // errTelefone
            // 
            this.errTelefone.ContainerControl = this;
            // 
            // errCargo
            // 
            this.errCargo.ContainerControl = this;
            // 
            // grpLoginSenha
            // 
            this.grpLoginSenha.Controls.Add(this.txtConfirmSenha);
            this.grpLoginSenha.Controls.Add(this.lblConfirmSenha);
            this.grpLoginSenha.Controls.Add(this.txtSenha);
            this.grpLoginSenha.Controls.Add(this.txtLogin);
            this.grpLoginSenha.Controls.Add(this.lblSenha);
            this.grpLoginSenha.Controls.Add(this.lblLogin);
            this.grpLoginSenha.Location = new System.Drawing.Point(347, 208);
            this.grpLoginSenha.Name = "grpLoginSenha";
            this.grpLoginSenha.Size = new System.Drawing.Size(276, 152);
            this.grpLoginSenha.TabIndex = 21;
            this.grpLoginSenha.TabStop = false;
            // 
            // txtConfirmSenha
            // 
            this.txtConfirmSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtConfirmSenha.Location = new System.Drawing.Point(130, 101);
            this.txtConfirmSenha.MaxLength = 15;
            this.txtConfirmSenha.Name = "txtConfirmSenha";
            this.txtConfirmSenha.PasswordChar = '*';
            this.txtConfirmSenha.Size = new System.Drawing.Size(123, 24);
            this.txtConfirmSenha.TabIndex = 5;
            this.txtConfirmSenha.TabStop = false;
            this.txtConfirmSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtConfirmSenha_KeyDown);
            this.txtConfirmSenha.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtConfirmSenha_KeyUp);
            // 
            // lblConfirmSenha
            // 
            this.lblConfirmSenha.AutoSize = true;
            this.lblConfirmSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblConfirmSenha.Location = new System.Drawing.Point(5, 104);
            this.lblConfirmSenha.Name = "lblConfirmSenha";
            this.lblConfirmSenha.Size = new System.Drawing.Size(120, 18);
            this.lblConfirmSenha.TabIndex = 4;
            this.lblConfirmSenha.Text = "Confirmar Senha";
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtSenha.Location = new System.Drawing.Point(130, 62);
            this.txtSenha.MaxLength = 15;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(123, 24);
            this.txtSenha.TabIndex = 3;
            this.txtSenha.TabStop = false;
            this.txtSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSenha_KeyDown);
            this.txtSenha.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSenha_KeyUp);
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtLogin.Location = new System.Drawing.Point(130, 23);
            this.txtLogin.MaxLength = 10;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(124, 24);
            this.txtLogin.TabIndex = 2;
            this.txtLogin.TabStop = false;
            this.txtLogin.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtLogin_KeyDown);
            this.txtLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLogin_KeyPress);
            this.txtLogin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtLogin_KeyUp);
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblSenha.Location = new System.Drawing.Point(44, 65);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(50, 18);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha";
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblLogin.Location = new System.Drawing.Point(47, 26);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(44, 18);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Login";
            // 
            // errLogin
            // 
            this.errLogin.ContainerControl = this;
            // 
            // errSenha
            // 
            this.errSenha.ContainerControl = this;
            // 
            // errConfirmSenha
            // 
            this.errConfirmSenha.ContainerControl = this;
            // 
            // UcAdicionarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.grpLoginSenha);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.grpCargo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtCpf);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txtTelefone);
            this.Name = "UcAdicionarFuncionario";
            this.Size = new System.Drawing.Size(719, 498);
            this.grpCargo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errNome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCpf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTelefone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCargo)).EndInit();
            this.grpLoginSenha.ResumeLayout(false);
            this.grpLoginSenha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSenha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errConfirmSenha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ErrorProvider errNome;
        private System.Windows.Forms.ErrorProvider errCpf;
        private System.Windows.Forms.ErrorProvider errEmail;
        private System.Windows.Forms.ErrorProvider errTelefone;
        private System.Windows.Forms.ErrorProvider errCargo;
        private System.Windows.Forms.GroupBox grpCargo;
        private System.Windows.Forms.ComboBox cmbCargo;
        private System.Windows.Forms.GroupBox grpLoginSenha;
        private System.Windows.Forms.TextBox txtConfirmSenha;
        private System.Windows.Forms.Label lblConfirmSenha;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.ErrorProvider errLogin;
        private System.Windows.Forms.ErrorProvider errSenha;
        private System.Windows.Forms.ErrorProvider errConfirmSenha;
    }
}
