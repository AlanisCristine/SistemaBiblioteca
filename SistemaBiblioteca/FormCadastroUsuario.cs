using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;  // Import necessário para MySQL

namespace SistemaBiblioteca
{
    public partial class FormCadastroUsuario : Form
    {
        public FormCadastroUsuario()
        {
            InitializeComponent();
            rbCpf.Checked = true; // CPF como padrão
            AplicarMascara();
        }

        private void rbCpf_CheckedChanged(object sender, EventArgs e)
        {
            AplicarMascara();
        }

        private void rbCnpj_CheckedChanged(object sender, EventArgs e)
        {
            AplicarMascara();
        }

        private void AplicarMascara()
        {
            if (rbCpf.Checked)
                txtIdUsuario.Mask = "000.000.000-00";
            else
                txtIdUsuario.Mask = "00.000.000/0000-00";
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string idUsuario = txtIdUsuario.Text.Replace(".", "").Replace("-", "").Replace("/", "");
            string nome = txtNome.Text;
            string rua = txtRua.Text;
            string numero = txtNumero.Text;
            string complemento = txtComplemento.Text;
            string bairro = txtBairro.Text;
            string cidade = txtCidade.Text;
            string uf = txtUF.Text;
            string cep = txtCep.Text;
            string telefone = txtTelefone.Text;
            string dataNascimento = dtpDataNascimento.Value.ToString("yyyy-MM-dd");

            string connectionString = "server=localhost;user=root;password=;database=BibliotecaDB";

            string query = @"INSERT INTO Usuario
                (IdUsuario, NomeUsuario, Rua, Numero, Complemento, Bairro, Cidade, UF, Cep, Telefone, DataNascimento)
                VALUES
                (@IdUsuario, @NomeUsuario, @Rua, @Numero, @Complemento, @Bairro, @Cidade, @UF, @Cep, @Telefone, @DataNascimento)";

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@IdUsuario", idUsuario);
                cmd.Parameters.AddWithValue("@NomeUsuario", nome);
                cmd.Parameters.AddWithValue("@Rua", rua);
                cmd.Parameters.AddWithValue("@Numero", numero);
                cmd.Parameters.AddWithValue("@Complemento", complemento);
                cmd.Parameters.AddWithValue("@Bairro", bairro);
                cmd.Parameters.AddWithValue("@Cidade", cidade);
                cmd.Parameters.AddWithValue("@UF", uf);
                cmd.Parameters.AddWithValue("@Cep", cep);
                cmd.Parameters.AddWithValue("@Telefone", telefone);
                cmd.Parameters.AddWithValue("@DataNascimento", dataNascimento);

                try
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                    LimparCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao cadastrar: " + ex.Message);
                }
            }
        }

        private void LimparCampos()
        {
            txtIdUsuario.Clear();
            txtNome.Clear();
            txtRua.Clear();
            txtNumero.Clear();
            txtComplemento.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtUF.Clear();
            txtCep.Clear();
            txtTelefone.Clear();
            dtpDataNascimento.Value = DateTime.Today;
            rbCpf.Checked = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            // Pode ficar vazio ou remover se não for usado
        }
    }
}
