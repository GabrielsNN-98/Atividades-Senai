namespace Sistema
{
    partial class UcPesquisarEquipamento
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridEquipPesquisar = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipoequip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.cboStatusPesquisa = new System.Windows.Forms.ComboBox();
            this.toolTipAtualizar = new System.Windows.Forms.ToolTip(this.components);
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTipbtndatagrid = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEquipPesquisar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridEquipPesquisar
            // 
            this.dataGridEquipPesquisar.AllowUserToAddRows = false;
            this.dataGridEquipPesquisar.AllowUserToDeleteRows = false;
            this.dataGridEquipPesquisar.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEquipPesquisar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridEquipPesquisar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEquipPesquisar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Tipoequip,
            this.Status,
            this.Editar});
            this.dataGridEquipPesquisar.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEquipPesquisar.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridEquipPesquisar.Location = new System.Drawing.Point(103, 61);
            this.dataGridEquipPesquisar.Name = "dataGridEquipPesquisar";
            this.dataGridEquipPesquisar.ReadOnly = true;
            this.dataGridEquipPesquisar.RowHeadersVisible = false;
            this.dataGridEquipPesquisar.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridEquipPesquisar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEquipPesquisar.Size = new System.Drawing.Size(531, 422);
            this.dataGridEquipPesquisar.TabIndex = 0;
            this.dataGridEquipPesquisar.TabStop = false;
            this.dataGridEquipPesquisar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridEquipPesquisar_CellContentClick);
            this.dataGridEquipPesquisar.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridEquipPesquisar_CellFormatting);
            this.dataGridEquipPesquisar.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEquipPesquisar_CellMouseEnter);
            this.dataGridEquipPesquisar.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridEquipPesquisar_CellMouseLeave);
            this.dataGridEquipPesquisar.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DataGridEquipPesquisar_CellPainting);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID.HeaderText = "   ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ID.Width = 105;
            // 
            // Tipoequip
            // 
            this.Tipoequip.DataPropertyName = "tipo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tipoequip.DefaultCellStyle = dataGridViewCellStyle3;
            this.Tipoequip.HeaderText = "   Tipo Equipamento";
            this.Tipoequip.MaxInputLength = 30;
            this.Tipoequip.Name = "Tipoequip";
            this.Tipoequip.ReadOnly = true;
            this.Tipoequip.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Tipoequip.Width = 225;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.DataPropertyName = "status";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.DefaultCellStyle = dataGridViewCellStyle4;
            this.Status.HeaderText = "Status";
            this.Status.MaxInputLength = 15;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Editar
            // 
            this.Editar.DataPropertyName = "editar";
            this.Editar.HeaderText = "Editar";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Editar.Text = "";
            this.Editar.UseColumnTextForButtonValue = true;
            this.Editar.Width = 55;
            // 
            // cboStatusPesquisa
            // 
            this.cboStatusPesquisa.BackColor = System.Drawing.Color.White;
            this.cboStatusPesquisa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboStatusPesquisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatusPesquisa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboStatusPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboStatusPesquisa.FormattingEnabled = true;
            this.cboStatusPesquisa.Items.AddRange(new object[] {
            "Todos os Equipamentos",
            "Equipamentos Indisponíveis",
            "Equipamentos Disponíveis"});
            this.cboStatusPesquisa.Location = new System.Drawing.Point(160, 21);
            this.cboStatusPesquisa.Name = "cboStatusPesquisa";
            this.cboStatusPesquisa.Size = new System.Drawing.Size(260, 26);
            this.cboStatusPesquisa.TabIndex = 10;
            this.cboStatusPesquisa.TabStop = false;
            this.cboStatusPesquisa.SelectedIndexChanged += new System.EventHandler(this.CboStatusPesquisa_SelectedIndexChanged);
            // 
            // toolTipAtualizar
            // 
            this.toolTipAtualizar.AutoPopDelay = 10000;
            this.toolTipAtualizar.InitialDelay = 1;
            this.toolTipAtualizar.ReshowDelay = 100;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Image = global::Sistema.Properties.Resources.refresh_page_option;
            this.btnAtualizar.Location = new System.Drawing.Point(581, 13);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(53, 42);
            this.btnAtualizar.TabIndex = 13;
            this.btnAtualizar.TabStop = false;
            this.toolTipAtualizar.SetToolTip(this.btnAtualizar, "Atualizar");
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Status:";
            // 
            // toolTipbtndatagrid
            // 
            this.toolTipbtndatagrid.AutoPopDelay = 10000;
            this.toolTipbtndatagrid.InitialDelay = 1;
            this.toolTipbtndatagrid.ReshowDelay = 100;
            // 
            // UcPesquisarEquipamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.cboStatusPesquisa);
            this.Controls.Add(this.dataGridEquipPesquisar);
            this.Name = "UcPesquisarEquipamento";
            this.Size = new System.Drawing.Size(719, 498);
            this.Load += new System.EventHandler(this.UcPesquisarEquipamentoTelaPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEquipPesquisar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridEquipPesquisar;
        private System.Windows.Forms.ComboBox cboStatusPesquisa;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.ToolTip toolTipAtualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipoequip;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.ToolTip toolTipbtndatagrid;
    }
}
