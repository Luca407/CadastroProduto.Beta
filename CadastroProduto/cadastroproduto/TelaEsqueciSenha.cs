using System;
using System.Linq;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace cadastroproduto
{
    public partial class TelaEsqueciSenha : Form
    {
        private Form telaLogin;

        public TelaEsqueciSenha(Form telaLogin)
        {
            InitializeComponent();
            this.telaLogin = telaLogin;
        }

        private void btnAvancar_Click_1(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string cpf = new string(mtxtCpf.Text.Where(char.IsDigit).ToArray());

            using (MySqlConnection conexao = new ConexaoBD().Conectar())
            {
                string sql = "SELECT COUNT(*) FROM usuario WHERE email = @Email AND cpf = @Cpf";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Cpf", cpf);

                int existe = Convert.ToInt32(cmd.ExecuteScalar());

                if (existe > 0)
                {
                    // Abre tela para redefinir senha
                    TelaRedefinirSenha redefinirSenha = new TelaRedefinirSenha(email);
                    redefinirSenha.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Dados não conferem. Verifique o e-mail e o CPF.");
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (telaLogin != null)
                telaLogin.Show();
            this.Hide();
        }

        private void TelaEsqueciSenha_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
