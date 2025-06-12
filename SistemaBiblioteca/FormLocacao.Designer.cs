namespace SistemaBiblioteca
{
    partial class FormLocacao
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
            this.cmbLivros = new System.Windows.Forms.ComboBox();
            this.cmbUsuarios = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpLocacao = new System.Windows.Forms.DateTimePicker();
            this.dtpDataLocacao = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpDataEntregaPrevista = new System.Windows.Forms.DateTimePicker();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vamos locar um livro:";
            // 
            // cmbLivros
            // 
            this.cmbLivros.FormattingEnabled = true;
            this.cmbLivros.Location = new System.Drawing.Point(263, 108);
            this.cmbLivros.Name = "cmbLivros";
            this.cmbLivros.Size = new System.Drawing.Size(179, 21);
            this.cmbLivros.TabIndex = 1;
            this.cmbLivros.SelectedIndexChanged += new System.EventHandler(this.cmbLivros_SelectedIndexChanged);
            // 
            // cmbUsuarios
            // 
            this.cmbUsuarios.FormattingEnabled = true;
            this.cmbUsuarios.Location = new System.Drawing.Point(263, 165);
            this.cmbUsuarios.Name = "cmbUsuarios";
            this.cmbUsuarios.Size = new System.Drawing.Size(179, 21);
            this.cmbUsuarios.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(330, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Livro:";
            // 
            // dtpLocacao
            // 
            this.dtpLocacao.Location = new System.Drawing.Point(263, 221);
            this.dtpLocacao.MaxDate = new System.DateTime(2025, 6, 12, 0, 0, 0, 0);
            this.dtpLocacao.Name = "dtpLocacao";
            this.dtpLocacao.Size = new System.Drawing.Size(178, 20);
            this.dtpLocacao.TabIndex = 5;
            this.dtpLocacao.Value = new System.DateTime(2025, 6, 12, 0, 0, 0, 0);
            // 
            // dtpDataLocacao
            // 
            this.dtpDataLocacao.AutoSize = true;
            this.dtpDataLocacao.Location = new System.Drawing.Point(306, 205);
            this.dtpDataLocacao.Name = "dtpDataLocacao";
            this.dtpDataLocacao.Size = new System.Drawing.Size(93, 13);
            this.dtpDataLocacao.TabIndex = 6;
            this.dtpDataLocacao.Text = "Data da Locação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Data de Entrega:";
            // 
            // dtpDataEntregaPrevista
            // 
            this.dtpDataEntregaPrevista.Location = new System.Drawing.Point(263, 282);
            this.dtpDataEntregaPrevista.MinDate = new System.DateTime(2025, 6, 12, 0, 0, 0, 0);
            this.dtpDataEntregaPrevista.Name = "dtpDataEntregaPrevista";
            this.dtpDataEntregaPrevista.Size = new System.Drawing.Size(179, 20);
            this.dtpDataEntregaPrevista.TabIndex = 8;
            this.dtpDataEntregaPrevista.Value = new System.DateTime(2025, 6, 12, 0, 0, 0, 0);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(319, 362);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmar.TabIndex = 9;
            this.btnConfirmar.Text = "Locar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // FormLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.dtpDataEntregaPrevista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpDataLocacao);
            this.Controls.Add(this.dtpLocacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbUsuarios);
            this.Controls.Add(this.cmbLivros);
            this.Controls.Add(this.label1);
            this.Name = "FormLocacao";
            this.Text = "FormLocacao";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbLivros;
        private System.Windows.Forms.ComboBox cmbUsuarios;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpLocacao;
        private System.Windows.Forms.Label dtpDataLocacao;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpDataEntregaPrevista;
        private System.Windows.Forms.Button btnConfirmar;
    }
}