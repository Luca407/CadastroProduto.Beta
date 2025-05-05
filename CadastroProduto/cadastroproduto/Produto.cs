using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace cadastroproduto
{
    internal class Produto
    {
        private int id;
        private string nome;
        private string categoria;
        private double preco;
        private int quantidade;
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
        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
       
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }

        public bool InserirProduto()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string query = "INSERT INTO produto (nome, preco, quantidade, categoria) VALUES (@nome, @preco, @quantidade, @categoria)";
                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    comando.Parameters.AddWithValue("@nome", Nome);
                    comando.Parameters.AddWithValue("@preco", Preco);
                    comando.Parameters.AddWithValue("@quantidade", Quantidade);
                    comando.Parameters.AddWithValue("@categoria", Categoria);
                    
                    return comando.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir produto: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                throw;
            }
        }

        public bool EditarProduto()
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string query = "UPDATE produto SET nome = @nome, preco = @preco, quantidade = @quantidade, categoria = @categoria WHERE id = @id";
                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    comando.Parameters.AddWithValue("@id", Id);
                    comando.Parameters.AddWithValue("@nome", Nome);
                    comando.Parameters.AddWithValue("@preco", Preco);
                    comando.Parameters.AddWithValue("@quantidade", Quantidade);
                    comando.Parameters.AddWithValue("@categoria", Categoria);

                    return comando.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao editar produto: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                throw;
            }
        }

        public bool ExcluirProduto() 
        {
            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string query = "DELETE FROM produto WHERE id = @id";
                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    comando.Parameters.AddWithValue("@id", Id);
                    return comando.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao deletar produto: " + ex.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                throw;
            }
        }
        public static DataTable ListarTodosProduto()
        {
            DataTable tabela = new DataTable();

            try
            {
                using (MySqlConnection conexao = new ConexaoBD().Conectar())
                {
                    string query = "SELECT * FROM produto";
                    MySqlCommand comando = new MySqlCommand(query, conexao);
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                    adaptador.Fill(tabela);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao listar produto:" + ex.Message + MessageBoxButtons.OK + MessageBoxIcon.Warning);
                throw;
            }
            return tabela;
        }

    }
}
