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
    public class AgendaVisitasBLL
    {
        ConexaoDAL con;

        #region Metodos
        public void Salvar(VisitasDTO visi)
        {
            try
            {
                con = new ConexaoDAL();
                con.Conectar();

                SqlCommand commando = new SqlCommand();
                commando.Connection = con.Conexao;

                commando.CommandText = "INSERT INTO VISITAS(CLI_CPF,VEND_ID,VIS_DATA,VIS_HORA,VIS_DESCRICAO)VALUES (@CLI_CPF,@VEND_ID,@VIS_DATA,@VIS_HORA,@VIS_DESCRICAO)";
                commando.Parameters.Add("@CLI_CPF", SqlDbType.VarChar, 15);
                commando.Parameters["@CLI_CPF"].Value = visi.CLI_CPF;

                commando.Parameters.Add("@VEND_ID", SqlDbType.Int);
                commando.Parameters["@VEND_ID"].Value = visi.VEND_ID;

                commando.Parameters.Add("@VIS_DATA", SqlDbType.Date);
                commando.Parameters["@VIS_DATA"].Value = visi.VIS_DATA;

                commando.Parameters.Add("@VIS_HORA", SqlDbType.Time);
                commando.Parameters["@VIS_HORA"].Value = visi.VIS_HORA;

                commando.Parameters.Add("@VIS_DESCRICAO", SqlDbType.VarChar,200);
                commando.Parameters["@VIS_DESCRICAO"].Value = visi.VIS_DESCRICAO;



                commando.ExecuteNonQuery();

                con.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }


        }

        public void Excluir(VisitasDTO visi)
        {
            try
            {
                con = new ConexaoDAL();
                con.Conectar();

                SqlCommand commando = new SqlCommand();
                commando.Connection = con.Conexao;

                commando.CommandText = "DELETE FROM VISITAS WHERE CLI_CPF = @CLI_CPF ";
                commando.Parameters.Add("@CLI_CPF", SqlDbType.VarChar);
                commando.Parameters["@CLI_CPF"].Value = visi.CLI_CPF;

                commando.ExecuteNonQuery();

                con.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }

        }

        public void Atualizar(VisitasDTO visi)
        {
            try
            {
                con = new ConexaoDAL();
                con.Conectar();

                SqlCommand commando = new SqlCommand();
                commando.Connection = con.Conexao;

                commando.CommandText = "UPDATE VISITAS SET CLI_CPF = @CLI_CPF, VEND_ID = @VEND_ID,VIS_DATA = @VIS_DATA,VIS_HORA = @VIS_HORA,VIS_DESCRICAO = @VIS_DESCRICAO WHERE VEND_ID = @VEND_ID ";

                commando.Parameters.Add("@CLI_CPF", SqlDbType.VarChar, 15);
                commando.Parameters["@CLI_CPF"].Value = visi.CLI_CPF;

                commando.Parameters.Add("@VEND_ID", SqlDbType.Int);
                commando.Parameters["@VEND_ID"].Value = visi.VEND_ID;

                commando.Parameters.Add("@VIS_DATA", SqlDbType.Date);
                commando.Parameters["@VIS_DATA"].Value = visi.VIS_DATA;

                commando.Parameters.Add("@VIS_HORA", SqlDbType.Time);
                commando.Parameters["@VIS_HORA"].Value = visi.VIS_HORA;

                commando.Parameters.Add("@VIS_DESCRICAO", SqlDbType.VarChar, 200);
                commando.Parameters["@VIS_DESCRICAO"].Value = visi.VIS_DESCRICAO;


                commando.ExecuteNonQuery();

                con.Desconectar();

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
        }

        public DataTable CarregaComboCpfCliente()
        {
            DataTable dtc = new DataTable("CLIENTES");
            using (SqlConnection Connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=SUPRIMEDICO;Persist Security Info=True;User ID=sa;Password=064871"))
            using (SqlCommand Command = new SqlCommand("SELECT CLI_CPF,CLI_PRIMNOME,CLI_ENDERECO,CLI_BAIRRO,CLI_CIDADE,CLI_ESTADO,CLI_TELEFONE,CLI_SEXO,CLI_CASANUMERO FROM CLIENTES ORDER BY CLI_CPF", Connection))
            {
                Connection.Open();
                dtc.Load(Command.ExecuteReader());
            }
            return dtc;
        }

        public DataTable CarregaComboIDVendedor()
        {
            DataTable dtV = new DataTable();
            using (SqlConnection Connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=SUPRIMEDICO;Persist Security Info=True;User ID=sa;Password=064871"))
            using (SqlCommand Command = new SqlCommand("SELECT V.VEND_ID, F.FUNC_NOME FROM FUNCIONARIOS F INNER JOIN VENDEDORES V ON V.FUNC_CPF = F.FUNC_CPF" , Connection))
            {
                Connection.Open();
                dtV.Load(Command.ExecuteReader());
            }
            return dtV;
        }

        public void ComboVendedor(ComboBox combobox)
        {
            combobox.DataSource = CarregaComboIDVendedor();
            combobox.ValueMember = "VEND_ID";
            combobox.DisplayMember = "FUNC_NOME";
            combobox.Update();
        }

        #endregion
    }
}


