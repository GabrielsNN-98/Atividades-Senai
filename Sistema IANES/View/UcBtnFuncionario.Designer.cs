namespace Sistema
{
    partial class UcBtnFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcBtnFuncionario));
            this.btnAdicionarFuncionario = new System.Windows.Forms.Button();
            this.btnPesquisarFuncionario = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdicionarFuncionario
            // 
            this.btnAdicionarFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnAdicionarFuncionario.Location = new System.Drawing.Point(9, 277);
            this.btnAdicionarFuncionario.Name = "btnAdicionarFuncionario";
            this.btnAdicionarFuncionario.Size = new System.Drawing.Size(174, 49);
            this.btnAdicionarFuncionario.TabIndex = 11;
            this.btnAdicionarFuncionario.TabStop = false;
            this.btnAdicionarFuncionario.Text = "       Adicionar         Funcionário";
            this.btnAdicionarFuncionario.UseVisualStyleBackColor = true;
            this.btnAdicionarFuncionario.Click += new System.EventHandler(this.BtnAdicionarFuncionario_Click);
            // 
            // btnPesquisarFuncionario
            // 
            this.btnPesquisarFuncionario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnPesquisarFuncionario.Location = new System.Drawing.Point(9, 332);
            this.btnPesquisarFuncionario.Name = "btnPesquisarFuncionario";
            this.btnPesquisarFuncionario.Size = new System.Drawing.Size(174, 49);
            this.btnPesquisarFuncionario.TabIndex = 12;
            this.btnPesquisarFuncionario.TabStop = false;
            this.btnPesquisarFuncionario.Text = "       Pesquisar         Funcionário";
            this.btnPesquisarFuncionario.UseVisualStyleBackColor = true;
            this.btnPesquisarFuncionario.Click += new System.EventHandler(this.BtnPesquisarFuncionario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // UcBtnFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.btnPesquisarFuncionario);
            this.Controls.Add(this.btnAdicionarFuncionario);
            this.Controls.Add(this.pictureBox1);
            this.Location = new System.Drawing.Point(30, 0);
            this.Name = "UcBtnFuncionario";
            this.Size = new System.Drawing.Size(192, 498);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAdicionarFuncionario;
        private System.Windows.Forms.Button btnPesquisarFuncionario;
    }
}
