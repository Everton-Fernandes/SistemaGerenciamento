using SistemaGerenciamentoClientesProdutos.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGerenciamentoClientesProdutos
{
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();
        }

        private void BtnClientes_Click(object sender, EventArgs e)
        {

        }

        private void BtnProdutos_Click(object sender, EventArgs e)
        {

        }

        private void BtnVendas_Click(object sender, EventArgs e)
        {
            FormVendas formVendas = new FormVendas();

            formVendas.Show();
        }
    }
}
