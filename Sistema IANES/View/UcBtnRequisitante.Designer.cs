namespace Sistema
{
    partial class UcBtnRequisitante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcBtnRequisitante));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPesquisarEquip = new System.Windows.Forms.Button();
            this.btnAddEquip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // btnPesquisarEquip
            // 
            this.btnPesquisarEquip.BackColor = System.Drawing.Color.DarkGray;
            this.btnPesquisarEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarEquip.Location = new System.Drawing.Point(9, 332);
            this.btnPesquisarEquip.Name = "btnPesquisarEquip";
            this.btnPesquisarEquip.Size = new System.Drawing.Size(174, 49);
            this.btnPesquisarEquip.TabIndex = 21;
            this.btnPesquisarEquip.TabStop = false;
            this.btnPesquisarEquip.Text = "       Pesquisar         Requisitantes\r\n";
            this.btnPesquisarEquip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisarEquip.UseVisualStyleBackColor = true;
            this.btnPesquisarEquip.Click += new System.EventHandler(this.BtnPesquisarEquip_Click);
            // 
            // btnAddEquip
            // 
            this.btnAddEquip.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddEquip.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEquip.Location = new System.Drawing.Point(9, 277);
            this.btnAddEquip.Name = "btnAddEquip";
            this.btnAddEquip.Size = new System.Drawing.Size(174, 49);
            this.btnAddEquip.TabIndex = 20;
            this.btnAddEquip.TabStop = false;
            this.btnAddEquip.Text = "       Adicionar         Requisitantes";
            this.btnAddEquip.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddEquip.UseVisualStyleBackColor = true;
            this.btnAddEquip.Click += new System.EventHandler(this.BtnAddEquip_Click);
            // 
            // UcBtnRequisitante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.btnPesquisarEquip);
            this.Controls.Add(this.btnAddEquip);
            this.Controls.Add(this.pictureBox1);
            this.Name = "UcBtnRequisitante";
            this.Size = new System.Drawing.Size(192, 498);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnPesquisarEquip;
        private System.Windows.Forms.Button btnAddEquip;
    }
}
