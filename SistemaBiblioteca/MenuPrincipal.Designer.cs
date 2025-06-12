namespace SistemaBiblioteca
{
    partial class MenuPrincipal
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastroLivro = new System.Windows.Forms.Button();
            this.btnCadastroUsuario = new System.Windows.Forms.Button();
            this.btnLocacao = new System.Windows.Forms.Button();
            this.btnConsultaLivro = new System.Windows.Forms.Button();
            this.btnDevolucao = new System.Windows.Forms.Button();
            this.btnConsultaUsuario = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnTesteConexao = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastroLivro
            // 
            this.btnCadastroLivro.Location = new System.Drawing.Point(215, 100);
            this.btnCadastroLivro.Name = "btnCadastroLivro";
            this.btnCadastroLivro.Size = new System.Drawing.Size(317, 31);
            this.btnCadastroLivro.TabIndex = 0;
            this.btnCadastroLivro.Text = "Cadastro de Livro";
            this.btnCadastroLivro.UseVisualStyleBackColor = true;
            this.btnCadastroLivro.Click += new System.EventHandler(this.btnCadastroLivro_Click);
            // 
            // btnCadastroUsuario
            // 
            this.btnCadastroUsuario.Location = new System.Drawing.Point(215, 154);
            this.btnCadastroUsuario.Name = "btnCadastroUsuario";
            this.btnCadastroUsuario.Size = new System.Drawing.Size(316, 30);
            this.btnCadastroUsuario.TabIndex = 1;
            this.btnCadastroUsuario.Text = "Cadastro de Usuário";
            this.btnCadastroUsuario.UseVisualStyleBackColor = true;
            this.btnCadastroUsuario.Click += new System.EventHandler(this.btnCadastroUsuario_Click);
            // 
            // btnLocacao
            // 
            this.btnLocacao.Location = new System.Drawing.Point(218, 203);
            this.btnLocacao.Name = "btnLocacao";
            this.btnLocacao.Size = new System.Drawing.Size(314, 30);
            this.btnLocacao.TabIndex = 2;
            this.btnLocacao.Text = "Locação";
            this.btnLocacao.UseVisualStyleBackColor = true;
            this.btnLocacao.Click += new System.EventHandler(this.btnLocacao_Click);
            // 
            // btnConsultaLivro
            // 
            this.btnConsultaLivro.Location = new System.Drawing.Point(221, 256);
            this.btnConsultaLivro.Name = "btnConsultaLivro";
            this.btnConsultaLivro.Size = new System.Drawing.Size(309, 30);
            this.btnConsultaLivro.TabIndex = 3;
            this.btnConsultaLivro.Text = "Disponibilidade de Livros";
            this.btnConsultaLivro.UseVisualStyleBackColor = true;
            this.btnConsultaLivro.Click += new System.EventHandler(this.btnConsultaLivro_Click);
            // 
            // btnDevolucao
            // 
            this.btnDevolucao.Location = new System.Drawing.Point(222, 312);
            this.btnDevolucao.Name = "btnDevolucao";
            this.btnDevolucao.Size = new System.Drawing.Size(309, 32);
            this.btnDevolucao.TabIndex = 4;
            this.btnDevolucao.Text = "Devolução de Livros";
            this.btnDevolucao.UseVisualStyleBackColor = true;
            this.btnDevolucao.Click += new System.EventHandler(this.btnDevolucao_Click);
            // 
            // btnConsultaUsuario
            // 
            this.btnConsultaUsuario.Location = new System.Drawing.Point(224, 372);
            this.btnConsultaUsuario.Name = "btnConsultaUsuario";
            this.btnConsultaUsuario.Size = new System.Drawing.Size(307, 32);
            this.btnConsultaUsuario.TabIndex = 5;
            this.btnConsultaUsuario.Text = "Consulta Usuário";
            this.btnConsultaUsuario.UseVisualStyleBackColor = true;
            this.btnConsultaUsuario.Click += new System.EventHandler(this.btnConsultaUsuario_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(281, 43);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(179, 13);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = " Bem-vindo(a) a Biblioteca da Alanis!";
            // 
            // btnTesteConexao
            // 
            this.btnTesteConexao.Location = new System.Drawing.Point(685, 395);
            this.btnTesteConexao.Name = "btnTesteConexao";
            this.btnTesteConexao.Size = new System.Drawing.Size(93, 43);
            this.btnTesteConexao.TabIndex = 7;
            this.btnTesteConexao.Text = "teste conexao";
            this.btnTesteConexao.UseVisualStyleBackColor = true;
            this.btnTesteConexao.Click += new System.EventHandler(this.btnTesteConexao_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTesteConexao);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnConsultaUsuario);
            this.Controls.Add(this.btnDevolucao);
            this.Controls.Add(this.btnConsultaLivro);
            this.Controls.Add(this.btnLocacao);
            this.Controls.Add(this.btnCadastroUsuario);
            this.Controls.Add(this.btnCadastroLivro);
            this.Name = "MenuPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastroLivro;
        private System.Windows.Forms.Button btnCadastroUsuario;
        private System.Windows.Forms.Button btnLocacao;
        private System.Windows.Forms.Button btnConsultaLivro;
        private System.Windows.Forms.Button btnDevolucao;
        private System.Windows.Forms.Button btnConsultaUsuario;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnTesteConexao;
    }
}

