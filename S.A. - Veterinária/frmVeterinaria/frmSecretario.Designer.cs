namespace frmVeterinaria
{
    partial class FrmSecretario
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
            this.btnCadCliente = new System.Windows.Forms.Button();
            this.btnCadAnimal = new System.Windows.Forms.Button();
            this.btnCadVeterinario = new System.Windows.Forms.Button();
            this.btnCadEspecie = new System.Windows.Forms.Button();
            this.btnExames = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.animalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.examesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veterinárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadCliente
            // 
            this.btnCadCliente.Location = new System.Drawing.Point(12, 62);
            this.btnCadCliente.Name = "btnCadCliente";
            this.btnCadCliente.Size = new System.Drawing.Size(130, 23);
            this.btnCadCliente.TabIndex = 0;
            this.btnCadCliente.Text = "Cadastrar Cliente";
            this.btnCadCliente.UseVisualStyleBackColor = true;
            this.btnCadCliente.Click += new System.EventHandler(this.btnCadCliente_Click);
            // 
            // btnCadAnimal
            // 
            this.btnCadAnimal.Location = new System.Drawing.Point(148, 62);
            this.btnCadAnimal.Name = "btnCadAnimal";
            this.btnCadAnimal.Size = new System.Drawing.Size(130, 23);
            this.btnCadAnimal.TabIndex = 1;
            this.btnCadAnimal.Text = "Cadastrar Animal";
            this.btnCadAnimal.UseVisualStyleBackColor = true;
            // 
            // btnCadVeterinario
            // 
            this.btnCadVeterinario.Location = new System.Drawing.Point(12, 107);
            this.btnCadVeterinario.Name = "btnCadVeterinario";
            this.btnCadVeterinario.Size = new System.Drawing.Size(130, 23);
            this.btnCadVeterinario.TabIndex = 2;
            this.btnCadVeterinario.Text = "Cadastrar Veterinário";
            this.btnCadVeterinario.UseVisualStyleBackColor = true;
            // 
            // btnCadEspecie
            // 
            this.btnCadEspecie.Location = new System.Drawing.Point(148, 107);
            this.btnCadEspecie.Name = "btnCadEspecie";
            this.btnCadEspecie.Size = new System.Drawing.Size(130, 23);
            this.btnCadEspecie.TabIndex = 3;
            this.btnCadEspecie.Text = "Cadastrar Espécie";
            this.btnCadEspecie.UseVisualStyleBackColor = true;
            // 
            // btnExames
            // 
            this.btnExames.Location = new System.Drawing.Point(12, 145);
            this.btnExames.Name = "btnExames";
            this.btnExames.Size = new System.Drawing.Size(130, 23);
            this.btnExames.TabIndex = 4;
            this.btnExames.Text = "Exames";
            this.btnExames.UseVisualStyleBackColor = true;
            // 
            // btnConsultas
            // 
            this.btnConsultas.Location = new System.Drawing.Point(148, 145);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(130, 23);
            this.btnConsultas.TabIndex = 5;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.animalToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.exameToolStripMenuItem,
            this.examesToolStripMenuItem,
            this.veterinárioToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.clienteToolStripMenuItem.Text = "Animal";
            // 
            // animalToolStripMenuItem
            // 
            this.animalToolStripMenuItem.Name = "animalToolStripMenuItem";
            this.animalToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.animalToolStripMenuItem.Text = "Cliente";
            this.animalToolStripMenuItem.Click += new System.EventHandler(this.animalToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // exameToolStripMenuItem
            // 
            this.exameToolStripMenuItem.Name = "exameToolStripMenuItem";
            this.exameToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exameToolStripMenuItem.Text = "Espécie";
            // 
            // examesToolStripMenuItem
            // 
            this.examesToolStripMenuItem.Name = "examesToolStripMenuItem";
            this.examesToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.examesToolStripMenuItem.Text = "Exames";
            // 
            // veterinárioToolStripMenuItem
            // 
            this.veterinárioToolStripMenuItem.Name = "veterinárioToolStripMenuItem";
            this.veterinárioToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.veterinárioToolStripMenuItem.Text = "Veterinário";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // FrmSecretario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnConsultas);
            this.Controls.Add(this.btnExames);
            this.Controls.Add(this.btnCadEspecie);
            this.Controls.Add(this.btnCadVeterinario);
            this.Controls.Add(this.btnCadAnimal);
            this.Controls.Add(this.btnCadCliente);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmSecretario";
            this.Text = "frmSecretaria";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadCliente;
        private System.Windows.Forms.Button btnCadAnimal;
        private System.Windows.Forms.Button btnCadVeterinario;
        private System.Windows.Forms.Button btnCadEspecie;
        private System.Windows.Forms.Button btnExames;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem examesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veterinárioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}