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
    public partial class FormClientes : Form
    {
        private int clienteId;

        public FormClientes()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            // Captura os dados do formulário
            string nome = TxtNome.Text;
            string endereco = TxtEndereco.Text;
            string telefone = TxtTelefone.Text;
            string email = TxtEmail.Text;

            // Cria uma instância do DatabaseHelper
            var db = new DatabaseHelper();

            // Chama o método para adicionar uma venda no DatabaseHelper
            db.AddCliente(nome, endereco, telefone, email);

            // Exibe uma mensagem de sucesso
            MessageBox.Show("Cliente salvo com sucesso!");

            // Limpa os campos após salvar
            TxtNome.Clear();
            TxtEndereco.Clear();
            TxtTelefone.Clear();
            TxtEmail.Clear();
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            var db = new DatabaseHelper();
            DataTable clientes = db.GetClientes();
            GVClientes.DataSource = clientes;
        }

        public void CarregarClienteParaEdicao(int id)
        {
            clienteId = id; // Armazena o ID do cliente que será editado

            using (var connection = DatabaseConfig.GetConnection())
            {
                connection.Open();
                string query = "SELECT nome, endereco, telefone, email FROM clientes WHERE clienteid = @clienteid";

                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("clienteid", clienteId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Preenche os campos com os dados do cliente
                            TxtNome.Text = reader.GetString(0);
                            TxtEndereco.Text = reader.GetString(1);
                            TxtTelefone.Text = reader.GetString(2);
                            TxtEmail.Text = reader.GetString(3);
                        }
                        else
                        {
                            MessageBox.Show("Cliente não encontrado!");
                        }
                    }
                }
            }
        }

        private void BtnCarregarCliente_Click(object sender, EventArgs e)
        {
            clienteId = int.Parse(TxtClienteid.Text);
            CarregarClienteParaEdicao(clienteId);

        }

        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            // Confirmação antes de excluir
            var confirmResult = MessageBox.Show("Tem certeza de que deseja excluir este cliente?",
                                                 "Confirmar Exclusão",
                                                 MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                using (var connection = DatabaseConfig.GetConnection())
                {
                    try
                    {
                        connection.Open();

                        // Query SQL para deletar o Cliente
                        string query = "DELETE FROM clientes WHERE clienteid = @clienteid";

                        using (var cmd = new NpgsqlCommand(query, connection))
                        {
                            cmd.Parameters.AddWithValue("clienteid", clienteId);

                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Cliente excluído com sucesso!");
                                // Limpa campos
                                TxtNome.Clear();
                                TxtEndereco.Clear();
                                TxtTelefone.Clear();
                                TxtEmail.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Erro ao excluir o cliente. Cliente não encontrado.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao excluir o cliente: " + ex.Message);
                    }
                }
            }
        }

        private void EditarCliente()
        {
            // Captura os dados dos campos de entrada
            string nome = TxtNome.Text;
            string endereco = TxtEndereco.Text;
            string telefone = TxtTelefone.Text;
            string email = TxtEmail.Text;

            using (var connection = DatabaseConfig.GetConnection())
            {
                connection.Open();

                string query = "UPDATE clientes SET nome = @nome, endereco = @endereco, telefone = @telefone, email = @email WHERE clienteid = @clienteid";

                using (var cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("nome", nome);
                    cmd.Parameters.AddWithValue("endereco", endereco);
                    cmd.Parameters.AddWithValue("telefone", telefone);
                    cmd.Parameters.AddWithValue("email", email);
                    cmd.Parameters.AddWithValue("clienteid", clienteId);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cliente atualizado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atualizar o cliente.");
                    }
                }
            }
        }


        private void BtnEditar_Click(object sender, EventArgs e)
        {
            EditarCliente();

            // Limpar campos
            TxtNome.Clear();
            TxtEndereco.Clear();
            TxtTelefone.Clear();
            TxtEmail.Clear();
        }
    }
}
