using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoSupriMed.FormBase;
using System.Data.SqlClient;
using ProjetoSupriMed.Code.BLL;
using ProjetoSupriMed.Code.DTO;
using ProjetoSupriMed.Code.DAL;

namespace ProjetoSupriMed.DesktopAPP
{
    public partial class FrmVendas : Form
    {
        VendasBLL bll = new VendasBLL();
        ConexaoDAL con;

        public static int Id;
        public static string Data;
        public static string Cliente;
        public static string Vendedor;
        public static decimal Total;
        public static decimal Desconto;
        public static decimal Valor;
        public static decimal ValorPago;

      
        public FrmVendas()
        {
            InitializeComponent();

            CarregaCliente();
            CarregaProdutos();
            CarregaValoresVendedores();
        }

        private void FrmVendas_Load(object sender, EventArgs e)
        {
            dTPDataEmissaoVenda.Text = DateTime.Now.ToString();
            
            dGVendasItens.AutoGenerateColumns = false;
            //CarregaGrid();
        }

        private void CarregaCliente()
        {
            cBClienteVenda.DataSource = bll.CarregaComboClientes();
            cBClienteVenda.ValueMember = "CLI_CPF";
            cBClienteVenda.DisplayMember = "CLI_PRIMNOME";
            cBClienteVenda.Update();
            cBClienteVenda.SelectedIndex = -1;
            cBClienteVenda.Refresh();
        }

        private void CarregaProdutos()
        {
            cBProdutoItem.DataSource = bll.CarregaComboProdutos();
            cBProdutoItem.ValueMember = "PROD_ID";
            cBProdutoItem.DisplayMember = "PROD_NOME";
            cBProdutoItem.Update();
            cBProdutoItem.SelectedIndex = -1;
            cBProdutoItem.Refresh();
        }

        public void CarregaValoresVendedores()
        {
            cBCodVendedorVenda.DataSource = bll.CarregaComboVendedor();
            cBCodVendedorVenda.ValueMember = "VEND_ID";
            cBCodVendedorVenda.DisplayMember = "FUNC_NOME";
            cBCodVendedorVenda.Update();
            cBCodVendedorVenda.SelectedIndex = -1;
            cBCodVendedorVenda.Refresh();
        }

        private void CarregaGrid()
        {
            con = new ConexaoDAL();
            string strSql = "SELECT VEN_ID,PROD_ID,VENDA_ITENS_QTO,VENDA_ITENS_VLUNIT,VENDA_ITENS_TOTAL FROM VENDAS_ITENS order by VEN_ID";
            SqlCommand cmd = new SqlCommand(strSql, con.Conexao);

            //abre a conexao
            con.Conexao.Open();

            //define o tipo do comando 
            cmd.CommandType = CommandType.Text;
            //cria um dataadapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //cria um objeto datatable
            DataTable iVendas = new DataTable();

            //preenche o datatable via dataadapter
            da.Fill(iVendas);

            //atribui o datatable ao datagridview para exibir o resultado
            dGVendasItens.DataSource = iVendas;

            dGVendasItens.Refresh();
        }

        private void btnNovaVenda_Click(object sender, EventArgs e)
        {
           
            if(cBClienteVenda.Text == "")
            {
                MessageBox.Show("Selecione um Cliente para prosseguir!");
            }else
            {
                
                    VendasDTO dto = new VendasDTO();
                    dto.CLI_CPF = cBClienteVenda.SelectedValue.ToString();
                    bll.SalvarVendas(dto);

                gBNovaVenda.Enabled = true;
                btnNovaVenda.Enabled = false;
                cBClienteVenda.Enabled = false;
                btnFinalizaPedido.Enabled = true;
                btnNovoItem.Enabled = true;
                cBProdutoItem.Enabled = true;
                txtQuantidadeItem.Enabled = true;
                GerarNumero();
                
            }
        }
      
