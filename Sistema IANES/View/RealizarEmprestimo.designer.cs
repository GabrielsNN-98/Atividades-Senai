namespace Sistema
{
    partial class RealizarEmprestimo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RealizarEmprestimo));
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboLocalSala = new System.Windows.Forms.ComboBox();
            this.dtPickerEmprestimo = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.dataGridEquipamento = new System.Windows.Forms.DataGridView();
            this.IDEquip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoEquip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddEquip = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridEmprestimo = new System.Windows.Forms.DataGridView();
            this.IDEmpre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoEmpre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExcluirEmpre = new System.Windows.Forms.DataGridViewButtonColumn();
            this.errorProviderLocal = new System.Windows.Forms.ErrorProvider(this.components);
            this.toolTipVoltar = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSalvar = new System.Windows.Forms.ToolTip(this.components);
            this.errorProviderDatagrid = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEquipamento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmprestimo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLocal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoltar.Image = global::Sistema.Properties.Resources.Back_icon;
            this.btnVoltar.Location = new System.Drawing.Point(186, 173);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(53, 42);
            this.btnVoltar.TabIndex = 57;
            this.btnVoltar.TabStop = false;
            this.toolTipVoltar.SetToolTip(this.btnVoltar, "Voltar");
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalvar.Image = global::Sistema.Properties.Resources.save_icon;
            this.btnSalvar.Location = new System.Drawing.Point(594, 173);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(53, 42);
            this.btnSalvar.TabIndex = 56;
            this.btnSalvar.TabStop = false;
            this.toolTipSalvar.SetToolTip(this.btnSalvar, "Salvar");
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(154, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 18);
            this.label5.TabIndex = 55;
            this.label5.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(186, 14);
            this.txtId.MaxLength = 100;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(140, 24);
            this.txtId.TabIndex = 54;
            this.txtId.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(385, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 52;
            this.label4.Text = "Cargo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 49;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(186, 44);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(461, 24);
            this.txtNome.TabIndex = 48;
            this.txtNome.TabStop = false;
            // 
            // txtCargo
            // 
            this.txtCargo.Enabled = false;
            this.txtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Location = new System.Drawing.Point(444, 14);
            this.txtCargo.MaxLength = 100;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(203, 24);
            this.txtCargo.TabIndex = 58;
            this.txtCargo.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(99, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 18);
            this.label2.TabIndex = 59;
            this.label2.Text = "Local/Sala:";
            // 
            // cboLocalSala
            // 
            this.cboLocalSala.BackColor = System.Drawing.Color.White;
            this.cboLocalSala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cboLocalSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLocalSala.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboLocalSala.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLocalSala.FormattingEnabled = true;
            this.cboLocalSala.IntegralHeight = false;
            this.cboLocalSala.Items.AddRange(new object[] {
            "Sala 01",
            "Sala 02",
            "Sala 03",
            "Sala 04",
            "Sala 05",
            "Sala 06",
            "Sala 07",
            "Sala 08",
            "Sala 09",
            "Sala 10",
            "Pátio Principal",
            "Pátio Secundário",
            "Teatro"});
            this.cboLocalSala.Location = new System.Drawing.Point(186, 74);
            this.cboLocalSala.MaxDropDownItems = 6;
            this.cboLocalSala.MaxLength = 100;
            this.cboLocalSala.Name = "cboLocalSala";
            this.cboLocalSala.Size = new System.Drawing.Size(196, 26);
            this.cboLocalSala.TabIndex = 60;
            this.cboLocalSala.TabStop = false;
            this.cboLocalSala.SelectionChangeCommitted += new System.EventHandler(this.cboLocalSala_SelectionChangeCommitted);
            this.cboLocalSala.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cboLocalSala_KeyDown);
            // 
            // dtPickerEmprestimo
            // 
            this.dtPickerEmprestimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtPickerEmprestimo.CustomFormat = "dd/MM/yyyy";
            this.dtPickerEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerEmprestimo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPickerEmprestimo.Location = new System.Drawing.Point(519, 76);
            this.dtPickerEmprestimo.MinDate = new System.DateTime(2019, 11, 1, 0, 0, 0, 0);
            this.dtPickerEmprestimo.Name = "dtPickerEmprestimo";
            this.dtPickerEmprestimo.Size = new System.Drawing.Size(128, 24);
            this.dtPickerEmprestimo.TabIndex = 61;
            this.dtPickerEmprestimo.TabStop = false;
            this.dtPickerEmprestimo.Value = new System.DateTime(2019, 11, 11, 0, 0, 0, 0);
            this.dtPickerEmprestimo.ValueChanged += new System.EventHandler(this.DtPickerEmprestimo_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(430, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 18);
            this.label3.TabIndex = 62;
            this.label3.Text = "Devolução:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 109);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 18);
            this.label6.TabIndex = 63;
            this.label6.Text = "Descrição:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(186, 106);
            this.txtDescricao.MaxLength = 100;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricao.Size = new System.Drawing.Size(461, 61);
            this.txtDescricao.TabIndex = 64;
            this.txtDescricao.TabStop = false;
            this.txtDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDescricao_KeyDown);
            // 
            // dataGridEquipamento
            // 
            this.dataGridEquipamento.AllowUserToAddRows = false;
            this.dataGridEquipamento.AllowUserToDeleteRows = false;
            this.dataGridEquipamento.AllowUserToResizeColumns = false;
            this.dataGridEquipamento.AllowUserToResizeRows = false;
            this.dataGridEquipamento.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEquipamento.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridEquipamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEquipamento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDEquip,
            this.TipoEquip,
            this.AddEquip});
            this.dataGridEquipamento.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEquipamento.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridEquipamento.Location = new System.Drawing.Point(12, 221);
            this.dataGridEquipamento.Name = "dataGridEquipamento";
            this.dataGridEquipamento.ReadOnly = true;
            this.dataGridEquipamento.RowHeadersVisible = false;
            this.dataGridEquipamento.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridEquipamento.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEquipamento.Size = new System.Drawing.Size(370, 250);
            this.dataGridEquipamento.TabIndex = 65;
            this.dataGridEquipamento.TabStop = false;
            this.dataGridEquipamento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridEquipamento_CellContentClick);
            this.dataGridEquipamento.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridEquipamento_CellFormatting);
            this.dataGridEquipamento.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridEquipamento_CellMouseEnter);
            this.dataGridEquipamento.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridEquipamento_CellMouseLeave);
            this.dataGridEquipamento.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DataGridEquipamento_CellPainting);
            // 
            // IDEquip
            // 
            this.IDEquip.DataPropertyName = "ID";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDEquip.DefaultCellStyle = dataGridViewCellStyle2;
            this.IDEquip.HeaderText = "ID";
            this.IDEquip.Name = "IDEquip";
            this.IDEquip.ReadOnly = true;
            this.IDEquip.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IDEquip.Width = 70;
            // 
            // TipoEquip
            // 
            this.TipoEquip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TipoEquip.DataPropertyName = "tipo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TipoEquip.DefaultCellStyle = dataGridViewCellStyle3;
            this.TipoEquip.HeaderText = "Tipo Equipamento";
            this.TipoEquip.MaxInputLength = 30;
            this.TipoEquip.Name = "TipoEquip";
            this.TipoEquip.ReadOnly = true;
            this.TipoEquip.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // AddEquip
            // 
            this.AddEquip.DataPropertyName = "Add";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.AddEquip.DefaultCellStyle = dataGridViewCellStyle4;
            this.AddEquip.HeaderText = "Add";
            this.AddEquip.Name = "AddEquip";
            this.AddEquip.ReadOnly = true;
            this.AddEquip.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.AddEquip.Text = "";
            this.AddEquip.UseColumnTextForButtonValue = true;
            this.AddEquip.Width = 55;
            // 
            // dataGridEmprestimo
            // 
            this.dataGridEmprestimo.AllowUserToAddRows = false;
            this.dataGridEmprestimo.AllowUserToDeleteRows = false;
            this.dataGridEmprestimo.AllowUserToResizeColumns = false;
            this.dataGridEmprestimo.AllowUserToResizeRows = false;
            this.dataGridEmprestimo.BackgroundColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEmprestimo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridEmprestimo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridEmprestimo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDEmpre,
            this.tipoEmpre,
            this.ExcluirEmpre});
            this.dataGridEmprestimo.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridEmprestimo.DefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridEmprestimo.Location = new System.Drawing.Point(405, 221);
            this.dataGridEmprestimo.Name = "dataGridEmprestimo";
            this.dataGridEmprestimo.ReadOnly = true;
            this.dataGridEmprestimo.RowHeadersVisible = false;
            this.dataGridEmprestimo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridEmprestimo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridEmprestimo.Size = new System.Drawing.Size(370, 250);
            this.dataGridEmprestimo.TabIndex = 66;
            this.dataGridEmprestimo.TabStop = false;
            this.dataGridEmprestimo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridEmprestimo_CellContentClick);
            this.dataGridEmprestimo.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridEmprestimo_CellFormatting);
            this.dataGridEmprestimo.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridEmprestimo_CellMouseEnter);
            this.dataGridEmprestimo.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridEmprestimo_CellMouseLeave);
            this.dataGridEmprestimo.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.DataGridEmprestimo_CellPainting);
            this.dataGridEmprestimo.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridEmprestimo_RowEnter);
            // 
            // IDEmpre
            // 
            this.IDEmpre.DataPropertyName = "ID";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDEmpre.DefaultCellStyle = dataGridViewCellStyle7;
            this.IDEmpre.HeaderText = " ID";
            this.IDEmpre.Name = "IDEmpre";
            this.IDEmpre.ReadOnly = true;
            this.IDEmpre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.IDEmpre.Width = 70;
            // 
            // tipoEmpre
            // 
            this.tipoEmpre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipoEmpre.DataPropertyName = "tipo";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoEmpre.DefaultCellStyle = dataGridViewCellStyle8;
            this.tipoEmpre.HeaderText = "Tipo Equipamento";
            this.tipoEmpre.MaxInputLength = 30;
            this.tipoEmpre.Name = "tipoEmpre";
            this.tipoEmpre.ReadOnly = true;
            this.tipoEmpre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ExcluirEmpre
            // 
            this.ExcluirEmpre.DataPropertyName = "excluir";
            this.ExcluirEmpre.HeaderText = "Excluir";
            this.ExcluirEmpre.Name = "ExcluirEmpre";
            this.ExcluirEmpre.ReadOnly = true;
            this.ExcluirEmpre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ExcluirEmpre.Text = "";
            this.ExcluirEmpre.UseColumnTextForButtonValue = true;
            this.ExcluirEmpre.Width = 55;
            // 
            // errorProviderLocal
            // 
            this.errorProviderLocal.ContainerControl = this;
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
            // errorProviderDatagrid
            // 
            this.errorProviderDatagrid.ContainerControl = this;
            // 
            // RealizarEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(787, 483);
            this.Controls.Add(this.dataGridEmprestimo);
            this.Controls.Add(this.dataGridEquipamento);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtPickerEmprestimo);
            this.Controls.Add(this.cboLocalSala);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCargo);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RealizarEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Realizar Emprestimos";
            this.Load += new System.EventHandler(this.RealizarEmprestimo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEquipamento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridEmprestimo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLocal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtCargo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboLocalSala;
        private System.Windows.Forms.DateTimePicker dtPickerEmprestimo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DataGridView dataGridEquipamento;
        private System.Windows.Forms.DataGridView dataGridEmprestimo;
        private System.Windows.Forms.ErrorProvider errorProviderLocal;
        private System.Windows.Forms.ToolTip toolTipVoltar;
        private System.Windows.Forms.ToolTip toolTipSalvar;
        private System.Windows.Forms.ErrorProvider errorProviderDatagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEquip;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoEquip;
        private System.Windows.Forms.DataGridViewButtonColumn AddEquip;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDEmpre;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoEmpre;
        private System.Windows.Forms.DataGridViewButtonColumn ExcluirEmpre;
    }
}