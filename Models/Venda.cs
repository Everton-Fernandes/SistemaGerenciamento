using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGerenciamentoClientesProdutos.Models
{
    public class Venda
    {
        public int VendaID { get; set; }
        public int ClienteID { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataVenda { get; set; }
    }
}
