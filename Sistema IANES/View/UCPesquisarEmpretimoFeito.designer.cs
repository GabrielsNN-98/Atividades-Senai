namespace Sistema
{
    partial class UCPesquisarEmpretimoFeito
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridEmprestimosFeitos = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataFinalEmprestimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VerificarInformacoes = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.cboStatusPesquisa = new System.Windows.Forms.ComboBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmprestimosFeitos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridEmprestimosFeitos
            // 
            this.dataGridEmprestimosFeitos.AllowUserToAddRows = false;
            this.dataGridEmprestimosFeitos.AllowUserToDeleteRows = false;
            this.dataGridEmprestimosFeitos.AllowUserToResizeColumns = false;
            this.dataGridEmprestimosFeitos.AllowUserToResizeRows = false;
            this.dataGridEmprestimosFeitos.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEmprestimosFeitos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridEmprestimosFeitos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmprestimosFeitos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nome,
            this.DataEmprestimo,
            this.DataFinalEmprestimo,
            this.Status,
            this.VerificarInformacoes});
            this.dataGridEmprestimosFeitos.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEmprestimosFeitos.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridEmprestimosFeitos.Location = new System.Drawing.Point(35, 74);
            this.dataGridEmprestimosFeitos.Name = "dataGridEmprestimosFeitos";
            this.dataGridEmprestimosFeitos.ReadOnly = true;
            this.dataGridEmprestimosFeitos.RowHeadersVisible = false;
            this.dataGridEmprestimosFeitos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridEmprestimosFeitos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEmprestimosFeitos.Size = new System.Drawing.Size(655, 400);
            this.dataGridEmprestimosFeitos.TabIndex = 17;
            this.dataGridEmprestimosFeitos.TabStop = false;
            this.dataGridEmprestimosFeitos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridEmprestimosFeitos_CellContentClick);
            this.dataGridEmprestimosFeitos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridEmprestimosFeitos_CellFormatting);
            this.dataGridEmprestimosFeitos.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridEmprestimosFeitos_CellMouseEnter);
            this.dataGridEmprestimosFeitos.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridEmprestimosFeitos_CellMouseLeave);
            this.dataGridEmprestimosFeitos.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DataGridEmprestimosFeitos_CellPainting);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "ID";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.DefaultCellStyle = dataGridViewCellStyle9;
            this.ID.HeaderText = "ID Empréstimo";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Nome
            // 
            this.Nome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nome.DataPropertyName = "idRequisitante";
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nome.DefaultCellStyle = dataGridViewCellStyle10;
            this.Nome.HeaderText = "ID Requisitante";
            this.Nome.MaxInputLength = 200;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DataEmprestimo
            // 
            this.DataEmprestimo.DataPropertyName = "dataHora";
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.Format = "d";
            dataGridViewCellStyle11.NullValue = null;
            this.DataEmprestimo.DefaultCellStyle = dataGridViewCellStyle11;
            this.DataEmprestimo.HeaderText = "Data Empréstimo";
            this.DataEmprestimo.MaxInputLength = 20;
            this.DataEmprestimo.Name = "DataEmprestimo";
            this.DataEmprestimo.ReadOnly = true;
            this.DataEmprestimo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // DataFinalEmprestimo
            // 
            this.DataFinalEmprestimo.DataPropertyName = "dataFinal";
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.Format = "d";
            dataGridViewCellStyle12.NullValue = null;
            this.DataFinalEmprestimo.DefaultCellStyle = dataGridViewCellStyle12;
            this.DataFinalEmprestimo.HeaderText = "Data para Devolução";
            this.DataFinalEmprestimo.MaxInputLength = 20;
            this.DataFinalEmprestimo.Name = "DataFinalEmprestimo";
            this.DataFinalEmprestimo.ReadOnly = true;
            this.DataFinalEmprestimo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "status";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.DefaultCellStyle = dataGridViewCellStyle13;
            this.Status.HeaderText = "Status";
            this.Status.MaxInputLength = 50;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Status.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // VerificarInformacoes
            // 
            this.VerificarInformacoes.HeaderText = "Informações";
            this.VerificarInformacoes.Name = "VerificarInformacoes";
            this.VerificarInformacoes.ReadOnly = true;
            this.VerificarInformacoes.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.VerificarInformacoes.Width = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 18);
            this.label1.TabIndex = 18;
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
            "Empréstimos Entregues",
            "Empréstimos Pendentes",
            "Empréstimos Atrasados"});
            this.cboStatusPesquisa.Location = new System.Drawing.Point(169, 34);
            this.cboStatusPesquisa.Name = "cboStatusPesquisa";
            this.cboStatusPesquisa.Size = new System.Drawing.Size(258, 26);
            this.cboStatusPesquisa.TabIndex = 21;
            this.cboStatusPesquisa.TabStop = false;
            this.cboStatusPesquisa.SelectedIndexChanged += new System.EventHandler(this.CboStatusPesquisa_SelectedIndexChanged);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Image = global::Sistema.Properties.Resources.refresh_icon;
            this.btnAtualizar.Location = new System.Drawing.Point(637, 26);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(53, 42);
            this.btnAtualizar.TabIndex = 20;
            this.btnAtualizar.TabStop = false;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // UCEmpretimoFeito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.cboStatusPesquisa);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridEmprestimosFeitos);
            this.Name = "UCEmpretimoFeito";
            this.Size = new System.Drawing.Size(719, 498);
            this.Load += new System.EventHandler(this.UCEmpretimoFeito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmprestimosFeitos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridEmprestimosFeitos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.ComboBox cboStatusPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataFinalEmprestimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewButtonColumn VerificarInformacoes;
    }
}
