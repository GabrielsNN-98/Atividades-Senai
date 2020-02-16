namespace Sistema
{
    partial class UcAddEquipamento
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
            this.cboEquip = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSerial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errTipoEquip = new System.Windows.Forms.ErrorProvider(this.components);
            this.errMarca = new System.Windows.Forms.ErrorProvider(this.components);
            this.errSerial = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAddEquipamento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errTipoEquip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMarca)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSerial)).BeginInit();
            this.SuspendLayout();
            // 
            // cboEquip
            // 
            this.cboEquip.BackColor = System.Drawing.Color.White;
            this.cboEquip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboEquip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEquip.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEquip.FormattingEnabled = true;
            this.cboEquip.Items.AddRange(new object[] {
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
            this.cboEquip.Location = new System.Drawing.Point(222, 89);
            this.cboEquip.Name = "cboEquip";
            this.cboEquip.Size = new System.Drawing.Size(226, 26);
            this.cboEquip.TabIndex = 9;
            this.cboEquip.TabStop = false;
            this.cboEquip.SelectionChangeCommitted += new System.EventHandler(this.CboEquip_SelectionChangeCommitted);
            this.cboEquip.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CboEquip_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tipo de Equipamento:";
            // 
            // txtSerial
            // 
            this.txtSerial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerial.Location = new System.Drawing.Point(222, 332);
            this.txtSerial.MaxLength = 50;
            this.txtSerial.Name = "txtSerial";
            this.txtSerial.Size = new System.Drawing.Size(359, 17);
            this.txtSerial.TabIndex = 16;
            this.txtSerial.TabStop = false;
            this.txtSerial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSerial_KeyDown);
            this.txtSerial.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSerial_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Descrição do Produto:";
            // 
            // txtMarca
            // 
            this.txtMarca.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMarca.Location = new System.Drawing.Point(222, 296);
            this.txtMarca.MaxLength = 30;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(359, 17);
            this.txtMarca.TabIndex = 15;
            this.txtMarca.TabStop = false;
            this.txtMarca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtMarca_KeyDown);
            this.txtMarca.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMarca_KeyUp);
            // 
            // txtDescricao
            // 
            this.txtDescricao.AccessibleDescription = "";
            this.txtDescricao.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.ForeColor = System.Drawing.Color.DarkGray;
            this.txtDescricao.HideSelection = false;
            this.txtDescricao.Location = new System.Drawing.Point(222, 131);
            this.txtDescricao.MaxLength = 200;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricao.Size = new System.Drawing.Size(426, 142);
            this.txtDescricao.TabIndex = 12;
            this.txtDescricao.TabStop = false;
            this.txtDescricao.Text = "Max 200 carateres...";
            this.txtDescricao.Enter += new System.EventHandler(this.TxtDescricao_Enter);
            this.txtDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDescricao_KeyDown);
            this.txtDescricao.Leave += new System.EventHandler(this.TxtDescricao_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(94, 331);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Serial de Fábrica:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(162, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "Marca:";
            // 
            // errTipoEquip
            // 
            this.errTipoEquip.ContainerControl = this;
            // 
            // errMarca
            // 
            this.errMarca.ContainerControl = this;
            // 
            // errSerial
            // 
            this.errSerial.ContainerControl = this;
            // 
            // btnAddEquipamento
            // 
            this.btnAddEquipamento.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddEquipamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEquipamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEquipamento.Image = global::Sistema.Properties.Resources.add__5_;
            this.btnAddEquipamento.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddEquipamento.Location = new System.Drawing.Point(295, 383);
            this.btnAddEquipamento.Name = "btnAddEquipamento";
            this.btnAddEquipamento.Size = new System.Drawing.Size(174, 49);
            this.btnAddEquipamento.TabIndex = 18;
            this.btnAddEquipamento.TabStop = false;
            this.btnAddEquipamento.Text = "Adicionar Equipamento";
            this.btnAddEquipamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEquipamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddEquipamento.UseVisualStyleBackColor = true;
            this.btnAddEquipamento.Click += new System.EventHandler(this.BtnAddEquipamento_Click);
            // 
            // UcAddEquipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.btnAddEquipamento);
            this.Controls.Add(this.cboEquip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSerial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtMarca);
            this.Name = "UcAddEquipamento";
            this.Size = new System.Drawing.Size(719, 498);
            ((System.ComponentModel.ISupportInitialize)(this.errTipoEquip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errMarca)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errSerial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboEquip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSerial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddEquipamento;
        private System.Windows.Forms.ErrorProvider errTipoEquip;
        private System.Windows.Forms.ErrorProvider errMarca;
        private System.Windows.Forms.ErrorProvider errSerial;
    }
}
