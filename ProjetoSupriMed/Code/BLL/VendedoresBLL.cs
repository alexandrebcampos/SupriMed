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
    
    public class VendedoresBLL
    {
        ConexaoDAL con;
        public void Salvar(VendedoresDTO vendedor)
        {
            con = new ConexaoDAL();
            try
            {
                con = new ConexaoDAL();
                con.Conectar();

                SqlCommand commando = new SqlCommand();
                commando.Connection = con.Conexao;

                commando.CommandText = "INSERT INTO VENDEDORES (FUNC_CPF,VEND_COMISSAO)VALUES (@FUNC_CPF,@VEND_COMISSAO)";
                commando.Parameters.Add("@FUNC_CPF", SqlDbType.VarChar, 15);
                commando.Parameters["@FUNC_CPF"].Value = vendedor.FUNC_CPF;

                commando.Parameters.Add("@VEND_COMISSAO", SqlDbType.Float);
                commando.Parameters["@VEND_COMISSAO"].Value = vendedor.VEND_COMISSAO;

                commando.ExecuteNonQuery();

                con.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }


        }

        public void Atualizar(VendedoresDTO vendedor)
        {
            try
            {
                con = new ConexaoDAL();
                con.Conectar();

                SqlCommand commando = new SqlCommand();
                commando.Connection = con.Conexao;

                commando.CommandText = "UPDATE VENDEDORES SET FUNC_CPF = @FUNC_CPF,VEND_COMISSAO = @VEND_COMISSAO WHERE FUNC_CPF = @FUNC_CPF ";

                commando.Parameters.Add("@FUNC_CPF", SqlDbType.VarChar, 15);
                commando.Parameters["@FUNC_CPF"].Value = vendedor.FUNC_CPF;

                commando.Parameters.Add("@VEND_COMISSAO", SqlDbType.Float);
                commando.Parameters["@VEND_COMISSAO"].Value = vendedor.VEND_COMISSAO;



                commando.ExecuteNonQuery();

                con.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
        }

        public DataTable CarregaComboVendedor()
        {
            DataTable dtV = new DataTable("FUNCIONARIOS");
            using (SqlConnection Connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=SUPRIMEDICO;Persist Security Info=True;User ID=sa;Password=064871"))
            using (SqlCommand Command = new SqlCommand("SELECT F.FUNC_NOME, V.FUNC_CPF,V.VEND_COMISSAO FROM VENDEDORES V INNER JOIN FUNCIONARIOS F ON F.FUNC_CPF = v.FUNC_CPF where F.SET_ID = 4 ", Connection))
            {
                Connection.Open();
                dtV.Load(Command.ExecuteReader());
            }
            return dtV;
        }
    }
}
