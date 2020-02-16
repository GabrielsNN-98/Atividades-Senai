namespace Sistema
{
    partial class FormTelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTelaPrincipal));
            this.PnlBtnTelaPrincipal = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PnlTelaPrincipal = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.PnlBtnTelaPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlBtnTelaPrincipal
            // 
            this.PnlBtnTelaPrincipal.Controls.Add(this.panel2);
            this.PnlBtnTelaPrincipal.Cursor = System.Windows.Forms.Cursors.Default;
            this.PnlBtnTelaPrincipal.Dock = System.Windows.Forms.DockStyle.Left;
            this.PnlBtnTelaPrincipal.Location = new System.Drawing.Point(0, 0);
            this.PnlBtnTelaPrincipal.Name = "PnlBtnTelaPrincipal";
            this.PnlBtnTelaPrincipal.Size = new System.Drawing.Size(192, 498);
            this.PnlBtnTelaPrincipal.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(198, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 3;
            // 
            // PnlTelaPrincipal
            // 
            this.PnlTelaPrincipal.Location = new System.Drawing.Point(198, 0);
            this.PnlTelaPrincipal.Name = "PnlTelaPrincipal";
            this.PnlTelaPrincipal.Size = new System.Drawing.Size(719, 498);
            this.PnlTelaPrincipal.TabIndex = 2;
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.Gray;
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnVoltar.Image = global::Sistema.Properties.Resources.Icone_voltar1;
            this.btnVoltar.Location = new System.Drawing.Point(28, 4);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(135, 23);
            this.btnVoltar.TabIndex = 1;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Visible = false;
            this.btnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // FormTelaPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(912, 498);
            this.Controls.Add(this.PnlTelaPrincipal);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.PnlBtnTelaPrincipal);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormTelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "";
            this.Text = "Faculdade IANES";
            this.Load += new System.EventHandler(this.FormTelaPrincipal_Load);
            this.PnlBtnTelaPrincipal.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PnlBtnTelaPrincipal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PnlTelaPrincipal;
        private System.Windows.Forms.Button btnVoltar;
    }
}