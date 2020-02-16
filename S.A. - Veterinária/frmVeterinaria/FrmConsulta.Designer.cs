namespace frmVeterinaria
{
    partial class FrmConsulta
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
            this.lblAnamnese = new System.Windows.Forms.Label();
            this.lblReceituario = new System.Windows.Forms.Label();
            this.rTxtAnamnese = new System.Windows.Forms.RichTextBox();
            this.rTxtReceituario = new System.Windows.Forms.RichTextBox();
            this.cmbAnimal = new System.Windows.Forms.ComboBox();
            this.lblAnimal = new System.Windows.Forms.Label();
            this.lblVeterinario = new System.Windows.Forms.Label();
            this.cmbVet = new System.Windows.Forms.ComboBox();
            this.dtpConsulta = new System.Windows.Forms.DateTimePicker();
            this.lblDataHora = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAnamnese
            // 
            this.lblAnamnese.AutoSize = true;
            this.lblAnamnese.Location = new System.Drawing.Point(12, 57);
            this.lblAnamnese.Name = "lblAnamnese";
            this.lblAnamnese.Size = new System.Drawing.Size(57, 13);
            this.lblAnamnese.TabIndex = 0;
            this.lblAnamnese.Text = "Anamnese";
            // 
            // lblReceituario
            // 
            this.lblReceituario.AutoSize = true;
            this.lblReceituario.Location = new System.Drawing.Point(12, 197);
            this.lblReceituario.Name = "lblReceituario";
            this.lblReceituario.Size = new System.Drawing.Size(61, 13);
            this.lblReceituario.TabIndex = 1;
            this.lblReceituario.Text = "Receituário";
            // 
            // rTxtAnamnese
            // 
            this.rTxtAnamnese.Location = new System.Drawing.Point(79, 21);
            this.rTxtAnamnese.Name = "rTxtAnamnese";
            this.rTxtAnamnese.Size = new System.Drawing.Size(856, 95);
            this.rTxtAnamnese.TabIndex = 2;
            this.rTxtAnamnese.Text = "";
            // 
            // rTxtReceituario
            // 
            this.rTxtReceituario.Location = new System.Drawing.Point(79, 154);
            this.rTxtReceituario.Name = "rTxtReceituario";
            this.rTxtReceituario.Size = new System.Drawing.Size(856, 95);
            this.rTxtReceituario.TabIndex = 3;
            this.rTxtReceituario.Text = "";
            // 
            // cmbAnimal
            // 
            this.cmbAnimal.FormattingEnabled = true;
            this.cmbAnimal.Location = new System.Drawing.Point(141, 332);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.Size = new System.Drawing.Size(121, 21);
            this.cmbAnimal.TabIndex = 4;
            // 
            // lblAnimal
            // 
            this.lblAnimal.AutoSize = true;
            this.lblAnimal.Location = new System.Drawing.Point(55, 335);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(38, 13);
            this.lblAnimal.TabIndex = 5;
            this.lblAnimal.Text = "Animal";
            // 
            // lblVeterinario
            // 
            this.lblVeterinario.AutoSize = true;
            this.lblVeterinario.Location = new System.Drawing.Point(55, 371);
            this.lblVeterinario.Name = "lblVeterinario";
            this.lblVeterinario.Size = new System.Drawing.Size(57, 13);
            this.lblVeterinario.TabIndex = 6;
            this.lblVeterinario.Text = "Veterinário";
            // 
            // cmbVet
            // 
            this.cmbVet.FormattingEnabled = true;
            this.cmbVet.Location = new System.Drawing.Point(141, 368);
            this.cmbVet.Name = "cmbVet";
            this.cmbVet.Size = new System.Drawing.Size(121, 21);
            this.cmbVet.TabIndex = 7;
            // 
            // dtpConsulta
            // 
            this.dtpConsulta.CustomFormat = "00/00/0000 90:00";
            this.dtpConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpConsulta.Location = new System.Drawing.Point(594, 338);
            this.dtpConsulta.Name = "dtpConsulta";
            this.dtpConsulta.Size = new System.Drawing.Size(226, 20);
            this.dtpConsulta.TabIndex = 8;

            // 
            // lblDataHora
            // 
            this.lblDataHora.AutoSize = true;
            this.lblDataHora.Location = new System.Drawing.Point(523, 340);
            this.lblDataHora.Name = "lblDataHora";
            this.lblDataHora.Size = new System.Drawing.Size(65, 13);
            this.lblDataHora.TabIndex = 9;
            this.lblDataHora.Text = "Data e Hora";
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 453);
            this.Controls.Add(this.lblDataHora);
            this.Controls.Add(this.dtpConsulta);
            this.Controls.Add(this.cmbVet);
            this.Controls.Add(this.lblVeterinario);
            this.Controls.Add(this.lblAnimal);
            this.Controls.Add(this.cmbAnimal);
            this.Controls.Add(this.rTxtReceituario);
            this.Controls.Add(this.rTxtAnamnese);
            this.Controls.Add(this.lblReceituario);
            this.Controls.Add(this.lblAnamnese);
            this.Name = "FrmConsulta";
            this.Text = "FrmConsulta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAnamnese;
        private System.Windows.Forms.Label lblReceituario;
        private System.Windows.Forms.RichTextBox rTxtAnamnese;
        private System.Windows.Forms.RichTextBox rTxtReceituario;
        private System.Windows.Forms.ComboBox cmbAnimal;
        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.Label lblVeterinario;
        private System.Windows.Forms.ComboBox cmbVet;
        private System.Windows.Forms.DateTimePicker dtpConsulta;
        private System.Windows.Forms.Label lblDataHora;
    }
}