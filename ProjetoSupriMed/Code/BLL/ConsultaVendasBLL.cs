using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoSupriMed.Code.DAL;
using ProjetoSupriMed.Code.DTO;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace ProjetoSupriMed.Code.BLL
{
    public class ConsultaVendasBLL
    {
        ConexaoDAL con;
        public DataTable GetCliente(DataGridView data,TextBox textbox)
        {
            DataTable dt = new DataTable();
            try
            {
                string strSql = "SELECT C.CLI_PRIMNOME,P.PROD_NOME,I.VENDA_ITENS_QTO,I.VENDA_ITENS_TOTAL,I.VENDA_ITENS_VLUNIT,V.VEN_DTEMISSAO,V.VEN_DESCONTO,V.VEN_VALORPAGO FROM CLIENTES C INNER JOIN VENDAS V ON V.CLI_CPF = C.CLI_CPF INNER JOIN VENDAS_ITENS I ON V.VEN_ID = I.VEN_ID INNER JOIN PRODUTOS P ON I.PROD_ID = P.PROD_ID WHERE C.CLI_PRIMNOME LIKE '" + textbox.Text + "'";

                con = new ConexaoDAL();
                SqlCommand cmd = new SqlCommand(strSql, con.Conexao);
                con.Conexao.Open();
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                data.DataSource = dt;

               
            

            }
            catch(Exception)
            {

            }

            return dt;
        }

        public DataTable GetVendedor(DataGridView data, TextBox textbox)
        {
            DataTable dt = new DataTable();
            try
            {
                string strSql = "SELECT F.FUNC_NOME, C.CLI_PRIMNOME, P.PROD_NOME,I.VENDA_ITENS_QTO,I.VENDA_ITENS_TOTAL,I.VENDA_ITENS_VLUNIT,V.VEN_DTEMISSAO,V.VEN_DESCONTO,V.VEN_VALORPAGO FROM VENDEDORES VEN INNER JOIN VENDAS V ON V.VEND_ID = VEN.VEND_ID INNER JOIN VENDAS_ITENS I ON V.VEN_ID = I.VEN_ID INNER JOIN PRODUTOS P ON I.PROD_ID = P.PROD_ID INNER JOIN FUNCIONARIOS F ON F.FUNC_CPF = VEN.FUNC_CPF INNER JOIN CLIENTES C ON C.CLI_CPF = V.CLI_CPF WHERE F.FUNC_NOME LIKE '" + textbox.Text + "'";

                con = new ConexaoDAL();
                SqlCommand cmd = new SqlCommand(strSql, con.Conexao);
                con.Conexao.Open();
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                data.DataSource = dt;


            }
            catch (Exception)
            {

            }

            return dt;
        }

        public DataTable GetProduto(DataGridView data, TextBox textbox)
        {
            DataTable dt = new DataTable();
            try
            {
                string strSql = "SELECT F.FUNC_NOME, C.CLI_PRIMNOME, P.PROD_NOME,I.VENDA_ITENS_QTO,I.VENDA_ITENS_TOTAL,I.VENDA_ITENS_VLUNIT,V.VEN_DTEMISSAO,V.VEN_DESCONTO,V.VEN_VALORPAGO FROM VENDEDORES VEN INNER JOIN VENDAS V ON V.VEND_ID = VEN.VEND_ID INNER JOIN VENDAS_ITENS I ON V.VEN_ID = I.VEN_ID INNER JOIN PRODUTOS P ON I.PROD_ID = P.PROD_ID INNER JOIN FUNCIONARIOS F ON F.FUNC_CPF = VEN.FUNC_CPF INNER JOIN CLIENTES C ON C.CLI_CPF = V.CLI_CPF WHERE P.PROD_NOME LIKE '" + textbox.Text + "'";

                con = new ConexaoDAL();
                SqlCommand cmd = new SqlCommand(strSql, con.Conexao);
                con.Conexao.Open();
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                data.DataSource = dt;



            }
            catch (Exception)
            {

            }

            return dt;
        }
    }
}