        private void btnNovoItem_Click(object sender, EventArgs e)
        {
           

            if (txtQuantidadeItem.Text == "" )
            {
               
                MessageBox.Show("Preencha todos os campos com * para prosseguir!");
            }else
            {
                
                VendasItensDTO dtoItens = new VendasItensDTO();
                dtoItens.VEN_ID = Convert.ToInt32(txtCodItem.Text);
                dtoItens.PROD_ID = Convert.ToInt32(cBProdutoItem.SelectedValue);
                dtoItens.VENDA_ITENS_QTO = int.Parse(txtQuantidadeItem.Text);
                dtoItens.VENDA_ITENS_VLUNIT = Convert.ToDecimal(txtValorUnitItem.Text);
                dtoItens.VENDA_ITENS_TOTAL = Convert.ToDecimal(txtTotal.Text);




                bll.SalvarItensVendas(dtoItens);
                //CarregaGrid();

                string strSql = "SELECT * FROM VENDAS_ITENS Where VEN_ID  = '" + txtCodItem.Text + "'";

                con = new ConexaoDAL();
                SqlCommand cmd = new SqlCommand(strSql, con.Conexao);
                con.Conexao.Open();
                cmd.CommandText = strSql;

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);

                dGVendasItens.DataSource = dataSet;
                dGVendasItens.DataMember = dataSet.Tables[0].TableName;

                dGVendasItens.Refresh();

                lbMensagem.Text = "Item incluido com sucesso!";
                txtQuantidadeItem.Text = "";
                //LimpaControles();
            }

            

        }

        private void btnFinalizarVenda_Click(object sender, EventArgs e)
        {
            if (txtDescontoVenda.Text == "")
            {
                MessageBox.Show("Selecione o desconto se houve para finalizar a venda!");
            }
            else
            {
                VendasDTO dto = new VendasDTO();
                dto.CLI_CPF = cBClienteVenda.SelectedValue.ToString();
                dto.VEND_ID = Convert.ToInt32(cBCodVendedorVenda.SelectedValue);
                dto.VEN_DTEMISSAO = DateTime.Parse(dTPDataEmissaoVenda.Text);
                dto.VEN_VALOR = Convert.ToDecimal(txtValorVenda.Text);
                dto.VEN_DESCONTO = Convert.ToDecimal(txtDescontoVenda.Text);
                dto.VEN_VALORPAGO = Convert.ToDecimal(txtValorPagoVenda.Text);

                bll.Atualizar(dto);

                MessageBox.Show("Venda Finalizada com sucesso!");

                btnNovaVenda.Enabled = true;
                gBNovaVenda.Enabled = true;
                btnFinalizaPedido.Enabled = true;
                btnFinalizarVenda.Enabled = false;
                cBClienteVenda.Enabled = true;
                btnDetalhe.Enabled = true;
                dGVendasItens.DataSource = null;
                //LimpaControles();
            }
            
        }

        private void MostraSomaValores()
        {
           try
            { 

                decimal n2, total;
                int n1;

                n1 = int.Parse(txtQuantidadeItem.Text);
                n2 = decimal.Parse(txtValorUnitItem.Text);

                total = n1 * n2;

                txtTotal.Text = total.ToString("F");
            }
            catch(Exception)
            {

            }
            
        }

        private void CalculaTotalGrid()
        {
            decimal total = 0;
            foreach (DataGridViewRow dg in dGVendasItens.Rows)
            {
                total = total + Convert.ToDecimal(dg.Cells[3].Value);
            }

            txtValorVenda.Text = total.ToString("F");
        }
        private void CalculaDesconto()
        {
            try
            {
                decimal num1, total, num2;

                num1 = decimal.Parse(txtValorVenda.Text);
                num2 = decimal.Parse(txtDescontoVenda.Text);


                total = num1 - (num2 * num1) / 100;

                txtValorPagoVenda.Text = total.ToString("F");
            }catch(Exception)
            {

            }
           

        }

