namespace Sistema
{
    partial class UCDevolucao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridDevolucao = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataFinalEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entregar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cboStatusPesquisa = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDevolucao)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridDevolucao
            // 
            this.dataGridDevolucao.AllowUserToAddRows = false;
            this.dataGridDevolucao.AllowUserToDeleteRows = false;
            this.dataGridDevolucao.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDevolucao.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridDevolucao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDevolucao.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.DataFinalEmprestimo,
            this.Status,
            this.Entregar});
            this.dataGridDevolucao.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDevolucao.DefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridDevolucao.Location = new System.Drawing.Point(35, 74);
            this.dataGridDevolucao.Name = "dataGridDevolucao";
            this.dataGridDevolucao.ReadOnly = true;
            this.dataGridDevolucao.RowHeadersVisible = false;
            this.dataGridDevolucao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridDevolucao.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDevolucao.Size = new System.Drawing.Size(655, 400);
            this.dataGridDevolucao.TabIndex = 18;
            this.dataGridDevolucao.TabStop = false;
            this.dataGridDevolucao.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridEmprestimosFeitos_CellContentClick);
            this.dataGridDevolucao.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridEmprestimosFeitos_CellFormatting);
            this.dataGridDevolucao.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridEmprestimosFeitos_CellMouseEnter);
            this.dataGridDevolucao.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridEmprestimosFeitos_CellMouseLeave);
            this.dataGridDevolucao.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DataGridEmprestimosFeitos_CellPainting);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "ID";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.DefaultCellStyle = dataGridViewCellStyle16;
            this.ID.HeaderText = "ID  Empréstimo";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "idRequisitante";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.DefaultCellStyle = dataGridViewCellStyle17;
            this.Nome.HeaderText = "ID Requisitante";
            this.Nome.MaxInputLength = 30;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DataFinalEmprestimo
            // 
            this.DataFinalEmprestimo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataFinalEmprestimo.DataPropertyName = "dataFinal";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataFinalEmprestimo.DefaultCellStyle = dataGridViewCellStyle18;
            this.DataFinalEmprestimo.HeaderText = "Data para Devolução";
            this.DataFinalEmprestimo.Name = "DataFinalEmprestimo";
            this.DataFinalEmprestimo.ReadOnly = true;
            this.DataFinalEmprestimo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Status.DataPropertyName = "status";
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.DefaultCellStyle = dataGridViewCellStyle19;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Entregar
            // 
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entregar.DefaultCellStyle = dataGridViewCellStyle20;
            this.Entregar.HeaderText = "Entregar Equipamento";
            this.Entregar.Name = "Entregar";
            this.Entregar.ReadOnly = true;
            this.Entregar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Image = global::Sistema.Properties.Resources.refresh_icon;
            this.btnAtualizar.Location = new System.Drawing.Point(637, 26);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(53, 42);
            this.btnAtualizar.TabIndex = 21;
            this.btnAtualizar.TabStop = false;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 22;
            this.label1.Text = "Pesquisar Status: ";
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
            "Todos os Empréstimos",
            "Empréstimos Pendentes",
            "Empréstimos Atrasados"});
            this.cboStatusPesquisa.Location = new System.Drawing.Point(169, 34);
            this.cboStatusPesquisa.Name = "cboStatusPesquisa";
            this.cboStatusPesquisa.Size = new System.Drawing.Size(258, 26);
            this.cboStatusPesquisa.TabIndex = 23;
            this.cboStatusPesquisa.TabStop = false;
            this.cboStatusPesquisa.SelectedIndexChanged += new System.EventHandler(this.CboStatusPesquisa_SelectedIndexChanged);
            // 
            // UCDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.cboStatusPesquisa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dataGridDevolucao);
            this.Name = "UCDevolucao";
            this.Size = new System.Drawing.Size(719, 498);
            this.Load += new System.EventHandler(this.UCDevolucao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDevolucao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridDevolucao;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataFinalEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn Entregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboStatusPesquisa;
    }
}
