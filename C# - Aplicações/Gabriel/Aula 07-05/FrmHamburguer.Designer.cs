namespace Aula_07_05
{
    partial class FrmHamburguer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHamburguer));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBox3 = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.CmbEstado = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GbConheceu = new System.Windows.Forms.GroupBox();
            this.rBtnOutros = new System.Windows.Forms.RadioButton();
            this.rBtnJornal = new System.Windows.Forms.RadioButton();
            this.rBtnTV = new System.Windows.Forms.RadioButton();
            this.rBtnFacebook = new System.Windows.Forms.RadioButton();
            this.GbNewsletter = new System.Windows.Forms.GroupBox();
            this.ChbLigacao = new System.Windows.Forms.CheckBox();
            this.ChbSMS = new System.Windows.Forms.CheckBox();
            this.ChbEmail = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pythonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.delphiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarArquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salvarTodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.GbConheceu.SuspendLayout();
            this.GbNewsletter.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.maskedTextBox3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 122);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Pessoais";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(145, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "CPF";
            // 
            // maskedTextBox3
            // 
            this.maskedTextBox3.Location = new System.Drawing.Point(145, 90);
            this.maskedTextBox3.Mask = "000.000.000-00";
            this.maskedTextBox3.Name = "maskedTextBox3";
            this.maskedTextBox3.Size = new System.Drawing.Size(109, 20);
            this.maskedTextBox3.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Data de Nascimento";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(114, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(248, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.CmbEstado);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(13, 218);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(372, 120);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(199, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Estado";
            // 
            // CmbEstado
            // 
            this.CmbEstado.FormattingEnabled = true;
            this.CmbEstado.Items.AddRange(new object[] {
            "Teste",
            "Acre (AC)",
            "Alagoas (AL)",
            "Amapá (AP)",
            "Amazonas (AM)",
            "Bahia (BA)",
            "Ceará (CE)",
            "Distrito Federal (DF)",
            "Espírito Santo (ES)",
            "Goiás (GO)",
            "Maranhão (MA)",
            "Mato Grosso (MT)",
            "Mato Grosso do Sul (MS)",
            "Minas Gerais (MG)",
            "Pará (PA)",
            "Paraíba (PB)",
            "Paraná (PR)",
            "Pernambuco (PE)",
            "Piauí (PI)",
            "Rio de Janeiro (RJ)",
            "Rio Grande do Norte (RN)",
            "Rio Grande do Sul (RS)",
            "Rondônia (RO)",
            "Roraima (RR)",
            "Santa Catarina (SC)",
            "São Paulo (SP)",
            "Sergipe (SE)",
            "Tocantins (TO)"});
            this.CmbEstado.Location = new System.Drawing.Point(202, 81);
            this.CmbEstado.Name = "CmbEstado";
            this.CmbEstado.Size = new System.Drawing.Size(160, 21);
            this.CmbEstado.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(116, 81);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(71, 20);
            this.textBox5.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(116, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Complemento";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(11, 81);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(89, 20);
            this.textBox4.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(11, 65);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Número";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(11, 39);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(351, 20);
            this.textBox3.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Rua";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.maskedTextBox2);
            this.groupBox3.Controls.Add(this.maskedTextBox1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(282, 81);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(217, 122);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = " Contato ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(9, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(202, 20);
            this.textBox2.TabIndex = 6;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(127, 43);
            this.maskedTextBox2.Mask = "(99) 0000-0000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(84, 20);
            this.maskedTextBox2.TabIndex = 5;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(9, 43);
            this.maskedTextBox1.Mask = "(99) 0000-0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(94, 20);
            this.maskedTextBox1.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Celular";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Telefone";
            // 
            // GbConheceu
            // 
            this.GbConheceu.Controls.Add(this.rBtnOutros);
            this.GbConheceu.Controls.Add(this.rBtnJornal);
            this.GbConheceu.Controls.Add(this.rBtnTV);
            this.GbConheceu.Controls.Add(this.rBtnFacebook);
            this.GbConheceu.Location = new System.Drawing.Point(392, 218);
            this.GbConheceu.Name = "GbConheceu";
            this.GbConheceu.Size = new System.Drawing.Size(107, 120);
            this.GbConheceu.TabIndex = 4;
            this.GbConheceu.TabStop = false;
            this.GbConheceu.Text = " Como nos conheceu? ";
            // 
            // rBtnOutros
            // 
            this.rBtnOutros.AutoSize = true;
            this.rBtnOutros.Location = new System.Drawing.Point(8, 94);
            this.rBtnOutros.Name = "rBtnOutros";
            this.rBtnOutros.Size = new System.Drawing.Size(56, 17);
            this.rBtnOutros.TabIndex = 3;
            this.rBtnOutros.TabStop = true;
            this.rBtnOutros.Text = "Outros";
            this.rBtnOutros.UseVisualStyleBackColor = true;
            // 
            // rBtnJornal
            // 
            this.rBtnJornal.AutoSize = true;
            this.rBtnJornal.Location = new System.Drawing.Point(8, 75);
            this.rBtnJornal.Name = "rBtnJornal";
            this.rBtnJornal.Size = new System.Drawing.Size(53, 17);
            this.rBtnJornal.TabIndex = 2;
            this.rBtnJornal.TabStop = true;
            this.rBtnJornal.Text = "Jornal";
            this.rBtnJornal.UseVisualStyleBackColor = true;
            // 
            // rBtnTV
            // 
            this.rBtnTV.AutoSize = true;
            this.rBtnTV.Location = new System.Drawing.Point(8, 55);
            this.rBtnTV.Name = "rBtnTV";
            this.rBtnTV.Size = new System.Drawing.Size(73, 17);
            this.rBtnTV.TabIndex = 1;
            this.rBtnTV.TabStop = true;
            this.rBtnTV.Text = "TV Aberta";
            this.rBtnTV.UseVisualStyleBackColor = true;
            // 
            // rBtnFacebook
            // 
            this.rBtnFacebook.AutoSize = true;
            this.rBtnFacebook.Location = new System.Drawing.Point(8, 35);
            this.rBtnFacebook.Name = "rBtnFacebook";
            this.rBtnFacebook.Size = new System.Drawing.Size(73, 17);
            this.rBtnFacebook.TabIndex = 0;
            this.rBtnFacebook.TabStop = true;
            this.rBtnFacebook.Text = "Facebook";
            this.rBtnFacebook.UseVisualStyleBackColor = true;
            // 
            // GbNewsletter
            // 
            this.GbNewsletter.Controls.Add(this.ChbLigacao);
            this.GbNewsletter.Controls.Add(this.ChbSMS);
            this.GbNewsletter.Controls.Add(this.ChbEmail);
            this.GbNewsletter.Controls.Add(this.label11);
            this.GbNewsletter.Location = new System.Drawing.Point(13, 344);
            this.GbNewsletter.Name = "GbNewsletter";
            this.GbNewsletter.Size = new System.Drawing.Size(486, 52);
            this.GbNewsletter.TabIndex = 5;
            this.GbNewsletter.TabStop = false;
            this.GbNewsletter.Text = "Newsletter";
            // 
            // ChbLigacao
            // 
            this.ChbLigacao.AutoSize = true;
            this.ChbLigacao.Location = new System.Drawing.Point(352, 25);
            this.ChbLigacao.Name = "ChbLigacao";
            this.ChbLigacao.Size = new System.Drawing.Size(64, 17);
            this.ChbLigacao.TabIndex = 4;
            this.ChbLigacao.Text = "Ligação";
            this.ChbLigacao.UseVisualStyleBackColor = true;
            // 
            // ChbSMS
            // 
            this.ChbSMS.AutoSize = true;
            this.ChbSMS.Location = new System.Drawing.Point(287, 25);
            this.ChbSMS.Name = "ChbSMS";
            this.ChbSMS.Size = new System.Drawing.Size(49, 17);
            this.ChbSMS.TabIndex = 3;
            this.ChbSMS.Text = "SMS";
            this.ChbSMS.UseVisualStyleBackColor = true;
            // 
            // ChbEmail
            // 
            this.ChbEmail.AutoSize = true;
            this.ChbEmail.Location = new System.Drawing.Point(217, 25);
            this.ChbEmail.Name = "ChbEmail";
            this.ChbEmail.Size = new System.Drawing.Size(54, 17);
            this.ChbEmail.TabIndex = 2;
            this.ChbEmail.Text = "E-mail";
            this.ChbEmail.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(8, 26);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(195, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Deseja receber nossas informações via:";
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("BtnSalvar.Image")));
            this.BtnSalvar.Location = new System.Drawing.Point(71, 32);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(52, 43);
            this.BtnSalvar.TabIndex = 6;
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(189, 35);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 37);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(356, 32);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 37);
            this.button3.TabIndex = 8;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.salvarToolStripMenuItem1,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(511, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem,
            this.salvarToolStripMenuItem,
            this.fecharToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pythonToolStripMenuItem,
            this.cToolStripMenuItem,
            this.delphiToolStripMenuItem});
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.novoToolStripMenuItem.Text = "Novo";
            // 
            // pythonToolStripMenuItem
            // 
            this.pythonToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.pythonToolStripMenuItem.Name = "pythonToolStripMenuItem";
            this.pythonToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.pythonToolStripMenuItem.Text = "python";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(89, 22);
            this.toolStripMenuItem2.Text = "2.7";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(89, 22);
            this.toolStripMenuItem3.Text = "3.7";
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.cToolStripMenuItem.Text = "c";
            // 
            // delphiToolStripMenuItem
            // 
            this.delphiToolStripMenuItem.Name = "delphiToolStripMenuItem";
            this.delphiToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.delphiToolStripMenuItem.Text = "delphi";
            // 
            // salvarToolStripMenuItem
            // 
            this.salvarToolStripMenuItem.Name = "salvarToolStripMenuItem";
            this.salvarToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.salvarToolStripMenuItem.Text = "Salvar";
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
            // 
            // salvarToolStripMenuItem1
            // 
            this.salvarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salvarArquivoToolStripMenuItem,
            this.salvarTodosToolStripMenuItem});
            this.salvarToolStripMenuItem1.Name = "salvarToolStripMenuItem1";
            this.salvarToolStripMenuItem1.Size = new System.Drawing.Size(50, 20);
            this.salvarToolStripMenuItem1.Text = "Salvar";
            // 
            // salvarArquivoToolStripMenuItem
            // 
            this.salvarArquivoToolStripMenuItem.Name = "salvarArquivoToolStripMenuItem";
            this.salvarArquivoToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.salvarArquivoToolStripMenuItem.Text = "Salvar Arquivo";
            // 
            // salvarTodosToolStripMenuItem
            // 
            this.salvarTodosToolStripMenuItem.Name = "salvarTodosToolStripMenuItem";
            this.salvarTodosToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.salvarTodosToolStripMenuItem.Text = "Salvar Todos";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // FrmHamburguer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 410);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.GbNewsletter);
            this.Controls.Add(this.GbConheceu);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmHamburguer";
            this.Text = "Hamburgueria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.GbConheceu.ResumeLayout(false);
            this.GbConheceu.PerformLayout();
            this.GbNewsletter.ResumeLayout(false);
            this.GbNewsletter.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox CmbEstado;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox GbConheceu;
        private System.Windows.Forms.RadioButton rBtnOutros;
        private System.Windows.Forms.RadioButton rBtnJornal;
        private System.Windows.Forms.RadioButton rBtnTV;
        private System.Windows.Forms.RadioButton rBtnFacebook;
        private System.Windows.Forms.GroupBox GbNewsletter;
        private System.Windows.Forms.CheckBox ChbEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox ChbLigacao;
        private System.Windows.Forms.CheckBox ChbSMS;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pythonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem delphiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem salvarArquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salvarTodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}

