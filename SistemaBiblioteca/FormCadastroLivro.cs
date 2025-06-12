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
    public partial class FormCadastroLivro : Form
    {
        public FormCadastroLivro()
        {
            InitializeComponent();
        }

        private void lblAutor_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text.Trim();
            string autor = txtAutor.Text.Trim();

            if (titulo == "" || autor == "")
            {
                MessageBox.Show("Por favor, preencha todos os campos.");
                return;
            }

            try
            {
                string conexao = "server=localhost;user=root;password=;database=BibliotecaDB";
                using (MySqlConnection conn = new MySqlConnection(conexao))
                {
                    conn.Open();

                    string query = "INSERT INTO Livro (Titulo, Autor) VALUES (@Titulo, @Autor)";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Titulo", titulo);
                        cmd.Parameters.AddWithValue("@Autor", autor);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Livro cadastrado com sucesso!");
                txtTitulo.Clear();
                txtAutor.Clear();
                txtTitulo.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar livro: " + ex.Message);
            }
        }
    }
}
