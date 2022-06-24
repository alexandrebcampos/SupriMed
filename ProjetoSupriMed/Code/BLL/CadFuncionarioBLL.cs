using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProjetoSupriMed.Code.DAL;
using ProjetoSupriMed.Code.DTO;

namespace ProjetoSupriMed.Code.BLL
{
    class CadFuncionarioBLL
    {
        ConexaoDAL con;

        public void Salvar(FuncionariosDTO func)
        {
            try
            {
                con = new ConexaoDAL();
                con.Conectar();

                SqlCommand commando = new SqlCommand();
                commando.Connection = con.Conexao;

                commando.CommandText = "INSERT INTO FUNCIONARIOS(FUNC_CPF,SET_ID,FUNC_NOME,FUNC_DATANASC,FUNC_EMAIL,FUNC_ENDERECO,FUNC_BAIRRO,FUNC_CIDADE,FUNC_ESTADO,FUNC_TELEFONE,FUNC_SALARIO) VALUES (@FUNC_CPF,@SET_ID,@FUNC_NOME,@FUNC_DATANASC,@FUNC_EMAIL,@FUNC_ENDERECO,@FUNC_BAIRRO,@FUNC_CIDADE,@FUNC_ESTADO,@FUNC_TELEFONE,@FUNC_SALARIO)";

                commando.Parameters.Add("@FUNC_CPF", SqlDbType.VarChar, 15);
                commando.Parameters["@FUNC_CPF"].Value = func.FUNC_CPF;

                commando.Parameters.Add("@SET_ID", SqlDbType.Int);
                commando.Parameters["@SET_ID"].Value = func.SET_ID;

                commando.Parameters.Add("@FUNC_NOME", SqlDbType.VarChar, 100);
                commando.Parameters["@FUNC_NOME"].Value = func.FUNC_NOME;

                commando.Parameters.Add("@FUNC_DATANASC", SqlDbType.Date);
                commando.Parameters["@FUNC_DATANASC"].Value = func.FUNC_DATANASC;

                commando.Parameters.Add("@FUNC_EMAIL", SqlDbType.VarChar, 50);
                commando.Parameters["@FUNC_EMAIL"].Value = func.FUNC_EMAIL;

                commando.Parameters.Add("@FUNC_ENDERECO", SqlDbType.VarChar, 100);
                commando.Parameters["@FUNC_ENDERECO"].Value = func.FUNC_ENDERECO;

                commando.Parameters.Add("@FUNC_BAIRRO", SqlDbType.VarChar, 100);
                commando.Parameters["@FUNC_BAIRRO"].Value = func.FUNC_BAIRRO;

                commando.Parameters.Add("@FUNC_CIDADE", SqlDbType.VarChar, 100);
                commando.Parameters["@FUNC_CIDADE"].Value = func.FUNC_CIDADE;

                commando.Parameters.Add("@FUNC_ESTADO", SqlDbType.Char, 2);
                commando.Parameters["@FUNC_ESTADO"].Value = func.FUNC_ESTADO;

                commando.Parameters.Add("@FUNC_TELEFONE", SqlDbType.Decimal);
                commando.Parameters["@FUNC_TELEFONE"].Value = func.FUNC_TELEFONE;

                commando.Parameters.Add("@FUNC_SALARIO", SqlDbType.Float);
                commando.Parameters["@FUNC_SALARIO"].Value = func.FUNC_SALARIO;


                commando.ExecuteNonQuery();

                con.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }

        }

