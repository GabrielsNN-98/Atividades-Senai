namespace Sistema
{
    partial class EditarEquipamento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditarEquipamento));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtNumeroSerie = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.toolTipVoltar = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSalvar = new System.Windows.Forms.ToolTip(this.components);
            this.errMarcaMudar = new System.Windows.Forms.ErrorProvider(this.components);
            this.errNSerialMudar = new System.Windows.Forms.ErrorProvider(this.components);
            this.cboTipoEquip = new System.Windows.Forms.ComboBox();
            this.errCboTipoMudar = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errMarcaMudar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNSerialMudar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCboTipoMudar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Image = global::Sistema.Properties.Resources.back_arrow;
            this.btnVoltar.Location = new System.Drawing.Point(168, 349);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(53, 42);
            this.btnVoltar.TabIndex = 43;
            this.btnVoltar.TabStop = false;
            this.toolTipVoltar.SetToolTip(this.btnVoltar, "Voltar");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(330, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 18);
            this.label7.TabIndex = 41;
            this.label7.Text = "Status:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Image = global::Sistema.Properties.Resources.save;
            this.btnSalvar.Location = new System.Drawing.Point(477, 349);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(53, 42);
            this.btnSalvar.TabIndex = 28;
            this.btnSalvar.TabStop = false;
            this.toolTipSalvar.SetToolTip(this.btnSalvar, "Salvar");
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 18);
            this.label6.TabIndex = 39;
            this.label6.Text = "Tipo Equipamento:";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(168, 32);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(140, 24);
            this.txtId.TabIndex = 29;
            this.txtId.TabStop = false;
            this.txtId.Text = " ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "Nº de Série:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 18);
            this.label1.TabIndex = 34;
            this.label1.Text = "Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(108, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 36;
            this.label3.Text = "Marca:";
            // 
            // txtMarca
            // 
            this.txtMarca.BackColor = System.Drawing.SystemColors.Window;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(168, 110);
            this.txtMarca.MaxLength = 30;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(302, 24);
            this.txtMarca.TabIndex = 30;
            this.txtMarca.TabStop = false;
            this.txtMarca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtMarca_KeyDown);
            this.txtMarca.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtMarca_KeyUp);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(168, 189);
            this.txtDescricao.MaxLength = 200;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricao.Size = new System.Drawing.Size(362, 147);
            this.txtDescricao.TabIndex = 32;
            this.txtDescricao.TabStop = false;
            this.txtDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDescricao_KeyDown);
            // 
            // txtNumeroSerie
            // 
            this.txtNumeroSerie.BackColor = System.Drawing.SystemColors.Window;
            this.txtNumeroSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumeroSerie.Location = new System.Drawing.Point(168, 149);
            this.txtNumeroSerie.MaxLength = 50;
            this.txtNumeroSerie.Name = "txtNumeroSerie";
            this.txtNumeroSerie.Size = new System.Drawing.Size(362, 24);
            this.txtNumeroSerie.TabIndex = 31;
            this.txtNumeroSerie.TabStop = false;
            this.txtNumeroSerie.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtNumeroSerie_KeyDown);
            this.txtNumeroSerie.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtNumeroSerie_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 37;
            this.label4.Text = "Descrição:";
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtStatus.Enabled = false;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(390, 32);
            this.txtStatus.MaxLength = 15;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(140, 24);
            this.txtStatus.TabIndex = 42;
            this.txtStatus.TabStop = false;
            // 
            // toolTipVoltar
            // 
            this.toolTipVoltar.AutoPopDelay = 10000;
            this.toolTipVoltar.InitialDelay = 1;
            this.toolTipVoltar.ReshowDelay = 100;
            // 
            // toolTipSalvar
            // 
            this.toolTipSalvar.AutoPopDelay = 10000;
            this.toolTipSalvar.InitialDelay = 1;
            this.toolTipSalvar.ReshowDelay = 100;
            // 
            // errMarcaMudar
            // 
            this.errMarcaMudar.ContainerControl = this;
            // 
            // errNSerialMudar
            // 
            this.errNSerialMudar.ContainerControl = this;
            // 
            // cboTipoEquip
            // 
            this.cboTipoEquip.BackColor = System.Drawing.Color.White;
            this.cboTipoEquip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoEquip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboTipoEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoEquip.FormattingEnabled = true;
            this.cboTipoEquip.Items.AddRange(new object[] {
            "Adaptador HDMI",
            "Caixa de Som",
            "Controle de Datashow",
            "Datashow",
            "Extensão",
            "Filtro de Linha",
            "Microfone",
            "Mouse",
            "Notebook",
            "Projetor",
            "Teclado",
            "Transformador"});
            this.cboTipoEquip.Location = new System.Drawing.Point(168, 71);
            this.cboTipoEquip.Name = "cboTipoEquip";
            this.cboTipoEquip.Size = new System.Drawing.Size(242, 26);
            this.cboTipoEquip.TabIndex = 44;
            this.cboTipoEquip.TabStop = false;
            this.cboTipoEquip.SelectionChangeCommitted += new System.EventHandler(this.CboTipoEquip_SelectionChangeCommitted);
            this.cboTipoEquip.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CboTipoEquip_KeyDown);
            // 
            // errCboTipoMudar
            // 
            this.errCboTipoMudar.ContainerControl = this;
            // 
            // EditarEquipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(608, 422);
            this.Controls.Add(this.cboTipoEquip);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNumeroSerie);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditarEquipamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editor de Equipamentos";
            this.Load += new System.EventHandler(this.EditarEquipamento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errMarcaMudar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errNSerialMudar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errCboTipoMudar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtMarca;
        public System.Windows.Forms.TextBox txtDescricao;
        public System.Windows.Forms.TextBox txtNumeroSerie;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTipVoltar;
        private System.Windows.Forms.ToolTip toolTipSalvar;
        public System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.ErrorProvider errMarcaMudar;
        private System.Windows.Forms.ErrorProvider errNSerialMudar;
        public System.Windows.Forms.ComboBox cboTipoEquip;
        private System.Windows.Forms.ErrorProvider errCboTipoMudar;
    }
}