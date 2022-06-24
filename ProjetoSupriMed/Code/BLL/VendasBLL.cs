using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoSupriMed.Code.DTO;
using ProjetoSupriMed.Code.DAL;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProjetoSupriMed.Code.BLL
{
    public class VendasBLL
    {
        ConexaoDAL con;

        //metodo que vou chamar no botão Nova Venda
        public void SalvarVendas(VendasDTO vendas)
        {
           
            try
            {
                con = new ConexaoDAL();
                con.Conectar();

                SqlCommand commando = new SqlCommand();
                commando.Connection = con.Conexao;


                commando.CommandText = "INSERT INTO VENDAS(CLI_CPF)VALUES (@CLI_CPF)";
                   

                commando.Parameters.Add("@CLI_CPF", SqlDbType.VarChar, 15);
                commando.Parameters["@CLI_CPF"].Value = vendas.CLI_CPF;



                commando.ExecuteNonQuery();

                con.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }


        }

        //metodo que vou chamar no botão add item
        public void SalvarItensVendas(VendasItensDTO itens)
        {
            try
            {
                con = new ConexaoDAL();
                con.Conectar();

                SqlCommand commando = new SqlCommand();
                commando.Connection = con.Conexao;

                commando.CommandText = "INSERT INTO VENDAS_ITENS(VEN_ID,PROD_ID,VENDA_ITENS_QTO,VENDA_ITENS_VLUNIT,VENDA_ITENS_TOTAL)VALUES (@VEN_ID,@PROD_ID,@VENDA_ITENS_QTO,@VENDA_ITENS_VLUNIT,@VENDA_ITENS_TOTAL)";

                commando.Parameters.Add("@VEN_ID", SqlDbType.Int);
                commando.Parameters["@VEN_ID"].Value = itens.VEN_ID;

                commando.Parameters.Add("@PROD_ID", SqlDbType.Int);
                commando.Parameters["@PROD_ID"].Value = itens.PROD_ID;

                commando.Parameters.Add("@VENDA_ITENS_QTO", SqlDbType.Int);
                commando.Parameters["@VENDA_ITENS_QTO"].Value = itens.VENDA_ITENS_QTO;

                commando.Parameters.Add("@VENDA_ITENS_VLUNIT", SqlDbType.Money);
                commando.Parameters["@VENDA_ITENS_VLUNIT"].Value = itens.VENDA_ITENS_VLUNIT;

                commando.Parameters.Add("@VENDA_ITENS_TOTAL", SqlDbType.Money);
                commando.Parameters["@VENDA_ITENS_TOTAL"].Value = itens.VENDA_ITENS_TOTAL;


                commando.ExecuteNonQuery();

                con.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }

        }

        //meotodo que vou chamar no botão finalizar venda
        public void Atualizar(VendasDTO vendas)
        {
            try
            {
                con = new ConexaoDAL();
                con.Conectar();

                SqlCommand commando = new SqlCommand();
                commando.Connection = con.Conexao;

                commando.CommandText = "UPDATE VENDAS SET CLI_CPF = @CLI_CPF,VEND_ID = @VEND_ID,VEN_DTEMISSAO = @VEN_DTEMISSAO,VEN_VALOR = @VEN_VALOR,VEN_DESCONTO = @VEN_DESCONTO,VEN_VALORPAGO = @VEN_VALORPAGO WHERE CLI_CPF = @CLI_CPF";

                commando.Parameters.Add("@CLI_CPF", SqlDbType.VarChar, 15);
                commando.Parameters["@CLI_CPF"].Value = vendas.CLI_CPF;

                commando.Parameters.Add("@VEND_ID", SqlDbType.Int);
                commando.Parameters["@VEND_ID"].Value = vendas.VEND_ID;

                commando.Parameters.Add("@VEN_DTEMISSAO", SqlDbType.Date);
                commando.Parameters["@VEN_DTEMISSAO"].Value = vendas.VEN_DTEMISSAO;

                commando.Parameters.Add("@VEN_VALOR", SqlDbType.Money);
                commando.Parameters["@VEN_VALOR"].Value = vendas.VEN_VALOR;

                commando.Parameters.Add("@VEN_DESCONTO", SqlDbType.Money);
                commando.Parameters["@VEN_DESCONTO"].Value = vendas.VEN_DESCONTO;

                commando.Parameters.Add("@VEN_VALORPAGO", SqlDbType.Money);
                commando.Parameters["@VEN_VALORPAGO"].Value = vendas.VEN_VALORPAGO;

                commando.ExecuteNonQuery();

                con.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
        }

        public DataTable CarregaComboClientes()
        {
            con = new ConexaoDAL();
            DataTable dt = new DataTable("CLIENTES");
            //using (SqlConnection Connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=SUPRIMEDICO;Persist Security Info=True;User ID=sa;Password=064871"))
            using (SqlCommand Command = new SqlCommand("SELECT CLI_CPF, CLI_PRIMNOME FROM CLIENTES ORDER BY CLI_PRIMNOME", con.Conexao))
            {
                con.Conexao.Open();
                dt.Load(Command.ExecuteReader());
            }
            return dt;
        }

        public DataTable CarregaComboProdutos()
        {
            con = new ConexaoDAL();
            DataTable dtp = new DataTable();
            using (SqlCommand Command = new SqlCommand("SELECT PROD_ID,PROD_NOME,PROD_VLUNIT FROM PRODUTOS ORDER BY PROD_NOME", con.Conexao))
            {
                con.Conexao.Open();
                dtp.Load(Command.ExecuteReader());
            }

            return dtp;
        }

        public DataTable CarregaComboVendedor()
        {
            DataTable dtv = new DataTable();
            using (SqlConnection Connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=SUPRIMEDICO;Persist Security Info=True;User ID=sa;Password=064871"))
            using (SqlCommand Command = new SqlCommand("SELECT V.VEND_ID, F.FUNC_NOME FROM FUNCIONARIOS F INNER JOIN VENDEDORES V ON V.FUNC_CPF = F.FUNC_CPF ORDER BY F.FUNC_NOME", Connection))
            {
                Connection.Open();
                dtv.Load(Command.ExecuteReader());
            }
            return dtv;
        }

       
    }
}
