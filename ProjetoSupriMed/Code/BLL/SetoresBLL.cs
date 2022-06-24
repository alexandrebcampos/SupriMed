using ProjetoSupriMed.Code.DAL;
using ProjetoSupriMed.Code.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSupriMed.Code.BLL
{
    public class SetoresBLL
    {
        ConexaoDAL con;
        public void Salvar(SetoresDTO setor)
        {
            try
            {
                con = new ConexaoDAL();
                con.Conectar();

                SqlCommand commando = new SqlCommand();
                commando.Connection = con.Conexao;

                commando.CommandText = "INSERT INTO SETORES(SET_NOME)VALUES (@SET_NOME)";
                commando.Parameters.Add("@SET_NOME", SqlDbType.VarChar, 100);
                commando.Parameters["@SET_NOME"].Value = setor.SET_NOME;

                commando.ExecuteNonQuery();

                con.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }


        }

        public void Atualizar(SetoresDTO setor)
        {
            try
            {
                con = new ConexaoDAL();
                con.Conectar();

                SqlCommand commando = new SqlCommand();
                commando.Connection = con.Conexao;

                commando.CommandText = "UPDATE SETORES SET SET_NOME = @SET_NOME WHERE SET_ID = @SET_ID ";

                commando.Parameters.Add("@SET_ID", SqlDbType.Int);
                commando.Parameters["@SET_ID"].Value = setor.SET_ID;

                commando.Parameters.Add("@SET_NOME", SqlDbType.VarChar, 100);
                commando.Parameters["@SET_NOME"].Value = setor.SET_NOME;



                commando.ExecuteNonQuery();

                con.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
        }
    }
}
