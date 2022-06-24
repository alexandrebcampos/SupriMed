using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSupriMed.Code.DTO
{
    public partial class LoginDTO
    {
        public int LOG_ID { get; set; }
        public string FUNC_CPF { get; set; }
        public string LOG_USUARIO { get; set; }
        public string LOG_SENHA { get; set; }
        public string LOG_PRIVILEGIO { get; set; }
        public System.DateTime LOG_DATACADASTRO { get; set; }
        public System.DateTime LOG_ATUALIZADOEM { get; set; }

        public virtual FuncionariosDTO FUNCIONARIOS { get; set; }
    }
}
