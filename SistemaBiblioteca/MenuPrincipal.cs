using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnCadastroLivro_Click(object sender, EventArgs e)
        {
            FormCadastroLivro form = new FormCadastroLivro();
            form.ShowDialog(); // Abre a nova tela de forma modal
        }

        private void btnCadastroUsuario_Click(object sender, EventArgs e)
        {
            FormCadastroUsuario form = new FormCadastroUsuario();
            form.ShowDialog(); // Abre a nova tela de forma modal
        }

        private void btnLocacao_Click(object sender, EventArgs e)
        {
            FormLocacao form = new FormLocacao();
            form.ShowDialog(); // Abre a nova tela de forma modal
        }

        private void btnConsultaLivro_Click(object sender, EventArgs e)
        {
            FormConsultaLivro form = new FormConsultaLivro();
            form.ShowDialog(); // Abre a nova tela de forma modal
        }

        private void btnDevolucao_Click(object sender, EventArgs e)
        {
            FormDevolucao form = new FormDevolucao();
            form.ShowDialog(); // Abre a nova tela de forma modal
        }

        private void btnConsultaUsuario_Click(object sender, EventArgs e)
        {
            FormConsultaUsuario form = new FormConsultaUsuario();
            form.ShowDialog();  // Abre a tela de forma modal
        }


        private void btnTesteConexao_Click(object sender, EventArgs e)
        {
            string conexao = "server=localhost;user=root;password=;database=BibliotecaDB";

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();
                    MessageBox.Show("Conexão com o banco de dados bem-sucedida!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao conectar: " + ex.Message);
            }
        }
    }
}
