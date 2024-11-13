using Npgsql;
using SistemaGerenciamentoClientesProdutos.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciamentoClientesProdutos.Data
{
    public class DatabaseHelper
    {
        // Métodos para Clientes
        public void AddCliente(string nome, string endereco, string telefone, string email)
        {
            using (var conn = DatabaseConfig.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO clientes (nome, endereco, telefone, email) VALUES (@Nome, @Endereco, @Telefone, @Email)";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@Endereco", endereco);
                    cmd.Parameters.AddWithValue("@Telefone", telefone);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateCliente(int id, string nome, string endereco, string telefone, string email)
        {
            using (var conn = DatabaseConfig.GetConnection())
            {
                conn.Open();
                string query = "UPDATE clientes SET nome = @Nome, endereco = @Endereco, telefone = @Telefone, email = @Email WHERE id = @Id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@Endereco", endereco);
                    cmd.Parameters.AddWithValue("@Telefone", telefone);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteCliente(int id)
        {
            using (var conn = DatabaseConfig.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM clientes WHERE id = @Id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetClientes()
        {
            using (var conn = DatabaseConfig.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM clientes";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    DataTable clientes = new DataTable();
                    adapter.Fill(clientes);
                    return clientes;
                }
            }
        }

        // Métodos para Produtos
        public void AddProduto(string nome, string descricao, decimal preco, int estoque)
        {
            using (var conn = DatabaseConfig.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO produtos (nome, descricao, preco, estoque) VALUES (@Nome, @Descricao, @Preco, @Estoque)";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@Descricao", descricao);
                    cmd.Parameters.AddWithValue("@Preco", preco);
                    cmd.Parameters.AddWithValue("@Estoque", estoque);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void UpdateProduto(int id, string nome, string descricao, decimal preco, int estoque)
        {
            using (var conn = DatabaseConfig.GetConnection())
            {
                conn.Open();
                string query = "UPDATE produtos SET nome = @Nome, descricao = @Descricao, preco = @Preco, estoque = @Estoque WHERE id = @Id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@Descricao", descricao);
                    cmd.Parameters.AddWithValue("@Preco", preco);
                    cmd.Parameters.AddWithValue("@Estoque", estoque);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public void DeleteProduto(int id)
        {
            using (var conn = DatabaseConfig.GetConnection())
            {
                conn.Open();
                string query = "DELETE FROM produtos WHERE id = @Id";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetProdutos()
        {
            using (var conn = DatabaseConfig.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM produtos";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    DataTable produtos = new DataTable();
                    adapter.Fill(produtos);
                    return produtos;
                }
            }
        }

        // Métodos para Vendas
        public void AddVenda(int clienteId, int produtoId, int quantidade, DateTime dataVenda)
        {
            using (var conn = DatabaseConfig.GetConnection())
            {
                conn.Open();
                string query = "INSERT INTO vendas (clienteid, produtoid, qtproduto, datavenda) VALUES (@ClienteId, @ProdutoId, @Quantidade, @DataVenda)";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ClienteId", clienteId);
                    cmd.Parameters.AddWithValue("@ProdutoId", produtoId);
                    cmd.Parameters.AddWithValue("@Quantidade", quantidade);
                    cmd.Parameters.AddWithValue("@DataVenda", dataVenda);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public DataTable GetVendas()
        {
            using (var conn = DatabaseConfig.GetConnection())
            {
                conn.Open();
                string query = "SELECT * FROM vendas";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    DataTable vendas = new DataTable();
                    adapter.Fill(vendas);
                    return vendas;
                }
            }
        }

        // Relatório de Estoque
        public DataTable GetRelatorioEstoque()
        {
            using (var conn = DatabaseConfig.GetConnection())
            {
                conn.Open();
                string query = "SELECT nome, descricao, estoque FROM produtos";
                using (var cmd = new NpgsqlCommand(query, conn))
                using (var adapter = new NpgsqlDataAdapter(cmd))
                {
                    DataTable relatorioEstoque = new DataTable();
                    adapter.Fill(relatorioEstoque);
                    return relatorioEstoque;
                }
            }
        }

        // Relatório de Vendas por Cliente
        public DataTable GetRelatorioVendasPorCliente(int clienteId)
        {
            using (var conn = DatabaseConfig.GetConnection())
            {
                conn.Open();
                string query = @"SELECT vendas.datavenda, produtos.nome, vendas.qtproduto
                                 FROM vendas
                                 INNER JOIN produtos ON vendas.produtoid = produtos.id
                                 WHERE vendas.clienteid = @ClienteId";
                using (var cmd = new NpgsqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ClienteId", clienteId);
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        DataTable relatorioVendas = new DataTable();
                        adapter.Fill(relatorioVendas);
                        return relatorioVendas;
                    }
                }
            }
        }
    }
}
