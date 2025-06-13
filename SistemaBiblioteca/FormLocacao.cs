using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SistemaBiblioteca
{
    public partial class FormLocacao : Form
    {
        string connectionString = "server=localhost;user=root;password=;database=BibliotecaDB";

        public FormLocacao()
        {
            InitializeComponent();
            this.Load += FormLocacao_Load;
        }

        private void FormLocacao_Load(object sender, EventArgs e)
        {
            CarregarUsuarios();
            CarregarLivrosDisponiveis();

            dtpLocacao.Value = DateTime.Today;
            dtpDataEntregaPrevista.Value = DateTime.Today.AddDays(7);
        }

        private void CarregarUsuarios()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT IdUsuario, NomeUsuario FROM Usuario ORDER BY NomeUsuario";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    cmbUsuarios.DisplayMember = "NomeUsuario";
                    cmbUsuarios.ValueMember = "IdUsuario";
                    cmbUsuarios.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar usuários: " + ex.Message);
            }
        }

        private void CarregarLivrosDisponiveis()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"
                        SELECT l.Id, l.Titulo 
                        FROM Livro l
                        WHERE l.Id NOT IN (
                            SELECT LivroId FROM LocarLivro WHERE DataEntregaPrevista >= CURDATE()
                        )
                        ORDER BY l.Titulo";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    cmbLivros.DisplayMember = "Titulo";
                    cmbLivros.ValueMember = "Id";
                    cmbLivros.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar livros disponíveis: " + ex.Message);
            }
        }

       // private void btnConfirmar_Click(object sender, EventArgs e)
        //{
        //    if (cmbLivros.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Selecione um livro.");
        //        return;
        //    }

        //    if (cmbUsuarios.SelectedIndex == -1)
        //    {
        //        MessageBox.Show("Selecione um usuário.");
        //        return;
        //    }

        //    DateTime dataLocacao = dtpLocacao.Value.Date;
        //    DateTime dataEntrega = dtpDataEntregaPrevista.Value.Date;

        //    if (dataEntrega < dataLocacao)
        //    {
        //        MessageBox.Show("Data de entrega não pode ser anterior à data de locação.");
        //        return;
        //    }

        //    int livroId = Convert.ToInt32(cmbLivros.SelectedValue);
        //    string usuarioId = cmbUsuarios.SelectedValue.ToString();

        //    try
        //    {
        //        using (MySqlConnection conn = new MySqlConnection(connectionString))
        //        {
        //            conn.Open();
        //            string query = @"INSERT INTO LocarLivro 
        //                (DataLocacao, DataEntregaPrevista, LivroId, BibliotecaUsuario) 
        //                VALUES (@DataLocacao, @DataEntregaPrevista, @LivroId, @BibliotecaUsuario)";

        //            MySqlCommand cmd = new MySqlCommand(query, conn);
        //            cmd.Parameters.AddWithValue("@DataLocacao", dataLocacao);
        //            cmd.Parameters.AddWithValue("@DataEntregaPrevista", dataEntrega);
        //            cmd.Parameters.AddWithValue("@LivroId", livroId);
        //            cmd.Parameters.AddWithValue("@BibliotecaUsuario", usuarioId);

        //            cmd.ExecuteNonQuery();

        //            MessageBox.Show("Locação cadastrada com sucesso!");

        //            // Atualiza a lista de livros disponíveis
        //            CarregarLivrosDisponiveis();
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Erro ao salvar locação: " + ex.Message);
        //    }
       // }

        private void btnConfirmar_Click_1(object sender, EventArgs e)
        {

            if (cmbLivros.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um livro.");
                return;
            }

            if (cmbUsuarios.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione um usuário.");
                return;
            }

            DateTime dataLocacao = dtpLocacao.Value.Date;
            DateTime dataEntrega = dtpDataEntregaPrevista.Value.Date;

            if (dataEntrega < dataLocacao)
            {
                MessageBox.Show("Data de entrega não pode ser anterior à data de locação.");
                return;
            }

            int livroId = Convert.ToInt32(cmbLivros.SelectedValue);
            string usuarioId = cmbUsuarios.SelectedValue.ToString();

            try
            {
                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"INSERT INTO LocarLivro 
                        (DataLocacao, DataEntregaPrevista, LivroId, BibliotecaUsuario) 
                        VALUES (@DataLocacao, @DataEntregaPrevista, @LivroId, @BibliotecaUsuario)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@DataLocacao", dataLocacao);
                    cmd.Parameters.AddWithValue("@DataEntregaPrevista", dataEntrega);
                    cmd.Parameters.AddWithValue("@LivroId", livroId);
                    cmd.Parameters.AddWithValue("@BibliotecaUsuario", usuarioId);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Locação cadastrada com sucesso!");

                    // Atualiza a lista de livros disponíveis
                    CarregarLivrosDisponiveis();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao salvar locação: " + ex.Message);
            }
        }
    }
}

//private void FormLocacao_Load(object sender, EventArgs e)
//        {

//        }