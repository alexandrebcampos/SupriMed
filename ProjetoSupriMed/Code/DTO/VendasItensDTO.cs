using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSupriMed.Code.DTO
{
    public class VendasItensDTO
    {

        public int VENDA_ITENS_ID { get; set; }
        public int VEN_ID { get; set; }
        public int PROD_ID { get; set; }
        public int VENDA_ITENS_QTO { get; set; }
        public decimal VENDA_ITENS_VLUNIT { get; set; }
        public decimal VENDA_ITENS_TOTAL { get; set; }

        public virtual ProdutosDTO PRODUTOS { get; set; }
        public virtual VendasDTO VENDAS { get; set; }

       

    }
}
