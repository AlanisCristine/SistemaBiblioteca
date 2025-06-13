using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaBiblioteca
{
    public partial class FormConsultaUsuario : Form
    {
        string connectionString = "server=localhost;user=root;password=;database=BibliotecaDB";

        public FormConsultaUsuario()
        {
            InitializeComponent();
            this.Load += FormConsultaUsuario_Load;
        }

    
        private void FormConsultaUsuario_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();
        }

        private void CarregarUsuarios()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();

                    string query = @"SELECT IdUsuario, NomeUsuario, Rua, Numero, Complemento, Bairro, Cidade, UF, Cep, Telefone, DataNascimento
                                     FROM Usuario
                                     ORDER BY NomeUsuario";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);

                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvUsuarios.DataSource = dt;

                    // Configurar colunas para melhor visualização, se quiser:
                    dgvUsuarios.Columns["IdUsuario"].HeaderText = "ID";
                    dgvUsuarios.Columns["NomeUsuario"].HeaderText = "Nome";
                    dgvUsuarios.Columns["Rua"].HeaderText = "Rua";
                    dgvUsuarios.Columns["Numero"].HeaderText = "Número";
                    dgvUsuarios.Columns["Complemento"].HeaderText = "Complemento";
                    dgvUsuarios.Columns["Bairro"].HeaderText = "Bairro";
                    dgvUsuarios.Columns["Cidade"].HeaderText = "Cidade";
                    dgvUsuarios.Columns["UF"].HeaderText = "UF";
                    dgvUsuarios.Columns["Cep"].HeaderText = "CEP";
                    dgvUsuarios.Columns["Telefone"].HeaderText = "Telefone";
                    dgvUsuarios.Columns["DataNascimento"].HeaderText = "Data Nasc.";

                    // Ajustar tamanho das colunas automaticamente
                    dgvUsuarios.AutoResizeColumns();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar usuários: " + ex.Message);
            }
        }
    }
}

