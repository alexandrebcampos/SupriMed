using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoSupriMed.Code.BLL;
using ProjetoSupriMed.Code.DAL;
using System.Data.SqlClient;
using ProjetoSupriMed.Code.DTO;

namespace ProjetoSupriMed.DesktopAPP
{
    public partial class FrmProduto : ProjetoSupriMed.FormBase.FrmBase
    {
        ConexaoDAL con = new ConexaoDAL();
        ProdutosBLL bll = new ProdutosBLL(); 
        
        
        public FrmProduto()
        {

            InitializeComponent();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            new PecasBLL().Buscar(null).ForEach(f => listView1.Items.Add(f.PEC_ID + " - " + f.PEC_NOME));
        }

        public override void HabilitaBotao(bool value)
        {
            base.HabilitaBotao(value);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                listView2.Items.Add(listView1.SelectedItems[0].Text);
            listView2.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count > 0)
                listView2.SelectedItems[0].Remove();
            listView2.Refresh();
        }


        public override bool Salvar()
        {

            ProdutosDTO prod = new ProdutosDTO();

            prod.PROD_NOME = txtNomeProduto.Text;
            prod.PROD_CATEGORIA = txtCategoria.Text;
            prod.PROD_DESCRICAO = txtdescricaoproduto.Text;
            prod.PROD_VLUNIT = txtprecoCusto.Text;
            prod.PROD_VFINAL = txtprecoVenda.Text;
            prod.PROD_ESTOQUE = "SIM";
            
            int idProduto = new ProdutosBLL().Salvar(prod);


            foreach (ListViewItem item in listView2.Items)
            {
                new ProdutosBLL().SalvarPeca(idProduto, int.Parse(item.Text.Split('-')[0].ToString()));
            }

            return false;
        }


        private void btnPesquisaProduto_Click(object sender, EventArgs e)
        {

            string strSql  = "SELECT * FROM PRODUTOS Where ";
            if (rbcodigo.Checked)
                strSql += " PROD_ID = " + txtPesquisaProduto.Text;
            else
                strSql += " PROD_DESCRICAO LIKE '%" + txtPesquisaProduto.Text + "%'";

            con = new ConexaoDAL();
            SqlCommand cmd = new SqlCommand(strSql, con.Conexao);
            con.Conexao.Open();
            cmd.CommandText = strSql;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            dGVPesquisaProduto.DataSource = dataSet;
            dGVPesquisaProduto.DataMember = dataSet.Tables[0].TableName;

            dGVPesquisaProduto.Refresh();


        }


        private void btnDeletar_Click(object sender, EventArgs e)
        {
            ProdutosBLL produtosBLL = new ProdutosBLL();
            ProdutosDTO produtosDTO = new ProdutosDTO();

            produtosDTO.PROD_ID = int.Parse(txtNomeProduto.Text);

            produtosBLL.Excluir(produtosDTO);

            MessageBox.Show("Peça exclúida com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtNomeProduto.Text = "";
            txtCategoria.Text = "";
            txtdescricaoproduto.Text = "";
            txtprecoCusto.Text = "";
            txtprecoVenda.Text = "";
        }


        //private void btnAtualizar_Click(object sender, EventArgs e)
        //{
        //    Atualizar();
        //    btnSalvar.Enabled = true;
        //}




    }
}