        public void Atualizar(FuncionariosDTO func)
        {
            try
            {
                ConexaoDAL conex = new ConexaoDAL();
                conex.Conectar();

                SqlCommand commando = new SqlCommand();
                commando.Connection = conex.Conexao;

                commando.CommandText = "UPDATE FUNCIONARIOS SET FUNC_CPF = @FUNC_CPF, SET_ID = @SET_ID, FUNC_NOME = @FUNC_NOME, FUNC_DATANASC = @FUNC_DATANASC, FUNC_EMAIL = @FUNC_EMAIL, FUNC_ENDERECO = @FUNC_ENDERECO, FUNC_BAIRRO = @FUNC_BAIRRO, FUNC_CIDADE = @FUNC_CIDADE, FUNC_ESTADO = @FUNC_ESTADO, FUNC_TELEFONE = @FUNC_TELEFONE, FUNC_SALARIO = @FUNC_SALARIO WHERE FUNC_CPF = @FUNC_CPF";

                commando.Parameters.Add("@FUNC_CPF", SqlDbType.VarChar, 15);
                commando.Parameters["@FUNC_CPF"].Value = func.FUNC_CPF;

                commando.Parameters.Add("@SET_ID", SqlDbType.Int);
                commando.Parameters["@SET_ID"].Value = func.SET_ID;

                commando.Parameters.Add("@FUNC_NOME", SqlDbType.VarChar, 100);
                commando.Parameters["@FUNC_NOME"].Value = func.FUNC_NOME;

                commando.Parameters.Add("@FUNC_DATANASC", SqlDbType.Date);
                commando.Parameters["@FUNC_DATANASC"].Value = func.FUNC_DATANASC;

                commando.Parameters.Add("@FUNC_EMAIL", SqlDbType.VarChar, 50);
                commando.Parameters["@FUNC_EMAIL"].Value = func.FUNC_EMAIL;

                commando.Parameters.Add("@FUNC_ENDERECO", SqlDbType.VarChar, 100);
                commando.Parameters["@FUNC_ENDERECO"].Value = func.FUNC_ENDERECO;

                commando.Parameters.Add("@FUNC_BAIRRO", SqlDbType.VarChar, 100);
                commando.Parameters["@FUNC_BAIRRO"].Value = func.FUNC_BAIRRO;

                commando.Parameters.Add("@FUNC_CIDADE", SqlDbType.VarChar, 100);
                commando.Parameters["@FUNC_CIDADE"].Value = func.FUNC_CIDADE;

                commando.Parameters.Add("@FUNC_ESTADO", SqlDbType.Char, 2);
                commando.Parameters["@FUNC_ESTADO"].Value = func.FUNC_ESTADO;

                commando.Parameters.Add("@FUNC_TELEFONE", SqlDbType.Decimal);
                commando.Parameters["@FUNC_TELEFONE"].Value = func.FUNC_TELEFONE;

                commando.Parameters.Add("@FUNC_SALARIO", SqlDbType.Float);
                commando.Parameters["@FUNC_SALARIO"].Value = func.FUNC_SALARIO;

                commando.ExecuteNonQuery();

                conex.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
        }

        public void Excluir(FuncionariosDTO func)
        {
            try
            {
                con = new ConexaoDAL();
                con.Conectar();

                SqlCommand commando = new SqlCommand();
                commando.Connection = con.Conexao;

                commando.CommandText = "DELETE FROM FUNCIONARIOS WHERE FUNC_CPF = @FUNC_CPF ";
                commando.Parameters.Add("@FUNC_CPF", SqlDbType.VarChar);
                commando.Parameters["@FUNC_CPF"].Value = func.FUNC_CPF;



                commando.ExecuteNonQuery();

                con.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }

        }

        public DataTable CarregaCombo()
        {
            DataTable dt = new DataTable("SETORES");
            using (SqlConnection Connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=SUPRIMEDICO;Persist Security Info=True;User ID=sa;Password=064871"))
            using (SqlCommand Command = new SqlCommand("select SET_ID,SET_NOME from SETORES ", Connection))
            {
                Connection.Open();
                dt.Load(Command.ExecuteReader());
            }
            return dt;
        }


        public bool VerificaDados(string cpf)
        {

            DataTable dt = new DataTable("FUNCIONARIOS");
            using (SqlConnection Connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=SUPRIMEDICO;Persist Security Info=True;User ID=sa;Password=064871"))
            using (SqlCommand Command = new SqlCommand("SELECT FUNC_CPF FROM FUNCIONARIOS WHERE FUNC_CPF = @FUNC_CPF", Connection))
            {
                Command.Parameters.Add("@FUNC_CPF", SqlDbType.VarChar, 15);
                Command.Parameters["@FUNC_CPF"].Value = cpf;

                Connection.Open();
                dt.Load(Command.ExecuteReader());
            }
            return true;
        }

        public static bool ValidaTelefone(string telefone)
        {
            string strtel = @"^\(?\d{2}\)?[\s-]?\d{4}-?\d{4}$";

            if (System.Text.RegularExpressions.Regex.IsMatch(telefone, strtel))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Verifica(string c)
        {
            con = new ConexaoDAL();
            con.Conectar();

            ClientesDTO dto = new ClientesDTO();
            string seleciona = "SELECT * from CLIENTES where CLI_CPF = '" + c + "'";

            SqlCommand cmd = new SqlCommand(seleciona, con.Conexao);


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
