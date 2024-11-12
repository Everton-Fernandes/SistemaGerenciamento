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
    public partial class FormVendas : Form
    {
        public FormVendas()
        {
            InitializeComponent();

            LoadComboBox();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            // Captura os dados do formulário
            int clienteId = Convert.ToInt32(CBCliente.SelectedValue); 
            int produtoId = Convert.ToInt32(CBProduto.SelectedValue); 
            int quantidade = int.Parse(TxtQuantidade.Text);
            DateTime dataVenda = DTVenda.Value;

            // Cria uma instância do DatabaseHelper
            var db = new DatabaseHelper();

            // Chama o método para adicionar uma venda no DatabaseHelper
            db.AddVenda(clienteId, produtoId, quantidade, dataVenda);

            // Exibe uma mensagem de sucesso
            MessageBox.Show("Venda salva com sucesso!");

            // Limpa os campos após salvar
            CBCliente.SelectedIndex = -1;
            CBProduto.SelectedIndex = -1;
            TxtQuantidade.Clear();
            DTVenda.Value = DateTime.Now;
        }

        private void BtnListar_Click(object sender, EventArgs e)
        {
            var db = new DatabaseHelper();
            DataTable clientes = db.GetClientes();
            GVvendas.DataSource = clientes;
        }

        private void LoadComboBox()
        {
            DatabaseHelper db = new DatabaseHelper();

            CBCliente.DataSource = db.GetClientes();
            CBCliente.DisplayMember = "nome";
            CBCliente.ValueMember = "clienteid";
            CBProduto.DataSource = db.GetProdutos();
            CBProduto.DisplayMember = "nome";
            CBProduto.ValueMember = "produtoid";
        }
    }
}
