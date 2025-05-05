using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace cadastroproduto
{
    internal class Usuarios
    {
        private int id;
        private string nome;
        private string email;
        private string senha;
        private string cpf;
        private string usuario;
        private string nomeLogado;
        

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        
        public string Senha
        {
            get { return senha; }
            set { senha = value; }  
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public static bool verificarEmail(string email)
        {
            string emailValido = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailValido);
            return regex.IsMatch(email);
        }

        public static string CriptografarSenha(string senha)
        {
            try
            {
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(senha));
                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        builder.Append(bytes[i].ToString("x2"));
                    }

                    return builder.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível criptografar a senha: " + ex.Message, "Erro - Método Criptografar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public bool CadastrarUsuario()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoBD().Conectar())
                {
                    string senhaCriptografada = CriptografarSenha(Senha);
                    string inserir = "INSERT INTO usuario (nome, email, senha, cpf, usuario) values (@Nome, @Email, @Senha, @Cpf, @Usuario);";

                    MySqlCommand comando = new MySqlCommand(inserir, conexaoBanco);
                    comando.Parameters.AddWithValue("@Nome", Nome);
                    comando.Parameters.AddWithValue("@Email", Email); 
                    comando.Parameters.AddWithValue("@Senha", senhaCriptografada);
                    comando.Parameters.AddWithValue("@Cpf", Cpf);
                    comando.Parameters.AddWithValue("@Usuario", Usuario);

                    int resultado = comando.ExecuteNonQuery();

                    if (resultado > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar usuário ->", ex.Message);
                return false;
            }
        }

        private bool CpfValido(string cpf)
        {
            if (cpf.Length != 11 || cpf == new string(cpf[0], 11))
                return false;

            int[] mult1 = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] mult2 = { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            string temp = cpf.Substring(0, 9);
            int soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(temp[i].ToString()) * mult1[i];

            int resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;
            string digito = resto.ToString();

            temp += digito;
            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(temp[i].ToString()) * mult2[i];

            resto = soma % 11;
            resto = resto < 2 ? 0 : 11 - resto;
            digito += resto.ToString();

            return cpf.EndsWith(digito);
        }

        public bool verificarLogin()
        {
            try
            {
                
                using (MySqlConnection conexaoBanco = new ConexaoBD().Conectar())
                {
                    
                    string senhaCriptografada = CriptografarSenha(senha);

                    //Consultando se o usuário e senha informados existem no banco de dados
                    string consultaUsuarios = "SELECT COUNT(*) FROM usuario WHERE usuario = @usuario AND senha = @senha";
                    MySqlCommand comando = new MySqlCommand(consultaUsuarios, conexaoBanco);
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@senha", senhaCriptografada);
                    
                    int resultado = Convert.ToInt32(comando.ExecuteScalar());
                    //Verificando se retornou um usuário
                    if (resultado > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível verificar login -> " + ex.Message, "Erro - Verificar Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public string buscarNome()
        {
            try
            {
                using (MySqlConnection conexaoBanco = new ConexaoBD().Conectar())
                {
                    string senhaCriptografada = CriptografarSenha(senha);
                    string buscarNomeUsuario = "SELECT usuario FROM usuario WHERE usuario = @usuario AND senha = @senha";



                    MySqlCommand comando = new MySqlCommand(buscarNomeUsuario, conexaoBanco);
                    comando.Parameters.AddWithValue("@usuario", usuario);
                    comando.Parameters.AddWithValue("@senha", senhaCriptografada);

                    object resultado = comando.ExecuteScalar();

                    if (resultado != null)
                    {
                        return resultado.ToString();
                    }
                    else
                    {
                        return "";
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível buscar o nome do usuário -> " + ex.Message);
                throw;
            }
        }

        public string ValidarCadastro()
        {
            if (!verificarEmail(Email))
                return "E-mail inválido.";

            if (!CpfValido(Cpf))
                return "CPF inválido.";

            using (MySqlConnection conexaoBanco = new ConexaoBD().Conectar())
            {
                string consulta = "SELECT COUNT(*) FROM usuario WHERE email = @Email OR cpf = @Cpf OR usuario = @Usuario";
                MySqlCommand comando = new MySqlCommand(consulta, conexaoBanco);
                comando.Parameters.AddWithValue("@Email", Email);
                comando.Parameters.AddWithValue("@Cpf", Cpf);
                comando.Parameters.AddWithValue("@Usuario", Usuario);

                using (MySqlDataReader leitor = comando.ExecuteReader())
                {
                    if (leitor.Read())
                    {
                        int count = Convert.ToInt32(leitor[0]);
                        if (count > 0)
                        {
                            leitor.Close();
                            
                            if (ExisteCampoDuplicado("email", Email, conexaoBanco))
                                return "E-mail já está cadastrado.";

                            if (ExisteCampoDuplicado("cpf", Cpf, conexaoBanco))
                                return "CPF já está cadastrado.";

                            if (ExisteCampoDuplicado("usuario", Usuario, conexaoBanco))
                                return "Usuário já está cadastrado.";
                        }
                    }
                }
            }

            return null; // Tudo certo
        }
        private bool ExisteCampoDuplicado(string campo, string valor, MySqlConnection conexao)
        {
            string query = $"SELECT COUNT(*) FROM usuario WHERE {campo} = @valor";
            using (MySqlCommand cmd = new MySqlCommand(query, conexao))
            {
                cmd.Parameters.AddWithValue("@valor", valor);
                return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
            }
        }


    }
}
