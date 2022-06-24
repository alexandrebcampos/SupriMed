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
    class ClienteBLL
    {
        ConexaoDAL conn;
        public void  Salvar(ClientesDTO cli)
        {           
            try
            {

                conn = new ConexaoDAL();
                conn.Conectar();

                SqlCommand commando = new SqlCommand();
                commando.Connection = conn.Conexao;

                //commando.CommandText = "INSERT INTO Cursos(curCodigo,curDescricao,curProfessor,curPreco) VALUES('" + cpf + "', '" + nome + "', '" + sobrenome + "', '" + 
                // dataNasc + "' + '" + email + "' + '" + endereco + "'+ '" + bairro + '" + "' + )";
                commando.CommandText = @"
INSERT INTO CLIENTES(
CLI_CPF
,CLI_PRIMNOME
,CLI_ULTNOME
,CLI_DATANASC
,CLI_EMAIL
,CLI_ENDERECO
,CLI_BAIRRO
,CLI_CIDADE
,CLI_ESTADO
,CLI_TELEFONE
,CLI_SEXO
,CLI_CASANUMERO
) VALUES (
@CLI_CPF,@CLI_PRIMNOME,@CLI_ULTNOME,@CLI_DATANASC,@CLI_EMAIL,@CLI_ENDERECO,@CLI_BAIRRO,@CLI_CIDADE,@CLI_ESTADO,@CLI_TELEFONE,@CLI_SEXO,@CLI_CASANUMERO)";


                commando.Parameters.Add("@CLI_CPF", SqlDbType.VarChar,15);
                commando.Parameters["@CLI_CPF"].Value = cli.CLI_CPF;
                commando.Parameters.Add("@CLI_PRIMNOME", SqlDbType.VarChar, 100);
                commando.Parameters["@CLI_PRIMNOME"].Value = cli.CLI_PRIMNOME;
                commando.Parameters.Add("@CLI_ULTNOME", SqlDbType.VarChar, 100);
                commando.Parameters["@CLI_ULTNOME"].Value = cli.CLI_ULTNOME;
                commando.Parameters.Add("@CLI_DATANASC", SqlDbType.Date);
                commando.Parameters["@CLI_DATANASC"].Value = cli.CLI_DATANASC;
                commando.Parameters.Add("@CLI_EMAIL", SqlDbType.VarChar, 50);
                commando.Parameters["@CLI_EMAIL"].Value = cli.CLI_EMAIL;
                commando.Parameters.Add("@CLI_ENDERECO", SqlDbType.VarChar, 100);
                commando.Parameters["@CLI_ENDERECO"].Value = cli.CLI_ENDERECO;
                commando.Parameters.Add("@CLI_BAIRRO", SqlDbType.VarChar, 100);
                commando.Parameters["@CLI_BAIRRO"].Value = cli.CLI_BAIRRO;
                commando.Parameters.Add("@CLI_CIDADE", SqlDbType.VarChar, 100);
                commando.Parameters["@CLI_CIDADE"].Value = cli.CLI_CIDADE;
                commando.Parameters.Add("@CLI_ESTADO", SqlDbType.Char, 2);
                commando.Parameters["@CLI_ESTADO"].Value = cli.CLI_ESTADO;
                commando.Parameters.Add("@CLI_TELEFONE", SqlDbType.Decimal);
                commando.Parameters["@CLI_TELEFONE"].Value = cli.CLI_TELEFONE;
                commando.Parameters.Add("@CLI_SEXO", SqlDbType.Char, 1);
                commando.Parameters["@CLI_SEXO"].Value = cli.CLI_SEXO;
                commando.Parameters.Add("@CLI_CASANUMERO", SqlDbType.Int);
                commando.Parameters["@CLI_CASANUMERO"].Value = cli.CLI_CASANUMERO;


                commando.ExecuteNonQuery();
                              
                conn.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
           
        }
        public void Excluir(ClientesDTO cli)
        {
            try
            {
                conn = new ConexaoDAL();
                conn.Conectar();

                SqlCommand commando = new SqlCommand();
                commando.Connection = conn.Conexao;

                commando.CommandText = "DELETE FROM CLIENTES WHERE CLI_CPF = @CLI_CPF ";
                commando.Parameters.Add("@CLI_CPF", SqlDbType.VarChar);
                commando.Parameters["@CLI_CPF"].Value = cli.CLI_CPF;
                                
                commando.ExecuteNonQuery();

                conn.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }

        }
        public void Atualizar(ClientesDTO cli)
        {
            try
            {
                conn = new ConexaoDAL();
                conn.Conectar();

                SqlCommand commando = new SqlCommand();
                commando.Connection = conn.Conexao;

                commando.CommandText = "UPDATE CLIENTES SET CLI_CPF = @CLI_CPF, CLI_PRIMNOME = @CLI_PRIMNOME, CLI_ULTNOME = @CLI_ULTNOME, CLI_DATANASC = @CLI_DATANASC, CLI_EMAIL = @CLI_EMAIL, CLI_ENDERECO = @CLI_ENDERECO, CLI_BAIRRO = @CLI_BAIRRO, CLI_CIDADE =  CLI_CIDADE, CLI_ESTADO = @CLI_ESTADO, CLI_TELEFONE = @CLI_TELEFONE, CLI_SEXO = @CLI_SEXO, CLI_CASANUMERO = @CLI_CASANUMERO WHERE CLI_CPF = @CLI_CPF";

                commando.Parameters.Add("@CLI_CPF", SqlDbType.VarChar,15);
                commando.Parameters["@CLI_CPF"].Value = cli.CLI_CPF;

                commando.Parameters.Add("@CLI_PRIMNOME", SqlDbType.VarChar, 100);
                commando.Parameters["@CLI_PRIMNOME"].Value = cli.CLI_PRIMNOME;

                commando.Parameters.Add("@CLI_ULTNOME", SqlDbType.VarChar, 100);
                commando.Parameters["@CLI_ULTNOME"].Value = cli.CLI_ULTNOME;

                commando.Parameters.Add("@CLI_DATANASC", SqlDbType.DateTime);
                commando.Parameters["@CLI_DATANASC"].Value = cli.CLI_DATANASC;

                commando.Parameters.Add("@CLI_EMAIL", SqlDbType.VarChar, 50);
                commando.Parameters["@CLI_EMAIL"].Value = cli.CLI_EMAIL;

                commando.Parameters.Add("@CLI_ENDERECO", SqlDbType.VarChar, 100);
                commando.Parameters["@CLI_ENDERECO"].Value = cli.CLI_ENDERECO;

                commando.Parameters.Add("@CLI_BAIRRO", SqlDbType.VarChar, 100);
                commando.Parameters["@CLI_BAIRRO"].Value = cli.CLI_BAIRRO;

                commando.Parameters.Add("@CLI_CIDADE", SqlDbType.VarChar, 100);
                commando.Parameters["@CLI_CIDADE"].Value = cli.CLI_CIDADE;

                commando.Parameters.Add("@CLI_ESTADO", SqlDbType.Char, 2);
                commando.Parameters["@CLI_ESTADO"].Value = cli.CLI_ESTADO;

                commando.Parameters.Add("@CLI_TELEFONE", SqlDbType.Decimal);
                commando.Parameters["@CLI_TELEFONE"].Value = cli.CLI_TELEFONE;

                commando.Parameters.Add("@CLI_SEXO", SqlDbType.Char, 1);
                commando.Parameters["@CLI_SEXO"].Value = cli.CLI_SEXO;

                commando.Parameters.Add("@CLI_CASANUMERO", SqlDbType.Int);
                commando.Parameters["@CLI_CASANUMERO"].Value = cli.CLI_CASANUMERO;

                commando.ExecuteNonQuery();

                conn.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
        }
        public void VerificaDados(string cpf)
        {
            conn = new ConexaoDAL();
            conn.Conectar();

            ClientesDTO dto = new ClientesDTO();
            string seleciona = "SELECT * from CLIENTES where CLI_CPF = '" + cpf + "'";

            SqlCommand cmd = new SqlCommand(seleciona, conn.Conexao);
                                              

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                dto.CLI_VERIFICA = true;
                MessageBox.Show("CPF EXISTENTE");
            }
            else
            {
                dto.CLI_VERIFICA = false;
            }

            dr.Close();
            
        }

    }
}

