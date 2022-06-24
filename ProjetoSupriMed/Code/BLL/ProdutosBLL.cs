using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProjetoSupriMed.Code.DAL;
using ProjetoSupriMed.Code.DTO;
using System.Data;
using System.Windows.Forms;

namespace ProjetoSupriMed.Code.BLL
{
    public class ProdutosBLL
    {
        public virtual int Salvar(ProdutosDTO prod)
        {
            try
            {

                ConexaoDAL conexaodao = new ConexaoDAL();
                conexaodao.Conectar();

                SqlCommand commando = new SqlCommand();

                commando.Connection = conexaodao.Conexao;

                commando.CommandText = @"
INSERT INTO PRODUTOS(
PROD_NOME,
PROD_CATEGORIA,
PROD_DESCRICAO,
PROD_ESTOQUE,
PROD_VLUNIT,
PROD_VFINAL
) VALUES (@PROD_NOME,@PROD_CATEGORIA,@PROD_DESCRICAO,@PROD_ESTOQUE,@PROD_VLUNIT, @PROD_VFINAL); SELECT CAST(scope_identity() AS int)";

                commando.Parameters.Add("@PROD_NOME", SqlDbType.VarChar, 100);
                commando.Parameters["@PROD_NOME"].Value = prod.PROD_NOME;

                commando.Parameters.Add("@PROD_CATEGORIA", SqlDbType.VarChar, 100);
                commando.Parameters["@PROD_CATEGORIA"].Value = prod.PROD_CATEGORIA;

                commando.Parameters.Add("@PROD_DESCRICAO", SqlDbType.VarChar, 100);
                commando.Parameters["@PROD_DESCRICAO"].Value = prod.PROD_DESCRICAO;

                commando.Parameters.Add("@PROD_ESTOQUE", SqlDbType.VarChar, 50);
                commando.Parameters["@PROD_ESTOQUE"].Value = prod.PROD_ESTOQUE;

                commando.Parameters.Add("@PROD_VLUNIT", SqlDbType.Money, 100);
                commando.Parameters["@PROD_VLUNIT"].Value = prod.PROD_VLUNIT;

                commando.Parameters.Add("@PROD_VFINAL", SqlDbType.Money, 100);
                commando.Parameters["@PROD_VFINAL"].Value = prod.PROD_VFINAL;

                int modified = (int)commando.ExecuteScalar();

                MessageBox.Show("Cadastro Efetuado Com Sucesso");

                conexaodao.Desconectar();

                return modified;


            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                return 0;
            }

        }

        public virtual void SalvarPeca(int IDproduto, int IDpeca)
        {

            try
            {

                ConexaoDAL conexaodao = new ConexaoDAL();
                conexaodao.Conectar();

                SqlCommand commando = new SqlCommand();
                commando.Connection = conexaodao.Conexao;

                commando.CommandText = @"
INSERT INTO PRODUTOS_PECAS(
PROD_ID
,PEC_ID

) VALUES (
@PROD_ID,@PEC_ID)";


                commando.Parameters.Add("@PROD_ID", SqlDbType.Int);
                commando.Parameters["@PROD_ID"].Value = IDproduto;
                commando.Parameters.Add("@PEC_ID", SqlDbType.Int);
                commando.Parameters["@PEC_ID"].Value = IDpeca;


                commando.ExecuteNonQuery();

                conexaodao.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }

        }


        public virtual void Excluir(ProdutosDTO prod)
        {
            try
            {
                ConexaoDAL conexaodao = new ConexaoDAL();
                conexaodao.Conectar();

                SqlCommand commando = new SqlCommand();

                commando.Connection = conexaodao.Conexao;

                commando.CommandText = "DELETE FROM PRODUTOS WHERE PROD_ID = @PROD_ID ";
                commando.Parameters.Add("@PROD_ID", SqlDbType.Int);
                commando.Parameters["@PROD_ID"].Value = prod.PROD_ID;

                commando.ExecuteNonQuery();

                conexaodao.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }

        }



    }
}

