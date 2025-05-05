namespace cadastroproduto
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();

        }



        private void llblCadastro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaCadastroUsuario FormCadastro = new TelaCadastroUsuario(this);
            FormCadastro.Show();
            this.Hide();
        }

        private void llblEsqueciSenha_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TelaEsqueciSenha telaEsqueciSenha = new TelaEsqueciSenha(this);
            telaEsqueciSenha.Show();
            this.Hide();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtUsuario.Text.Equals("") && !txtSenha.Text.Equals(""))
                {
                    Usuarios usuario = new Usuarios();
                    usuario.Usuario = txtUsuario.Text;
                    usuario.Senha = txtSenha.Text;


                    

                        if (usuario.verificarLogin())
                        {
                            MessageBox.Show("Login realizado com sucesso!");
                            string usuarioLogado = usuario.buscarNome();
                            TelaCadastroProduto telaproduto = new TelaCadastroProduto(usuarioLogado, this);
                            telaproduto.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha incorretos!");
                            txtUsuario.Clear();
                            txtSenha.Clear();
                        }

                }
                else
                {
                    MessageBox.Show("Preencha todos os campos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possivel acessar o sistema! " + ex.Message, "Erro - Método btnEntrar_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void TelaLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
