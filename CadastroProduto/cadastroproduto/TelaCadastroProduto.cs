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
    public partial class TelaCadastroProduto : Form
    {

        private string nomeUsuario;
        private Form telaLogin;
        private void ListarTodosProduto()
        {
            dgvProduto.DataSource = Produto.ListarTodosProduto();
        }

        public TelaCadastroProduto(string usuarioLogado, Form tela)
        {
            InitializeComponent();
            this.telaLogin = tela;
            nomeUsuario = usuarioLogado;
            ListarTodosProduto();
            dgvProduto.AllowUserToAddRows = false;
            dgvProduto.RowHeadersVisible = false;
            dgvProduto.ClearSelection();
        }

        private void TelaCadastroProduto_Load(object sender, EventArgs e)
        {
            lblNomeUsuario.Text = "Usuário logado: " + nomeUsuario;
        }
        private void TelaCadastroProduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNomeProduto.Text) ||
                string.IsNullOrWhiteSpace(cbCategoria.Text) ||
                string.IsNullOrWhiteSpace(mtxtPreco.Text) ||
                string.IsNullOrWhiteSpace(txtQuant.Text))
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Produto pdt = new Produto
                {
                    Id = Convert.ToInt32(lblID.Text.Split(':')[1].Trim()),
                    Nome = txtNomeProduto.Text,
                    Categoria = cbCategoria.Text,
                    Preco = (double)Convert.ToDecimal(mtxtPreco.Text),
                    Quantidade = Convert.ToInt32(txtQuant.Text)
                };


                if (pdt.InserirProduto())
                {
                    MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarTodosProduto();
                    LimparCampos();     
                }

                else
                {
                    MessageBox.Show("Erro ao cadastrar Produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar produto" + ex.Message);
                throw;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(lblID.Text))
                {
                    MessageBox.Show("Selecione um produto para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txtNomeProduto.Text) ||
                    string.IsNullOrWhiteSpace(cbCategoria.Text) ||
                    string.IsNullOrWhiteSpace(mtxtPreco.Text) ||
                    string.IsNullOrWhiteSpace(txtQuant.Text))
                {
                    MessageBox.Show("Todos os campos devem ser preenchidos.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Produto pdt = new Produto
                {
                    Id = Convert.ToInt32(lblID.Text.Split(':')[1].Trim()),
                    Nome = txtNomeProduto.Text,
                    Categoria = cbCategoria.Text,
                    Preco = (double)Convert.ToDecimal(mtxtPreco.Text),
                    Quantidade = Convert.ToInt32(txtQuant.Text)
                };

                if (pdt.EditarProduto())
                {
                    MessageBox.Show("Produto atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ListarTodosProduto();
                    LimparCampos();      
                }

                else
                {
                    MessageBox.Show("Erro ao atualizar produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar produto: " + ex.Message);
            }
        }

            private void btnExcluir_Click(object sender, EventArgs e)
            {
                try
                {
                if (string.IsNullOrWhiteSpace(lblID.Text))
                {
                    MessageBox.Show("Selecione um produto para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                DialogResult confirm = MessageBox.Show("Deseja realmente excluir este produto?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (confirm == DialogResult.Yes)
                    {
                         Produto pdt = new Produto
                         {
                              Id = Convert.ToInt32(lblID.Text.Split(':')[1].Trim()),
                         };

                         if (pdt.ExcluirProduto())
                         {
                            MessageBox.Show("Produto excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ListarTodosProduto(); // Atualiza o grid
                            LimparCampos();       // Limpa os campos
                         }

                    else
                    {
                            MessageBox.Show("Erro ao excluir produto.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir produto: " + ex.Message);
                }

            }

        private void dgvProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvProduto.Rows[e.RowIndex];
                lblID.Text = ("ID do produto selecionado: " + dgvProduto.Rows[e.RowIndex].Cells["id"].Value.ToString());
                txtNomeProduto.Text = dgvProduto.Rows[e.RowIndex].Cells["nome"].Value.ToString();
                cbCategoria.Text = dgvProduto.Rows[e.RowIndex].Cells["categoria"].Value.ToString();
                mtxtPreco.Text = dgvProduto.Rows[e.RowIndex].Cells["preco"].Value.ToString();
                txtQuant.Text = dgvProduto.Rows[e.RowIndex].Cells["quantidade"].Value.ToString();
            }
        }
        private void LimparCampos()
        {
            lblID.Text = "ID do produto selecionado: 0";
            txtNomeProduto.Clear();
            cbCategoria.SelectedIndex = -1;
            mtxtPreco.Clear();
            txtQuant.Clear();
        }


    }
}
