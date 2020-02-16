namespace View
{
    partial class TelaDependente
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
            this.txtDataNasc = new System.Windows.Forms.MaskedTextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.dataGridDependentes = new System.Windows.Forms.DataGridView();
            this.columnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnDataNasc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdSocio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNomeDep = new System.Windows.Forms.TextBox();
            this.txtIdDep = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDependentes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDataNasc
            // 
            this.txtDataNasc.Location = new System.Drawing.Point(375, 45);
            this.txtDataNasc.Mask = "00/00/0000";
            this.txtDataNasc.Name = "txtDataNasc";
            this.txtDataNasc.Size = new System.Drawing.Size(88, 20);
            this.txtDataNasc.TabIndex = 22;
            this.txtDataNasc.ValidatingType = typeof(System.DateTime);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancelar.Location = new System.Drawing.Point(474, 257);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(87, 32);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeletar.Location = new System.Drawing.Point(474, 219);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(87, 32);
            this.btnDeletar.TabIndex = 20;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAtualizar.Location = new System.Drawing.Point(474, 181);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(87, 32);
            this.btnAtualizar.TabIndex = 19;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCadastrar.Location = new System.Drawing.Point(474, 143);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(87, 32);
            this.btnCadastrar.TabIndex = 18;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // dataGridDependentes
            // 
            this.dataGridDependentes.AllowUserToAddRows = false;
            this.dataGridDependentes.AllowUserToDeleteRows = false;
            this.dataGridDependentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDependentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnId,
            this.columnNome,
            this.columnDataNasc,
            this.columnIdSocio});
            this.dataGridDependentes.Location = new System.Drawing.Point(32, 89);
            this.dataGridDependentes.Name = "dataGridDependentes";
            this.dataGridDependentes.ReadOnly = true;
            this.dataGridDependentes.Size = new System.Drawing.Size(423, 233);
            this.dataGridDependentes.TabIndex = 17;
            this.dataGridDependentes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDependentes_CellDoubleClick);
            // 
            // columnId
            // 
            this.columnId.DataPropertyName = "id";
            this.columnId.HeaderText = "Id";
            this.columnId.Name = "columnId";
            this.columnId.ReadOnly = true;
            this.columnId.Width = 50;
            // 
            // columnNome
            // 
            this.columnNome.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.columnNome.DataPropertyName = "nome";
            this.columnNome.HeaderText = "Nome";
            this.columnNome.Name = "columnNome";
            this.columnNome.ReadOnly = true;
            // 
            // columnDataNasc
            // 
            this.columnDataNasc.DataPropertyName = "dataNasc";
            this.columnDataNasc.HeaderText = "Data de Nascimento";
            this.columnDataNasc.Name = "columnDataNasc";
            this.columnDataNasc.ReadOnly = true;
            // 
            // columnIdSocio
            // 
            this.columnIdSocio.DataPropertyName = "idSocio";
            this.columnIdSocio.HeaderText = "Id Sócio";
            this.columnIdSocio.Name = "columnIdSocio";
            this.columnIdSocio.ReadOnly = true;
            this.columnIdSocio.Visible = false;
            this.columnIdSocio.Width = 50;
            // 
            // txtNomeDep
            // 
            this.txtNomeDep.Location = new System.Drawing.Point(93, 45);
            this.txtNomeDep.Name = "txtNomeDep";
            this.txtNomeDep.Size = new System.Drawing.Size(258, 20);
            this.txtNomeDep.TabIndex = 16;
            // 
            // txtIdDep
            // 
            this.txtIdDep.Location = new System.Drawing.Point(32, 45);
            this.txtIdDep.Name = "txtIdDep";
            this.txtIdDep.Size = new System.Drawing.Size(37, 20);
            this.txtIdDep.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(372, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Data de Nascimento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(90, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(29, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Id";
            // 
            // TelaDependente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 349);
            this.Controls.Add(this.txtDataNasc);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.dataGridDependentes);
            this.Controls.Add(this.txtNomeDep);
            this.Controls.Add(this.txtIdDep);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaDependente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaDependente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TelaDependente_FormClosing);
            this.Load += new System.EventHandler(this.TelaDependente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDependentes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox txtDataNasc;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.DataGridView dataGridDependentes;
        private System.Windows.Forms.TextBox txtNomeDep;
        private System.Windows.Forms.TextBox txtIdDep;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnDataNasc;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdSocio;
    }
}