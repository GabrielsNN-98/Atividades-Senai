namespace Sistema
{
    partial class EditarFuncionario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarFuncionario));
            this.lblNomeFuncEditar = new System.Windows.Forms.Label();
            this.lblCpfFuncEditar = new System.Windows.Forms.Label();
            this.lblEmailFuncEditar = new System.Windows.Forms.Label();
            this.lblTelefoneFuncEditar = new System.Windows.Forms.Label();
            this.lblCargoFuncEditar = new System.Windows.Forms.Label();
            this.txtNomeFuncEditar = new System.Windows.Forms.TextBox();
            this.txtCpfFuncEditar = new System.Windows.Forms.MaskedTextBox();
            this.txtEmailFuncEditar = new System.Windows.Forms.TextBox();
            this.txtTelefoneFuncEditar = new System.Windows.Forms.MaskedTextBox();
            this.cmbCargoFuncEditar = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblIdFuncEditar = new System.Windows.Forms.Label();
            this.txtIdFuncEditar = new System.Windows.Forms.TextBox();
            this.errNomeUpdate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errCpfUpdate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errTelefoneUpdate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errEmailUpdate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errCargoUpdate = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTipSalvar = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipVoltar = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errNomeUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCpfUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTelefoneUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmailUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCargoUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeFuncEditar
            // 
            this.lblNomeFuncEditar.AutoSize = true;
            this.lblNomeFuncEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNomeFuncEditar.Location = new System.Drawing.Point(119, 26);
            this.lblNomeFuncEditar.Name = "lblNomeFuncEditar";
            this.lblNomeFuncEditar.Size = new System.Drawing.Size(49, 18);
            this.lblNomeFuncEditar.TabIndex = 0;
            this.lblNomeFuncEditar.Text = "Nome";
            // 
            // lblCpfFuncEditar
            // 
            this.lblCpfFuncEditar.AutoSize = true;
            this.lblCpfFuncEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCpfFuncEditar.Location = new System.Drawing.Point(37, 99);
            this.lblCpfFuncEditar.Name = "lblCpfFuncEditar";
            this.lblCpfFuncEditar.Size = new System.Drawing.Size(38, 18);
            this.lblCpfFuncEditar.TabIndex = 1;
            this.lblCpfFuncEditar.Text = "CPF";
            // 
            // lblEmailFuncEditar
            // 
            this.lblEmailFuncEditar.AutoSize = true;
            this.lblEmailFuncEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblEmailFuncEditar.Location = new System.Drawing.Point(37, 158);
            this.lblEmailFuncEditar.Name = "lblEmailFuncEditar";
            this.lblEmailFuncEditar.Size = new System.Drawing.Size(50, 18);
            this.lblEmailFuncEditar.TabIndex = 2;
            this.lblEmailFuncEditar.Text = "E-Mail";
            // 
            // lblTelefoneFuncEditar
            // 
            this.lblTelefoneFuncEditar.AutoSize = true;
            this.lblTelefoneFuncEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblTelefoneFuncEditar.Location = new System.Drawing.Point(433, 99);
            this.lblTelefoneFuncEditar.Name = "lblTelefoneFuncEditar";
            this.lblTelefoneFuncEditar.Size = new System.Drawing.Size(65, 18);
            this.lblTelefoneFuncEditar.TabIndex = 3;
            this.lblTelefoneFuncEditar.Text = "Telefone";
            // 
            // lblCargoFuncEditar
            // 
            this.lblCargoFuncEditar.AutoSize = true;
            this.lblCargoFuncEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCargoFuncEditar.Location = new System.Drawing.Point(38, 225);
            this.lblCargoFuncEditar.Name = "lblCargoFuncEditar";
            this.lblCargoFuncEditar.Size = new System.Drawing.Size(49, 18);
            this.lblCargoFuncEditar.TabIndex = 4;
            this.lblCargoFuncEditar.Text = "Cargo";
            // 
            // txtNomeFuncEditar
            // 
            this.txtNomeFuncEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtNomeFuncEditar.Location = new System.Drawing.Point(122, 47);
            this.txtNomeFuncEditar.MaxLength = 100;
            this.txtNomeFuncEditar.Name = "txtNomeFuncEditar";
            this.txtNomeFuncEditar.Size = new System.Drawing.Size(431, 24);
            this.txtNomeFuncEditar.TabIndex = 8;
            this.txtNomeFuncEditar.TabStop = false;
            this.txtNomeFuncEditar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNomeFuncEditar_KeyDown);
            this.txtNomeFuncEditar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNomeFuncEditar_KeyPress);
            this.txtNomeFuncEditar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtNomeFuncEditar_KeyUp);
            // 
            // txtCpfFuncEditar
            // 
            this.txtCpfFuncEditar.AllowPromptAsInput = false;
            this.txtCpfFuncEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtCpfFuncEditar.Location = new System.Drawing.Point(40, 120);
            this.txtCpfFuncEditar.Mask = "000,000,000-00";
            this.txtCpfFuncEditar.Name = "txtCpfFuncEditar";
            this.txtCpfFuncEditar.ResetOnSpace = false;
            this.txtCpfFuncEditar.Size = new System.Drawing.Size(116, 24);
            this.txtCpfFuncEditar.TabIndex = 9;
            this.txtCpfFuncEditar.TabStop = false;
            this.txtCpfFuncEditar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCpfFuncEditar.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCpfFuncEditar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtCpfFuncEditar_MouseClick);
            this.txtCpfFuncEditar.Enter += new System.EventHandler(this.TxtCpfFuncEditar_Enter);
            this.txtCpfFuncEditar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCpfFuncEditar_KeyDown);
            this.txtCpfFuncEditar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtCpfFuncEditar_KeyUp);
            // 
            // txtEmailFuncEditar
            // 
            this.txtEmailFuncEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtEmailFuncEditar.Location = new System.Drawing.Point(40, 179);
            this.txtEmailFuncEditar.Name = "txtEmailFuncEditar";
            this.txtEmailFuncEditar.Size = new System.Drawing.Size(351, 24);
            this.txtEmailFuncEditar.TabIndex = 10;
            this.txtEmailFuncEditar.TabStop = false;
            this.txtEmailFuncEditar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtEmailFuncEditar_KeyDown);
            this.txtEmailFuncEditar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtEmailFuncEditar_KeyPress);
            this.txtEmailFuncEditar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtEmailFuncEditar_KeyUp);
            // 
            // txtTelefoneFuncEditar
            // 
            this.txtTelefoneFuncEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtTelefoneFuncEditar.Location = new System.Drawing.Point(436, 120);
            this.txtTelefoneFuncEditar.Mask = "(00) 00000-0000";
            this.txtTelefoneFuncEditar.Name = "txtTelefoneFuncEditar";
            this.txtTelefoneFuncEditar.ResetOnSpace = false;
            this.txtTelefoneFuncEditar.Size = new System.Drawing.Size(117, 24);
            this.txtTelefoneFuncEditar.TabIndex = 11;
            this.txtTelefoneFuncEditar.TabStop = false;
            this.txtTelefoneFuncEditar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTelefoneFuncEditar.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtTelefoneFuncEditar.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtTelefoneFuncEditar_MouseClick);
            this.txtTelefoneFuncEditar.Enter += new System.EventHandler(this.TxtTelefoneFuncEditar_Enter);
            this.txtTelefoneFuncEditar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtTelefoneFuncEditar_KeyDown);
            this.txtTelefoneFuncEditar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtTelefoneFuncEditar_KeyUp);
            // 
            // cmbCargoFuncEditar
            // 
            this.cmbCargoFuncEditar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargoFuncEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cmbCargoFuncEditar.FormattingEnabled = true;
            this.cmbCargoFuncEditar.Items.AddRange(new object[] {
            "Coordenador Geral",
            "Estagiário em Administração",
            "Estagiário em T.I.",
            "Auxiliar Administrativo",
            "Técnico T.I."});
            this.cmbCargoFuncEditar.Location = new System.Drawing.Point(41, 246);
            this.cmbCargoFuncEditar.Name = "cmbCargoFuncEditar";
            this.cmbCargoFuncEditar.Size = new System.Drawing.Size(216, 26);
            this.cmbCargoFuncEditar.TabIndex = 22;
            this.cmbCargoFuncEditar.TabStop = false;
            this.cmbCargoFuncEditar.SelectionChangeCommitted += new System.EventHandler(this.CmbCargoFuncEditar_SelectionChangeCommitted);
            this.cmbCargoFuncEditar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CmbCargoFuncEditar_KeyDown);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSalvar.Image = global::Sistema.Properties.Resources.save;
            this.btnSalvar.Location = new System.Drawing.Point(495, 279);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(53, 42);
            this.btnSalvar.TabIndex = 23;
            this.toolTipSalvar.SetToolTip(this.btnSalvar, "Salvar");
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnVoltar.Image = global::Sistema.Properties.Resources.back_arrow;
            this.btnVoltar.Location = new System.Drawing.Point(389, 279);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(53, 42);
            this.btnVoltar.TabIndex = 24;
            this.toolTipVoltar.SetToolTip(this.btnVoltar, "Voltar");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // lblIdFuncEditar
            // 
            this.lblIdFuncEditar.AutoSize = true;
            this.lblIdFuncEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblIdFuncEditar.Location = new System.Drawing.Point(37, 26);
            this.lblIdFuncEditar.Name = "lblIdFuncEditar";
            this.lblIdFuncEditar.Size = new System.Drawing.Size(22, 18);
            this.lblIdFuncEditar.TabIndex = 25;
            this.lblIdFuncEditar.Text = "ID";
            // 
            // txtIdFuncEditar
            // 
            this.txtIdFuncEditar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtIdFuncEditar.Enabled = false;
            this.txtIdFuncEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtIdFuncEditar.Location = new System.Drawing.Point(40, 47);
            this.txtIdFuncEditar.Name = "txtIdFuncEditar";
            this.txtIdFuncEditar.ReadOnly = true;
            this.txtIdFuncEditar.Size = new System.Drawing.Size(46, 24);
            this.txtIdFuncEditar.TabIndex = 26;
            // 
            // errNomeUpdate
            // 
            this.errNomeUpdate.ContainerControl = this;
            // 
            // errCpfUpdate
            // 
            this.errCpfUpdate.ContainerControl = this;
            // 
            // errTelefoneUpdate
            // 
            this.errTelefoneUpdate.ContainerControl = this;
            // 
            // errEmailUpdate
            // 
            this.errEmailUpdate.ContainerControl = this;
            // 
            // errCargoUpdate
            // 
            this.errCargoUpdate.ContainerControl = this;
            // 
            // EditarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(608, 422);
            this.Controls.Add(this.txtIdFuncEditar);
            this.Controls.Add(this.lblIdFuncEditar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cmbCargoFuncEditar);
            this.Controls.Add(this.txtTelefoneFuncEditar);
            this.Controls.Add(this.txtEmailFuncEditar);
            this.Controls.Add(this.txtCpfFuncEditar);
            this.Controls.Add(this.txtNomeFuncEditar);
            this.Controls.Add(this.lblCargoFuncEditar);
            this.Controls.Add(this.lblTelefoneFuncEditar);
            this.Controls.Add(this.lblEmailFuncEditar);
            this.Controls.Add(this.lblCpfFuncEditar);
            this.Controls.Add(this.lblNomeFuncEditar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de Funcionários";
            this.Load += new System.EventHandler(this.EditarFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errNomeUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCpfUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errTelefoneUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errEmailUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCargoUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeFuncEditar;
        private System.Windows.Forms.Label lblCpfFuncEditar;
        private System.Windows.Forms.Label lblEmailFuncEditar;
        private System.Windows.Forms.Label lblTelefoneFuncEditar;
        private System.Windows.Forms.Label lblCargoFuncEditar;
        private System.Windows.Forms.TextBox txtNomeFuncEditar;
        private System.Windows.Forms.MaskedTextBox txtCpfFuncEditar;
        private System.Windows.Forms.TextBox txtEmailFuncEditar;
        private System.Windows.Forms.MaskedTextBox txtTelefoneFuncEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblIdFuncEditar;
        private System.Windows.Forms.ErrorProvider errNomeUpdate;
        private System.Windows.Forms.ErrorProvider errCpfUpdate;
        private System.Windows.Forms.ErrorProvider errTelefoneUpdate;
        private System.Windows.Forms.ErrorProvider errEmailUpdate;
        private System.Windows.Forms.ErrorProvider errCargoUpdate;
        public System.Windows.Forms.TextBox txtIdFuncEditar;
        public System.Windows.Forms.ComboBox cmbCargoFuncEditar;
        private System.Windows.Forms.ToolTip toolTipSalvar;
        private System.Windows.Forms.ToolTip toolTipVoltar;
    }
}