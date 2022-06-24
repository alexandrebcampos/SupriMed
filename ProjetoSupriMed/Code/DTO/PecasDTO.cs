using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSupriMed.Code.DTO
{
    public partial class PecasDTO
    {
        public PecasDTO()
        {
            this.PRODUTOS = new HashSet<ProdutosDTO>();
        }

        public int PEC_ID { get; set; }
        public string PEC_NOME { get; set; }
        public string PEC_FABRICANTE { get; set; }
        public decimal PEC_QUANTIDADE { get; set; }

        
        public virtual ICollection<ProdutosDTO> PRODUTOS { get; set; }
    }
}
