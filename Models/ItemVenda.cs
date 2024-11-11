using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciamentoClientesProdutos.Models
{
    public class ItemVenda
    {
        public int ItemVendaID { get; set; }
        public int VendaID { get; set; }
        public int ProdutoID { get; set; }
        public int Quantidade { get; set; }
    }
}
