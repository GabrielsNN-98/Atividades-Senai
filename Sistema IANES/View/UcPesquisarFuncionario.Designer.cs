namespace Sistema
{
    partial class UcPesquisarFuncionario
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNomeFuncPesquisa = new System.Windows.Forms.Label();
            this.lblCpfFuncPesquisa = new System.Windows.Forms.Label();
            this.txtNomeFuncPesquisa = new System.Windows.Forms.TextBox();
            this.txtCpfFuncPesquisa = new System.Windows.Forms.MaskedTextBox();
            this.dataGridFuncionario = new System.Windows.Forms.DataGridView();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.grbNome = new System.Windows.Forms.GroupBox();
            this.grbCpf = new System.Windows.Forms.GroupBox();
            this.toolTipEditar = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipAtualizar = new System.Windows.Forms.ToolTip(this.components);
            this.ColumnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEditar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFuncionario)).BeginInit();
            this.grbNome.SuspendLayout();
            this.grbCpf.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNomeFuncPesquisa
            // 
            this.lblNomeFuncPesquisa.AutoSize = true;
            this.lblNomeFuncPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblNomeFuncPesquisa.Location = new System.Drawing.Point(6, 31);
            this.lblNomeFuncPesquisa.Name = "lblNomeFuncPesquisa";
            this.lblNomeFuncPesquisa.Size = new System.Drawing.Size(49, 18);
            this.lblNomeFuncPesquisa.TabIndex = 0;
            this.lblNomeFuncPesquisa.Text = "Nome";
            // 
            // lblCpfFuncPesquisa
            // 
            this.lblCpfFuncPesquisa.AutoSize = true;
            this.lblCpfFuncPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.lblCpfFuncPesquisa.Location = new System.Drawing.Point(6, 31);
            this.lblCpfFuncPesquisa.Name = "lblCpfFuncPesquisa";
            this.lblCpfFuncPesquisa.Size = new System.Drawing.Size(38, 18);
            this.lblCpfFuncPesquisa.TabIndex = 1;
            this.lblCpfFuncPesquisa.Text = "CPF";
            // 
            // txtNomeFuncPesquisa
            // 
            this.txtNomeFuncPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtNomeFuncPesquisa.Location = new System.Drawing.Point(9, 52);
            this.txtNomeFuncPesquisa.Name = "txtNomeFuncPesquisa";
            this.txtNomeFuncPesquisa.Size = new System.Drawing.Size(333, 24);
            this.txtNomeFuncPesquisa.TabIndex = 2;
            this.txtNomeFuncPesquisa.TextChanged += new System.EventHandler(this.TxtNomeFuncPesquisa_TextChanged);
            this.txtNomeFuncPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtNomeFuncPesquisa_KeyPress);
            // 
            // txtCpfFuncPesquisa
            // 
            this.txtCpfFuncPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.txtCpfFuncPesquisa.Location = new System.Drawing.Point(9, 52);
            this.txtCpfFuncPesquisa.Mask = "000,000,000-00";
            this.txtCpfFuncPesquisa.Name = "txtCpfFuncPesquisa";
            this.txtCpfFuncPesquisa.ResetOnSpace = false;
            this.txtCpfFuncPesquisa.Size = new System.Drawing.Size(116, 24);
            this.txtCpfFuncPesquisa.TabIndex = 3;
            this.txtCpfFuncPesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCpfFuncPesquisa.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtCpfFuncPesquisa.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TxtCpfFuncPesquisa_MouseClick);
            this.txtCpfFuncPesquisa.TextChanged += new System.EventHandler(this.TxtCpfFuncPesquisa_TextChanged);
            this.txtCpfFuncPesquisa.Enter += new System.EventHandler(this.TxtCpfFuncPesquisa_Enter);
            // 
            // dataGridFuncionario
            // 
            this.dataGridFuncionario.AllowUserToAddRows = false;
            this.dataGridFuncionario.AllowUserToDeleteRows = false;
            this.dataGridFuncionario.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dataGridFuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFuncionario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnId,
            this.ColumnNome,
            this.ColumnCpf,
            this.ColumnCargo,
            this.ColumnEditar});
            this.dataGridFuncionario.Location = new System.Drawing.Point(26, 124);
            this.dataGridFuncionario.Name = "dataGridFuncionario";
            this.dataGridFuncionario.ReadOnly = true;
            this.dataGridFuncionario.RowHeadersVisible = false;
            this.dataGridFuncionario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridFuncionario.Size = new System.Drawing.Size(664, 332);
            this.dataGridFuncionario.TabIndex = 4;
            this.dataGridFuncionario.TabStop = false;
            this.dataGridFuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridFuncionario_CellContentClick);
            this.dataGridFuncionario.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridFuncionario_CellFormatting);
            this.dataGridFuncionario.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridFuncionario_CellMouseEnter);
            this.dataGridFuncionario.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridFuncionario_CellMouseLeave);
            this.dataGridFuncionario.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DataGridFuncionario_CellPainting);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAtualizar.Image = global::Sistema.Properties.Resources.refresh_page_option;
            this.btnAtualizar.Location = new System.Drawing.Point(613, 49);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(53, 42);
            this.btnAtualizar.TabIndex = 6;
            this.toolTipAtualizar.SetToolTip(this.btnAtualizar, "Atualizar Página");
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // grbNome
            // 
            this.grbNome.Controls.Add(this.lblNomeFuncPesquisa);
            this.grbNome.Controls.Add(this.txtNomeFuncPesquisa);
            this.grbNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.grbNome.Location = new System.Drawing.Point(41, 18);
            this.grbNome.Name = "grbNome";
            this.grbNome.Size = new System.Drawing.Size(354, 100);
            this.grbNome.TabIndex = 7;
            this.grbNome.TabStop = false;
            this.grbNome.Text = "Filtar por";
            // 
            // grbCpf
            // 
            this.grbCpf.Controls.Add(this.lblCpfFuncPesquisa);
            this.grbCpf.Controls.Add(this.txtCpfFuncPesquisa);
            this.grbCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.grbCpf.Location = new System.Drawing.Point(428, 18);
            this.grbCpf.Name = "grbCpf";
            this.grbCpf.Size = new System.Drawing.Size(135, 100);
            this.grbCpf.TabIndex = 8;
            this.grbCpf.TabStop = false;
            this.grbCpf.Text = "Filtrar por";
            // 
            // ColumnId
            // 
            this.ColumnId.DataPropertyName = "id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnId.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnId.HeaderText = "ID";
            this.ColumnId.Name = "ColumnId";
            this.ColumnId.ReadOnly = true;
            this.ColumnId.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnId.Width = 38;
            // 
            // ColumnNome
            // 
            this.ColumnNome.DataPropertyName = "nome";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnNome.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColumnNome.HeaderText = "Nome";
            this.ColumnNome.Name = "ColumnNome";
            this.ColumnNome.ReadOnly = true;
            this.ColumnNome.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnNome.Width = 260;
            // 
            // ColumnCpf
            // 
            this.ColumnCpf.DataPropertyName = "cpf";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.NullValue = null;
            this.ColumnCpf.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColumnCpf.HeaderText = "CPF";
            this.ColumnCpf.Name = "ColumnCpf";
            this.ColumnCpf.ReadOnly = true;
            this.ColumnCpf.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnCpf.Width = 110;
            // 
            // ColumnCargo
            // 
            this.ColumnCargo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnCargo.DataPropertyName = "tipo";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnCargo.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColumnCargo.HeaderText = "Cargo";
            this.ColumnCargo.Name = "ColumnCargo";
            this.ColumnCargo.ReadOnly = true;
            this.ColumnCargo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ColumnEditar
            // 
            this.ColumnEditar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ColumnEditar.HeaderText = "Editar";
            this.ColumnEditar.Name = "ColumnEditar";
            this.ColumnEditar.ReadOnly = true;
            this.ColumnEditar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColumnEditar.ToolTipText = "Editar Funcionário";
            this.ColumnEditar.Width = 60;
            // 
            // UcPesquisarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Controls.Add(this.grbCpf);
            this.Controls.Add(this.grbNome);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dataGridFuncionario);
            this.Name = "UcPesquisarFuncionario";
            this.Size = new System.Drawing.Size(719, 498);
            this.Load += new System.EventHandler(this.UcPesquisarFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFuncionario)).EndInit();
            this.grbNome.ResumeLayout(false);
            this.grbNome.PerformLayout();
            this.grbCpf.ResumeLayout(false);
            this.grbCpf.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblNomeFuncPesquisa;
        private System.Windows.Forms.Label lblCpfFuncPesquisa;
        private System.Windows.Forms.TextBox txtNomeFuncPesquisa;
        private System.Windows.Forms.MaskedTextBox txtCpfFuncPesquisa;
        private System.Windows.Forms.DataGridView dataGridFuncionario;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.GroupBox grbNome;
        private System.Windows.Forms.GroupBox grbCpf;
        private System.Windows.Forms.ToolTip toolTipAtualizar;
        private System.Windows.Forms.ToolTip toolTipEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCargo;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnEditar;
    }
}
