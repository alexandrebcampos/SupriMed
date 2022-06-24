using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSupriMed.Code.DTO
{
    public static class UsuarioLogadoDTO
    {
        private static string _logado ="";
        private static string _nivel = "";

        public static string Nivel
        {
            get
            {
                return _nivel;
            }

            set
            {
                _nivel = value;
            }
        }

        public static string UsuarioLogado
        {
            get
            {
                return _logado;
            }
            set
            {
                _logado = value;
            }
        }

        

    }
}
