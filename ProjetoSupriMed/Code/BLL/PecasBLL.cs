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
    class PecasBLL
    {
        ConexaoDAL conn;
        public void Salvar(PecasDTO pec)
        {
            try
            {
                conn = new ConexaoDAL();
                conn.Conectar();

                SqlCommand commando = new SqlCommand();
                commando.Connection = conn.Conexao;

                commando.CommandText = @"
INSERT INTO PECAS(

PEC_NOME
,PEC_FABRICANTE
,PEC_QUANTIDADE
                            
) VALUES (
@PEC_NOME,@PEC_FABRICANTE,@PEC_QUANTIDADE)";



                commando.Parameters.Add("@PEC_NOME", SqlDbType.VarChar, 100);
                commando.Parameters["@PEC_NOME"].Value = pec.PEC_NOME;
                commando.Parameters.Add("@PEC_FABRICANTE", SqlDbType.VarChar, 100);
                commando.Parameters["@PEC_FABRICANTE"].Value = pec.PEC_FABRICANTE;
                commando.Parameters.Add("@PEC_QUANTIDADE", SqlDbType.Int);
                commando.Parameters["@PEC_QUANTIDADE"].Value = pec.PEC_QUANTIDADE;


                commando.ExecuteNonQuery();

                conn.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }

        }

        public void Excluir(PecasDTO pec)
        {
            try
            {
                conn = new ConexaoDAL();
                conn.Conectar();

                SqlCommand commando = new SqlCommand();
                commando.Connection = conn.Conexao;

                commando.CommandText = "DELETE FROM PECAS WHERE PEC_ID = @PEC_ID ";
                commando.Parameters.Add("@PEC_ID", SqlDbType.Int);
                commando.Parameters["@PEC_ID"].Value = pec.PEC_ID;

                commando.ExecuteNonQuery();

                conn.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }

        }

        public void AtualizaPeca(PecasDTO pec)
        {
            try
            {
                conn = new ConexaoDAL();
                conn.Conectar();

                SqlCommand commando = new SqlCommand();
                commando.Connection = conn.Conexao;

                commando.CommandText = "UPDATE PECAS SET PEC_ID = @PEC_ID, PEC_NOME = @PEC_NOME, PEC_FABRICANTE = @PEC_FABRICANTE, PEC_QUANTIDADE = @PEC_QUANTIDADE  WHERE PEC_ID = @PEC_ID";

                commando.Parameters.Add("@PEC_ID", SqlDbType.Int);
                commando.Parameters["@PEC_ID"].Value = pec.PEC_ID;

                commando.Parameters.Add("@PEC_NOME", SqlDbType.VarChar, 100);
                commando.Parameters["@PEC_NOME"].Value = pec.PEC_NOME;

                commando.Parameters.Add("@PEC_FABRICANTE", SqlDbType.VarChar, 100);
                commando.Parameters["@PEC_FABRICANTE"].Value = pec.PEC_FABRICANTE;

                commando.Parameters.Add("@PEC_QUANTIDADE", SqlDbType.Int, 18);
                commando.Parameters["@PEC_QUANTIDADE"].Value = pec.PEC_QUANTIDADE;


                commando.ExecuteNonQuery();

                conn.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
        }

        public List<PecasDTO> Buscar(PecasDTO pec)
        {
            try
            {
                string strSql = "SELECT * FROM PECAS";
                bool primeiroWhere = true;
                if (pec != null)
                {
                    if (pec.PEC_FABRICANTE != "")
                    {
                        strSql += " WHERE PEC_FABRICANTE LIKE '%" + pec.PEC_FABRICANTE + "%'";
                        primeiroWhere = false;
                    }
                    if (pec.PEC_NOME != "")
                    {
                        if (!primeiroWhere)
                            strSql += "AND PEC_NOME LIKE '%" + pec.PEC_NOME + "%'";
                        else
                        {
                            strSql += " WHERE PEC_NOME = '" + pec.PEC_NOME + "'";
                            primeiroWhere = false;
                        }
                    }
                    if (pec.PEC_QUANTIDADE > 0)
                    {
                        if (!primeiroWhere)
                            strSql += "AND PEC_QUANTIDADE = " + pec.PEC_QUANTIDADE;
                        else
                        {
                            strSql += " WHERE PEC_QUANTIDADE =" + pec.PEC_QUANTIDADE;
                        }
                    }
                }

                ConexaoDAL con = new ConexaoDAL();

                con = new ConexaoDAL();
                SqlCommand cmd = new SqlCommand(strSql, con.Conexao);
                con.Conexao.Open();
                cmd.CommandText = strSql;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                List<PecasDTO> lista = new List<PecasDTO>();
                PecasDTO peca;

                foreach (DataRow row in dataSet.Tables[0].Rows)
                {
                    peca = new PecasDTO();
                    peca.PEC_NOME = row["PEC_NOME"].ToString();
                    peca.PEC_FABRICANTE = row["PEC_FABRICANTE"].ToString();
                    peca.PEC_QUANTIDADE = decimal.Parse(row["PEC_QUANTIDADE"].ToString());
                    peca.PEC_ID = int.Parse(row["PEC_ID"].ToString());

                    lista.Add(peca);
                }

                return lista;


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

    }
}

