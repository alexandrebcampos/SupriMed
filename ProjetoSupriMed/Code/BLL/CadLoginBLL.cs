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

    public class CadLoginBLL
    {
        ConexaoDAL con;

        #region Metodos
        public void Salvar(LoginDTO login)
        {
            try
            {
                con = new ConexaoDAL();
                con.Conectar();

                SqlCommand commando = new SqlCommand();
                commando.Connection = con.Conexao;

                commando.CommandText = "INSERT INTO LOGIN(FUNC_CPF,LOG_USUARIO,LOG_SENHA,LOG_DATACADASTRO,LOG_PRIVILEGIO) VALUES (@FUNC_CPF,@LOG_USUARIO,@LOG_SENHA,@LOG_DATACADASTRO,@LOG_PRIVILEGIO)";
                commando.Parameters.Add("@FUNC_CPF", SqlDbType.VarChar, 15);
                commando.Parameters["@FUNC_CPF"].Value = login.FUNC_CPF;

                commando.Parameters.Add("@LOG_USUARIO", SqlDbType.VarChar, 50);
                commando.Parameters["@LOG_USUARIO"].Value = login.LOG_USUARIO;

                commando.Parameters.Add("@LOG_SENHA", SqlDbType.VarChar, 6);
                commando.Parameters["@LOG_SENHA"].Value = login.LOG_SENHA;

                commando.Parameters.Add("@LOG_PRIVILEGIO", SqlDbType.VarChar, 50);
                commando.Parameters["@LOG_PRIVILEGIO"].Value = login.LOG_PRIVILEGIO;

                commando.Parameters.Add("@LOG_DATACADASTRO", SqlDbType.DateTime);
                commando.Parameters["@LOG_DATACADASTRO"].Value = login.LOG_DATACADASTRO;



                commando.ExecuteNonQuery();

                con.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }


        }

        public void Excluir(LoginDTO login)
        {
            try
            {
                con = new ConexaoDAL();
                con.Conectar();

                SqlCommand commando = new SqlCommand();
                commando.Connection = con.Conexao;

                commando.CommandText = "DELETE FROM LOGIN WHERE FUNC_CPF = @FUNC_CPF ";
                commando.Parameters.Add("@FUNC_CPF", SqlDbType.Int);
                commando.Parameters["@FUNC_CPF"].Value = login.FUNC_CPF;



                commando.ExecuteNonQuery();

                con.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }

        }

        public void Atualizar(LoginDTO login)
        {
            try
            {
                con = new ConexaoDAL();
                con.Conectar();

                SqlCommand commando = new SqlCommand();
                commando.Connection = con.Conexao;

                commando.CommandText = "UPDATE LOGIN SET  LOG_USUARIO = @LOG_USUARIO, LOG_SENHA = @LOG_SENHA,LOG_PRIVILEGIO = @LOG_PRIVILEGIO,LOG_ATUALIZADOEM = @LOG_ATUALIZADOEM WHERE FUNC_CPF = @FUNC_CPF";

                commando.Parameters.Add("@FUNC_CPF", SqlDbType.VarChar, 15);
                commando.Parameters["@FUNC_CPF"].Value = login.FUNC_CPF;

                commando.Parameters.Add("@LOG_USUARIO", SqlDbType.VarChar, 50);
                commando.Parameters["@LOG_USUARIO"].Value = login.LOG_USUARIO;

                commando.Parameters.Add("@LOG_SENHA", SqlDbType.VarChar, 6);
                commando.Parameters["@LOG_SENHA"].Value = login.LOG_SENHA;

                commando.Parameters.Add("@LOG_PRIVILEGIO", SqlDbType.VarChar, 50);
                commando.Parameters["@LOG_PRIVILEGIO"].Value = login.LOG_PRIVILEGIO;

                commando.Parameters.Add("@LOG_ATUALIZADOEM", SqlDbType.DateTime);
                commando.Parameters["@LOG_ATUALIZADOEM"].Value = login.LOG_ATUALIZADOEM;

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
            DataTable dt = new DataTable("FUNCIONARIOS");
            using (SqlConnection Connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=SUPRIMEDICO;Persist Security Info=True;User ID=sa;Password=064871"))
            using (SqlCommand Command = new SqlCommand("SELECT FUNC_CPF, FUNC_NOME FROM FUNCIONARIOS ORDER BY FUNC_CPF", Connection))
            {
                Connection.Open();
                dt.Load(Command.ExecuteReader());
            }
            return dt;
        }

        public bool VerificaDados(string cpf)
        {
           
            DataTable dt = new DataTable("LOGIN");
            using (SqlConnection Connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=SUPRIMEDICO;Persist Security Info=True;User ID=sa;Password=064871"))
            using (SqlCommand Command = new SqlCommand("SELECT FUNC_CPF FROM LOGIN WHERE FUNC_CPF = '"+ cpf + "'", Connection))
            {
                Command.Parameters.Add("@FUNC_CPF", SqlDbType.VarChar, 15);
                Command.Parameters["@FUNC_CPF"].Value = cpf;

            
                
                Connection.Open();
                dt.Load(Command.ExecuteReader());
                
            }
            return true;
        }
      
        #endregion


    }



}
