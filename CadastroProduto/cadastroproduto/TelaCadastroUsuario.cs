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
    public partial class TelaCadastroUsuario : Form
    {
        private Form telalogin;

        public TelaCadastroUsuario(Form Tela)
        {
            InitializeComponent();
            telalogin = Tela;
        }


        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!txtCadNome.Text.Equals("") && !txtCadEmail.Text.Equals("") && !txtCadSenha.Text.Equals("") && !txtCadUsuario.Text.Equals("") && !mtxtCadCpf.Text.Equals(""))
                {
                    Usuarios novoUsuario = new Usuarios();
                    novoUsuario.Nome = txtCadNome.Text;
                    novoUsuario.Email = txtCadEmail.Text;
                    novoUsuario.Senha = txtCadSenha.Text;
                    novoUsuario.Usuario = txtCadUsuario.Text;
                    novoUsuario.Cpf = new string(mtxtCadCpf.Text.Where(char.IsDigit).ToArray());


                    string validacao = novoUsuario.ValidarCadastro();

                    if (validacao != null)
                    {
                        MessageBox.Show(validacao);
                        return;
                    }

                    if (novoUsuario.CadastrarUsuario())
                    {
                        MessageBox.Show("Cadastro realizado com sucesso");
                        txtCadNome.Clear();
                        txtCadEmail.Clear();
                        txtCadSenha.Clear();
                        txtCadUsuario.Clear();
                        mtxtCadCpf.Clear();


                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar usuário");
                    }
                }
                else
                {
                    MessageBox.Show("Preencha os campos corretamente!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar o usuário: " + ex.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            telalogin.Show();
            this.Hide();
        }

        private void TelaCadastro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
