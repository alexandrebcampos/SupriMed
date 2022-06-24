using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoSupriMed.Code.DAL;
using System.Data;
using ProjetoSupriMed.Code.DTO;
using System.Data.SqlClient;

namespace ProjetoSupriMed.Code.BLL
{
    public class AutenticarBLL
    {
        ConexaoDAL conexaodao;

        public bool AutenticarUsuario(LoginDTO login)
        {
            try
            {
                conexaodao = new ConexaoDAL();

                SqlCommand cmd = new SqlCommand("select * from LOGIN where LOG_USUARIO = @LOG_USUARIO AND LOG_SENHA = @LOG_SENHA", conexaodao.Conexao);

                SqlParameter parametroUsuario = new SqlParameter("@LOG_USUARIO", SqlDbType.VarChar, 50);
                parametroUsuario.Value = login.LOG_USUARIO;
                cmd.Parameters.Add(parametroUsuario);

                SqlParameter parametroSenha = new SqlParameter("@LOG_SENHA", SqlDbType.VarChar, 6);
                parametroSenha.Value = login.LOG_SENHA;
                cmd.Parameters.Add(parametroSenha);

                //SqlParameter parametroPrivilegio = new SqlParameter("@LOG_PRIVILEGIO", SqlDbType.VarChar, 6);
                //parametroPrivilegio.Value = login.LOG_PRIVILEGIO;
                //cmd.Parameters.Add(parametroPrivilegio);

                conexaodao.Conexao.Open();

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    //usuario existe
                    return true;
                }
                else
                {
                    //usuario nao existe
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }

        public bool VerificaUsuario(string user)
        {
            ConexaoDAL conn = new ConexaoDAL();
            DataTable dt = new DataTable("LOGIN");
            using (SqlCommand Command = new SqlCommand("SELECT LOG_USUARIO FROM LOGIN WHERE LOG_USUARIO = @LOG_USUARIO", conn.Conexao))
            {
                Command.Parameters.Add("@LOG_USUARIO", SqlDbType.VarChar, 15);
                Command.Parameters["@LOG_USUARIO"].Value = user;

                conn.Conexao.Open();
                dt.Load(Command.ExecuteReader());
            }
            return true;
        }




    }
}
