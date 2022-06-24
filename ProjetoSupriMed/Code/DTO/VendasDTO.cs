using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSupriMed.Code.DTO
{
    public partial class VendasDTO
    {
        public VendasDTO()
        {
            this.VENDAS_ITENS = new HashSet<VendasItensDTO>();
        }

        public int VEN_ID { get; set; }
        public string CLI_CPF { get; set; }
        public int VEND_ID { get; set; }
        public Nullable<System.DateTime> VEN_DTEMISSAO { get; set; }
        public Nullable<decimal> VEN_VALOR { get; set; }
        public Nullable<decimal> VEN_DESCONTO { get; set; }
        public Nullable<decimal> VEN_VALORPAGO { get; set; }

        public virtual ClientesDTO CLIENTES { get; set; }
        public virtual ICollection<VendasItensDTO> VENDAS_ITENS { get; set; }
        public virtual VendedoresDTO VENDEDORES { get; set; }
    }
}
