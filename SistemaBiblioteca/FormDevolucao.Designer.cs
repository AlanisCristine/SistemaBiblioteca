namespace SistemaBiblioteca
{
    partial class FormDevolucao
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvEmprestados = new System.Windows.Forms.DataGridView();
            this.btnDevolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Devolução";
            // 
            // dgvEmprestados
            // 
            this.dgvEmprestados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmprestados.Location = new System.Drawing.Point(197, 89);
            this.dgvEmprestados.Name = "dgvEmprestados";
            this.dgvEmprestados.Size = new System.Drawing.Size(316, 127);
            this.dgvEmprestados.TabIndex = 1;
            // 
            // btnDevolver
            // 
            this.btnDevolver.Location = new System.Drawing.Point(294, 235);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(145, 32);
            this.btnDevolver.TabIndex = 2;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = true;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // FormDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.dgvEmprestados);
            this.Controls.Add(this.label1);
            this.Name = "FormDevolucao";
            this.Text = "FormDevolucao";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmprestados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvEmprestados;
        private System.Windows.Forms.Button btnDevolver;
    }
}