using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProjetoSupriMed.Code.DTO.Validação;

namespace ProjetoSupriMed.DesktopAPP
{
    public partial class FrmConsultaVisita : Form
    {
        public FrmConsultaVisita()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {

            //define os objetos DataReader, Connection e Command
            SqlDataReader sqldr = null;
            SqlConnection con = null;



            try
            {
                
                    // Abre a conexão com o banco de dados Northwind no SQL Server 2005 Express
                    // .\SQLExpress é o nome default do servidor
                    // initial Catalog - indica o banco de dados
                    // String usando Windows Authentication (Trusted Connection):
                    string ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=SUPRIMEDICO;Persist Security Info=True;User ID=sa;Password=064871";
                    con = new SqlConnection(ConnectionString);
                    con.Open();



                    //criando o select e o objeto de consulta
                    string sql = "SELECT V.* FROM VISITAS V INNER JOIN VENDEDORES VEND ON VEND.VEND_ID = V.VEND_ID WHERE VEND.FUNC_CPF LIKE @criterio";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.Connection = con;
                    cmd.CommandText = sql;
                    // Define o parâmetro @criterio e seu tipo de dados
                    cmd.Parameters.Add(
                        new SqlParameter(
                        "@criterio",                    // o nome do parametro
                        System.Data.SqlDbType.NVarChar, // o tipo de dado SqlDbType
                        40,                             // o tamanho do parametro
                        "FUNC_CPF"));                // o nome da coluna na tabela a qual se aplica

                    // Preenche o valor do parâmetro com o texto informado
                    // na caixa de texto : txtcriterio
                    cmd.Parameters["@criterio"].Value = maskedtbCPF.Text;

                    // cria o dataadapter...
                    SqlDataAdapter adapter = new SqlDataAdapter();
                    adapter.SelectCommand = cmd;

                    // preenche o dataset...
                    DataSet dataSet = new DataSet();
                    adapter.Fill(dataSet);

                    dGVPesquisa.DataSource = dataSet;
                    dGVPesquisa.DataMember = dataSet.Tables[0].TableName;
                    con.Close();
                
                    
            }
            catch (Exception ex)
            {
                // exibe mensagem de erro
                MessageBox.Show(ex.Message);
            }
            finally
            {
                // fecha o data reader e a conexão
                if (sqldr != null)
                    sqldr.Close();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dGVPesquisa.DataSource = null;
            maskedtbCPF.Text = "";
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtcriterio_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void FrmConsultaVisita_Load(object sender, EventArgs e)
        {
            dGVPesquisa.AutoGenerateColumns = false;
        }

        private void maskedtbCPF_Leave(object sender, EventArgs e)
        {
            //string valor = maskedtbCPF.Text;
            //if (ValidaCPF.IsCpf(valor))
            //{

            //}
            //else
            //{
            //    MessageBox.Show("CPF Inválido!");
            //    maskedtbCPF.Text = "";
            //    maskedtbCPF.Focus();
            //}
        }
    }
}
