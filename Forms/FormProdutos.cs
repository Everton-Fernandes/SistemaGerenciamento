using Npgsql;
using SistemaGerenciamentoClientesProdutos.Data;
using SistemaGerenciamentoClientesProdutos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGerenciamentoClientesProdutos.Forms
{
    public partial class FormProdutos : Form
    {
        private int produtoId;

        public FormProdutos()
        {
            InitializeComponent();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            var db = new DatabaseHelper();
            DataTable produtos = db.GetProdutos();
            GVProdutos.DataSource = produtos;
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            // Captura os dados do formulário
            string nome = TxtNome.Text;
            string descricao = TxtDescricao.Text;
            decimal preco = decimal.Parse(TxtPreco.Text);
            int estoque = int.Parse(TxtEstoque.Text);

            // Cria uma instância do DatabaseHelper
            var db = new DatabaseHelper();

            // Chama o método para adicionar uma venda no DatabaseHelper
            db.AddProduto(nome, descricao, preco, estoque);

            // Exibe uma mensagem de sucesso
            MessageBox.Show("Produto salvo com sucesso!");

            // Limpa os campos após salvar
            TxtNome.Clear();
            TxtDescricao.Clear();
            TxtPreco.Clear();
            TxtEstoque.Clear();
        }

        // Método para carregar os dados de um produto específico para edição
        public void CarregarProdutoParaEdicao(int id)
        {
            produtoId = id; // Armazena o ID do produto que será editado

            using (var connection = DatabaseConfig.GetConnection())
            {
                connection.Open();
                string query = "SELECT nome, descricao, preco, estoque FROM produtos WHERE produtoid = @produtoid";

                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("produtoid", produtoId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Preenche os campos com os dados do produto
                            TxtNome.Text = reader.GetString(0);
                            TxtDescricao.Text = reader.GetString(1);
                            TxtPreco.Text = reader.GetDecimal(2).ToString();
                            TxtEstoque.Text = reader.GetInt32(3).ToString();
                        }
                        else
                        {
                            MessageBox.Show("Produto não encontrado!");
                        }
                    }
                }
            }
        }

        // Método para salvar as alterações do produto editado no banco de dados
        private void EditarProduto()
        {
            // Captura os dados dos campos de entrada
            string nome = TxtNome.Text;
            string descricao = TxtDescricao.Text;
            decimal preco;
            int estoque;

            if (!decimal.TryParse(TxtPreco.Text, out preco))
            {
                MessageBox.Show("Preço inválido.");
                return;
            }

            if (!int.TryParse(TxtEstoque.Text, out estoque))
            {
                MessageBox.Show("Estoque inválido.");
                return;
            }

            using (var connection = DatabaseConfig.GetConnection())
            {
                connection.Open();

                string query = "UPDATE produtos SET nome = @nome, descricao = @descricao, preco = @preco, estoque = @estoque WHERE produtoid = @produtoid";

                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("nome", nome);
                    cmd.Parameters.AddWithValue("descricao", descricao);
                    cmd.Parameters.AddWithValue("preco", preco);
                    cmd.Parameters.AddWithValue("estoque", estoque);
                    cmd.Parameters.AddWithValue("produtoid", produtoId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Produto atualizado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atualizar o produto.");
                    }
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            EditarProduto();
            // Limpa os campos após salvar
            TxtNome.Clear();
            TxtDescricao.Clear();
            TxtPreco.Clear();
            TxtEstoque.Clear();
        }

        private void BtnHabilitar_Click(object sender, EventArgs e)
        {
            produtoId = int.Parse(TxtProdutoId.Text);
            CarregarProdutoParaEdicao(produtoId);
        }

        // Método para excluir um produto
        private void ExcluirProduto(int produtoId)
        {
            // Confirmação antes de excluir
            var confirmResult = MessageBox.Show("Tem certeza de que deseja excluir este produto?",
                                                 "Confirmar Exclusão",
                                                 MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                using (var connection = DatabaseConfig.GetConnection())
                {
                    try
                    {
                        connection.Open();

                        // Query SQL para deletar o produto
                        string query = "DELETE FROM produtos WHERE produtoid = @produtoid";

                        using (var cmd = new NpgsqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("produtoid", produtoId);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Produto excluído com sucesso!");
                            }
                            else
                            {
                                MessageBox.Show("Erro ao excluir o produto. Produto não encontrado.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir o produto: " + ex.Message);
                    }
                }
            }
        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            // Verifica se um produto foi selecionado para exclusão
            if (int.TryParse(TxtProdutoId.Text, out int produtoId))
            {
                ExcluirProduto(produtoId);
            }
            else
            {
                MessageBox.Show("Por favor, selecione um produto válido para excluir.");
            }
        }
    }
}
