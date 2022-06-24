using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSupriMed.Code.DTO
{
    public partial class VendedoresDTO
    {
        public VendedoresDTO()
        {
            this.VENDAS = new HashSet<VendasDTO>();
            this.VISITAS = new HashSet<VisitasDTO>();
        }

        public int VEND_ID { get; set; }
        public string FUNC_CPF { get; set; }
        public double VEND_COMISSAO { get; set; }

        public virtual FuncionariosDTO FUNCIONARIOS { get; set; }

        public virtual ICollection<VendasDTO> VENDAS { get; set; }

        public virtual ICollection<VisitasDTO> VISITAS { get; set; }
    }
}