        private void btnFinalizaPedido_Click(object sender, EventArgs e)
        {
            
            if(MessageBox.Show("Tem certeza que deseja finalizar essa venda?\nNão será possível adicionar um novo item.",
                "Confirmação",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                
                btnNovoItem.Enabled = false;
                txtCodItem.Enabled = false;
                cBProdutoItem.Enabled = false;
                txtQuantidadeItem.Enabled = false;
                txtValorUnitItem.Enabled = false;
                txtDescontoVenda.ReadOnly = false;
                txtDescontoVenda.Focus();
                txtDescontoVenda.Enabled = true;
                btnFinalizaPedido.Enabled = false;
                btnFinalizarVenda.Enabled = true;
                cBCodVendedorVenda.Enabled = false;
                CalculaTotalGrid();
            }
        }

        public void GerarNumero()
        {
           GerandoAutoIncremento.AutoIncremento("SELECT MAX(VEN_ID) FROM VENDAS", txtCodItem);
        }

        public void LimpaControles()
        {
            //cBClienteVenda.Text = "";
            //txtCodItem.Text = "";
            //cBProdutoItem.Text = "";
            //txtQuantidadeItem.Text = "";
            //txtValorUnitItem.Text = "";
            //txtTotal.Text = "";
            //txtValorVenda.Text = "";
            //cBCodVendedorVenda.Text = "";
            //txtDescontoVenda.Text = "";
            //txtValorPagoVenda.Text = "";

        }

        private void txtValorUnitItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
               (e.KeyChar != ',' && e.KeyChar != '.' &&
                e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtValorUnitItem.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }


        private void txtValorUnitItem_Enter(object sender, EventArgs e)
        {
            String x = "";
            for (int i = 0; i <= txtValorUnitItem.Text.Length - 1; i++)
            {
                if ((txtValorUnitItem.Text[i] >= '0' &&
                    txtValorUnitItem.Text[i] <= '9') ||
                    txtValorUnitItem.Text[i] == ',')
                {
                    x += txtValorUnitItem.Text[i];
                }
            }
            txtValorUnitItem.Text = x;
            txtValorUnitItem.SelectAll();
        }

        private void txtQuantidadeItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
               (e.KeyChar != ',' && e.KeyChar != '.' &&
                e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtValorUnitItem.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txtValorUnitItem_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtQuantidadeItem.Text != null)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    MostraSomaValores();
                }
            }
            else
            {
                MessageBox.Show("Digite uma quantidade para calcular");
            }

        }

        private void txtTotal_Enter(object sender, EventArgs e)
        {
            String x = "";
            for (int i = 0; i <= txtTotal.Text.Length - 1; i++)
            {
                if ((txtTotal.Text[i] >= '0' &&
                    txtTotal.Text[i] <= '9') ||
                    txtTotal.Text[i] == ',')
                {
                    x += txtTotal.Text[i];
                }
            }
            txtTotal.Text = x;
            txtTotal.SelectAll();
        }

        private void txtTotal_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
               (e.KeyChar != ',' && e.KeyChar != '.' &&
                e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtTotal.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {

                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txtValorVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
                (e.KeyChar != ',' && e.KeyChar != '.' &&
                 e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtValorVenda.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {

                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        private void txtValorPagoVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') &&
               (e.KeyChar != ',' && e.KeyChar != '.' &&
                e.KeyChar != (Char)13 && e.KeyChar != (Char)8))
            {
                e.KeyChar = (Char)0;
            }
            else
            {
                if (e.KeyChar == '.' || e.KeyChar == ',')
                {
                    if (!txtValorPagoVenda.Text.Contains(','))
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {

                        e.KeyChar = (Char)0;
                    }
                }
            }
        }

        public void ExibiVLUnitProdutos()
        {
            ConexaoDAL con = new ConexaoDAL();
            string query = "SELECT PROD_NOME,PROD_VLUNIT  FROM PRODUTOS  where PROD_NOME = '" + cBProdutoItem.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con.Conexao);
            SqlDataReader rd;

            try
            {
                con.Conectar();
                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    decimal vUnit = (decimal)rd["PROD_VLUNIT"];
                    txtValorUnitItem.Text = vUnit.ToString("F");
                    



                }

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void cBProdutoItem_SelectedValueChanged(object sender, EventArgs e)
        {
            ExibiVLUnitProdutos();
        }

        private void txtQuantidadeItem_TextChanged(object sender, EventArgs e)
        {
            MostraSomaValores();
        }

        private void txtDescontoVenda_TextChanged(object sender, EventArgs e)
        {
            CalculaDesconto();
        }

        private void cBClienteVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cBCodVendedorVenda_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cBProdutoItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btnDetalhe_Click(object sender, EventArgs e)
        {
            Data = dTPDataEmissaoVenda.Text;
            Cliente = cBClienteVenda.Text;
            Vendedor = cBCodVendedorVenda.Text;
            Id = Convert.ToInt32(txtCodItem.Text);
            Desconto = Convert.ToDecimal(txtDescontoVenda.Text);
            Total = Convert.ToDecimal(txtTotal.Text);
            Valor = Convert.ToDecimal(txtValorVenda.Text);
            ValorPago = Convert.ToDecimal(txtValorPagoVenda.Text);

            FrmDetalheVenda d = new FrmDetalheVenda(Id);
            d.ShowDialog();
        }
    }
}
