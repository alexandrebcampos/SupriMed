using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSupriMed.Code.DTO
{
    public partial class SetoresDTO
    {
        public SetoresDTO()
        {
            this.FUNCIONARIOS = new HashSet<FuncionariosDTO>();
        }

        public int SET_ID { get; set; }
        public string SET_NOME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FuncionariosDTO> FUNCIONARIOS { get; set; }

    }
}
