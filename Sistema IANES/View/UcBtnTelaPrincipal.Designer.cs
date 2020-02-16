namespace Sistema
{
    partial class UcBtnTelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcBtnTelaPrincipal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnFuncionario = new System.Windows.Forms.Button();
            this.btnRequisitante = new System.Windows.Forms.Button();
            this.btnEmprestimo = new System.Windows.Forms.Button();
            this.btnEquipamento = new System.Windows.Forms.Button();
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
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // btnFuncionario
            // 
            this.btnFuncionario.BackColor = System.Drawing.Color.DarkGray;
            this.btnFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFuncionario.Image = global::Sistema.Properties.Resources.Icone_Funcionario3;
            this.btnFuncionario.Location = new System.Drawing.Point(9, 253);
            this.btnFuncionario.Name = "btnFuncionario";
            this.btnFuncionario.Size = new System.Drawing.Size(174, 49);
            this.btnFuncionario.TabIndex = 1;
            this.btnFuncionario.TabStop = false;
            this.btnFuncionario.Text = "     Gerenciar       Funcionário";
            this.btnFuncionario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFuncionario.UseVisualStyleBackColor = true;
            this.btnFuncionario.Click += new System.EventHandler(this.BtnFuncionario_Click);
            // 
            // btnRequisitante
            // 
            this.btnRequisitante.BackColor = System.Drawing.Color.DarkGray;
            this.btnRequisitante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequisitante.Image = global::Sistema.Properties.Resources.icone_requisitante_32_magro;
            this.btnRequisitante.Location = new System.Drawing.Point(9, 308);
            this.btnRequisitante.Name = "btnRequisitante";
            this.btnRequisitante.Size = new System.Drawing.Size(174, 49);
            this.btnRequisitante.TabIndex = 2;
            this.btnRequisitante.TabStop = false;
            this.btnRequisitante.Text = "     Gerenciar       Requisitante";
            this.btnRequisitante.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRequisitante.UseVisualStyleBackColor = true;
            this.btnRequisitante.Click += new System.EventHandler(this.BtnRequisitante_Click);
            // 
            // btnEmprestimo
            // 
            this.btnEmprestimo.BackColor = System.Drawing.Color.DarkGray;
            this.btnEmprestimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprestimo.Image = global::Sistema.Properties.Resources.Icone_Emprestimo;
            this.btnEmprestimo.Location = new System.Drawing.Point(9, 418);
            this.btnEmprestimo.Name = "btnEmprestimo";
            this.btnEmprestimo.Size = new System.Drawing.Size(174, 49);
            this.btnEmprestimo.TabIndex = 4;
            this.btnEmprestimo.TabStop = false;
            this.btnEmprestimo.Text = "     Gerenciar       Empréstimo";
            this.btnEmprestimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEmprestimo.UseVisualStyleBackColor = true;
            this.btnEmprestimo.Click += new System.EventHandler(this.BtnEmprestimo_Click);
            // 
            // btnEquipamento
            // 
            this.btnEquipamento.BackColor = System.Drawing.Color.DarkGray;
            this.btnEquipamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEquipamento.Image = global::Sistema.Properties.Resources.Icone_Equipamento;
            this.btnEquipamento.Location = new System.Drawing.Point(9, 363);
            this.btnEquipamento.Name = "btnEquipamento";
            this.btnEquipamento.Size = new System.Drawing.Size(174, 49);
            this.btnEquipamento.TabIndex = 3;
            this.btnEquipamento.TabStop = false;
            this.btnEquipamento.Text = "     Gerenciar       Equipamento";
            this.btnEquipamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEquipamento.UseVisualStyleBackColor = true;
            this.btnEquipamento.Click += new System.EventHandler(this.BtnEquipamento_Click);
            // 
            // UcBtnTelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnFuncionario);
            this.Controls.Add(this.btnRequisitante);
            this.Controls.Add(this.btnEmprestimo);
            this.Controls.Add(this.btnEquipamento);
            this.Name = "UcBtnTelaPrincipal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Size = new System.Drawing.Size(192, 498);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnFuncionario;
        private System.Windows.Forms.Button btnRequisitante;
        private System.Windows.Forms.Button btnEmprestimo;
        private System.Windows.Forms.Button btnEquipamento;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
