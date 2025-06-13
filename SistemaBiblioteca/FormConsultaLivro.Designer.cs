namespace SistemaBiblioteca
{
    partial class FormConsultaLivro
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
            this.dgvLivrosDisponibilidade = new System.Windows.Forms.DataGridView();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivrosDisponibilidade)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLivrosDisponibilidade
            // 
            this.dgvLivrosDisponibilidade.AllowUserToAddRows = false;
            this.dgvLivrosDisponibilidade.AllowUserToResizeRows = false;
            this.dgvLivrosDisponibilidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivrosDisponibilidade.Location = new System.Drawing.Point(204, 67);
            this.dgvLivrosDisponibilidade.Name = "dgvLivrosDisponibilidade";
            this.dgvLivrosDisponibilidade.ReadOnly = true;
            this.dgvLivrosDisponibilidade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivrosDisponibilidade.Size = new System.Drawing.Size(405, 156);
            this.dgvLivrosDisponibilidade.TabIndex = 0;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(353, 238);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(107, 31);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(339, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Disponibilidade dos Livros:";
            // 
            // FormConsultaLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dgvLivrosDisponibilidade);
            this.Name = "FormConsultaLivro";
            this.Text = "FormConsultaLivro";
            this.Load += new System.EventHandler(this.FormConsultaLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivrosDisponibilidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLivrosDisponibilidade;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label1;
    }
}