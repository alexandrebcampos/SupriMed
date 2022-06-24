using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoSupriMed.Code.DTO;
using ProjetoSupriMed.Code.DAL;
using System.Data.SqlClient;

namespace ProjetoSupriMed.DesktopAPP
{
    public partial class FrmDetalheVenda : Form
    {
        ConexaoDAL con;

        public FrmDetalheVenda(int id)
        {
            InitializeComponent();


            lbCod.Text = id.ToString();
            lbDataEmissao.Text = FrmVendas.Data;
            lbCliente.Text = FrmVendas.Cliente;
            lbVendedor.Text = FrmVendas.Vendedor;
            lbTotal.Text = FrmVendas.Total.ToString();
            lbValor.Text = FrmVendas.Valor.ToString();
            lbDesc.Text = FrmVendas.Desconto.ToString();
            lbValorPag.Text = FrmVendas.ValorPago.ToString();

            


        }

        private void FrmDetalheVenda_Load(object sender, EventArgs e)
        {
            //con = new ConexaoDAL();
            //string strSql = "SELECT * FROM VENDAS_ITENS order by VEN_ID";
            //SqlCommand cmd = new SqlCommand(strSql, con.Conexao);

            ////abre a conexao
            //con.Conexao.Open();

            ////define o tipo do comando 
            //cmd.CommandType = CommandType.Text;
            ////cria um dataadapter
            //SqlDataAdapter da = new SqlDataAdapter(cmd);

            ////cria um objeto datatable
            //DataTable iVendas = new DataTable();

            ////preenche o datatable via dataadapter
            //da.Fill(iVendas);

            ////atribui o datatable ao datagridview para exibir o resultado
            //dGVendasItens.DataSource = iVendas;

            //dGVendasItens.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
