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

namespace cadastroproduto
{
    public partial class TelaRedefinirSenha : Form
    {
        private string email;
        
        public TelaRedefinirSenha(string emailUsuario)
        {
            InitializeComponent();
            email = emailUsuario;
            
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string novaSenha = txtNovaSenha.Text.Trim();
            string confirmarSenha = txtConfirmarSenha.Text.Trim();

            if (novaSenha != confirmarSenha)
            {
                MessageBox.Show("As senhas não coincidem.");
                return;
            }

            string senhaCriptografada = Usuarios.CriptografarSenha(novaSenha);

            using (MySqlConnection conexao = new ConexaoBD().Conectar())
            {
                string sql = "UPDATE usuario SET senha = @Senha WHERE email = @Email";
                MySqlCommand cmd = new MySqlCommand(sql, conexao);
                cmd.Parameters.AddWithValue("@Senha", senhaCriptografada);
                cmd.Parameters.AddWithValue("@Email", email);

                int resultado = cmd.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Senha alterada com sucesso!");

                    // Abre uma nova instância da tela de login
                    TelaLogin telaLogin = new TelaLogin();
                    telaLogin.Show();

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Erro ao alterar a senha.");
                }
            }
        }
    }
}
