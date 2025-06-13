using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaBiblioteca
{
    public partial class FormDevolucao : Form
    {
        string connectionString = "server=localhost;user=root;password=;database=BibliotecaDB";

        public FormDevolucao()
        {
            InitializeComponent();
            this.Load += FormDevolucao_Load;
        }

        private void FormDevolucao_Load(object sender, EventArgs e)
        {
            CarregarLivrosEmprestados();
        }

        private void CarregarLivrosEmprestados()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"
                SELECT ll.IdLocarLivro, l.Titulo, u.NomeUsuario, ll.DataLocacao, ll.DataEntregaPrevista
                FROM LocarLivro ll
                JOIN Livro l ON ll.LivroId = l.Id
                JOIN Usuario u ON ll.BibliotecaUsuario = u.IdUsuario
                WHERE ll.DataDevolucao IS NULL";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvEmprestados.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar livros emprestados: " + ex.Message);
            }
        }

        private void btnDevolver_Click(object sender, EventArgs e)
        {
            if (dgvEmprestados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione uma locação para devolver.");
                return;
            }

            int locacaoId = Convert.ToInt32(dgvEmprestados.SelectedRows[0].Cells["IdLocarLivro"].Value);

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"UPDATE LocarLivro 
                             SET DataDevolucao = CURDATE()
                             WHERE IdLocarLivro = @IdLocarLivro";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@IdLocarLivro", locacaoId);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Livro devolvido com sucesso!");
                    CarregarLivrosEmprestados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao devolver livro: " + ex.Message);
            }
        }

    }
}

