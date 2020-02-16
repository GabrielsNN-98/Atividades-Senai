namespace frmVeterinaria
{
    partial class FrmVeterinaria
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
            this.btnMarcarConsulta = new System.Windows.Forms.Button();
            this.btnMarcarExame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMarcarConsulta
            // 
            this.btnMarcarConsulta.Location = new System.Drawing.Point(87, 135);
            this.btnMarcarConsulta.Name = "btnMarcarConsulta";
            this.btnMarcarConsulta.Size = new System.Drawing.Size(100, 23);
            this.btnMarcarConsulta.TabIndex = 0;
            this.btnMarcarConsulta.Text = "Marcar Consulta";
            this.btnMarcarConsulta.UseVisualStyleBackColor = true;
            this.btnMarcarConsulta.Click += new System.EventHandler(this.btnMarcarConsulta_Click);
            // 
            // btnMarcarExame
            // 
            this.btnMarcarExame.Location = new System.Drawing.Point(87, 78);
            this.btnMarcarExame.Name = "btnMarcarExame";
            this.btnMarcarExame.Size = new System.Drawing.Size(100, 23);
            this.btnMarcarExame.TabIndex = 1;
            this.btnMarcarExame.Text = "Marcar Exame";
            this.btnMarcarExame.UseVisualStyleBackColor = true;
            // 
            // FrmVeterinaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnMarcarExame);
            this.Controls.Add(this.btnMarcarConsulta);
            this.Name = "FrmVeterinaria";
            this.Text = "FrmVeterinaria";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMarcarConsulta;
        private System.Windows.Forms.Button btnMarcarExame;
    }
}