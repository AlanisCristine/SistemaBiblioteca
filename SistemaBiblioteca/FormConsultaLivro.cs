using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaBiblioteca
{
    public partial class FormConsultaLivro : Form
    {
        string connectionString = "server=localhost;user=root;password=;database=BibliotecaDB";

        public FormConsultaLivro()
        {
            InitializeComponent();
            CarregarLivrosComStatus();
        }

        private void FormConsultaLivro_Load(object sender, EventArgs e)
        {

        }
        private void CarregarLivrosComStatus()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
    SELECT l.Id, l.Titulo,
        CASE 
            WHEN EXISTS (
                SELECT 1 FROM LocarLivro ll
                WHERE ll.LivroId = l.Id AND ll.DataEntregaPrevista >= CURDATE()
            )
            THEN 'Emprestado'
            ELSE 'Disponível'
        END AS StatusLivro
    FROM Livro l
    ORDER BY l.Titulo";


                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvLivrosDisponibilidade.DataSource = dt;
            }
        }

        //private void btnAtualizar_Click(object sender, EventArgs e)
        //{

        //}

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            CarregarLivrosComStatus();
        }
    }

}

