using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSupriMed.Code.DTO
{
    public partial class FuncionariosDTO
    {
        public FuncionariosDTO()
        {
            this.LOGIN = new HashSet<LoginDTO>();
            this.VENDEDORES = new HashSet<VendedoresDTO>();
        }

        public string FUNC_CPF { get; set; }
        public int SET_ID { get; set; }
        public string FUNC_NOME { get; set; }
        public System.DateTime FUNC_DATANASC { get; set; }
        public string FUNC_EMAIL { get; set; }
        public string FUNC_ENDERECO { get; set; }
        public string FUNC_BAIRRO { get; set; }
        public string FUNC_CIDADE { get; set; }
        public string FUNC_ESTADO { get; set; }
        public decimal FUNC_TELEFONE { get; set; }
        public double FUNC_SALARIO { get; set; }

        public virtual ICollection<LoginDTO> LOGIN { get; set; }
        public virtual ICollection<VendedoresDTO> VENDEDORES { get; set; }
        public virtual SetoresDTO SETORES { get; set; }
    }
}