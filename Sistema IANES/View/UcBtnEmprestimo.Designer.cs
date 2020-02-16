namespace Sistema
{
    partial class UcBtnEmprestimo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcBtnEmprestimo));
            this.btnAddEmprestimo = new System.Windows.Forms.Button();
            this.btnEmprestimosFeitos = new System.Windows.Forms.Button();
            this.btnDevolucao = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddEmprestimo
            // 
            this.btnAddEmprestimo.BackColor = System.Drawing.Color.DarkGray;
            this.btnAddEmprestimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmprestimo.Location = new System.Drawing.Point(9, 253);
            this.btnAddEmprestimo.Name = "btnAddEmprestimo";
            this.btnAddEmprestimo.Size = new System.Drawing.Size(174, 49);
            this.btnAddEmprestimo.TabIndex = 16;
            this.btnAddEmprestimo.TabStop = false;
            this.btnAddEmprestimo.Text = "Realizar Empréstimo";
            this.btnAddEmprestimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddEmprestimo.UseVisualStyleBackColor = true;
            this.btnAddEmprestimo.Click += new System.EventHandler(this.btnAddEmprestimo_Click);
            // 
            // btnEmprestimosFeitos
            // 
            this.btnEmprestimosFeitos.BackColor = System.Drawing.Color.DarkGray;
            this.btnEmprestimosFeitos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmprestimosFeitos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprestimosFeitos.Location = new System.Drawing.Point(9, 308);
            this.btnEmprestimosFeitos.Name = "btnEmprestimosFeitos";
            this.btnEmprestimosFeitos.Size = new System.Drawing.Size(174, 49);
            this.btnEmprestimosFeitos.TabIndex = 17;
            this.btnEmprestimosFeitos.TabStop = false;
            this.btnEmprestimosFeitos.Text = "Pesquisar Empréstimos Feitos";
            this.btnEmprestimosFeitos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmprestimosFeitos.UseVisualStyleBackColor = true;
            this.btnEmprestimosFeitos.Click += new System.EventHandler(this.BtnEmprestimosFeitos_Click);
            // 
            // btnDevolucao
            // 
            this.btnDevolucao.BackColor = System.Drawing.Color.DarkGray;
            this.btnDevolucao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDevolucao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolucao.Location = new System.Drawing.Point(9, 363);
            this.btnDevolucao.Name = "btnDevolucao";
            this.btnDevolucao.Size = new System.Drawing.Size(174, 49);
            this.btnDevolucao.TabIndex = 18;
            this.btnDevolucao.TabStop = false;
            this.btnDevolucao.Text = "Realizar Devolução";
            this.btnDevolucao.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDevolucao.UseVisualStyleBackColor = true;
            this.btnDevolucao.Click += new System.EventHandler(this.BtnDevolucao_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(3, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(186, 139);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // UcBtnEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnDevolucao);
            this.Controls.Add(this.btnEmprestimosFeitos);
            this.Controls.Add(this.btnAddEmprestimo);
            this.Name = "UcBtnEmprestimo";
            this.Size = new System.Drawing.Size(192, 498);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddEmprestimo;
        private System.Windows.Forms.Button btnEmprestimosFeitos;
        private System.Windows.Forms.Button btnDevolucao;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
