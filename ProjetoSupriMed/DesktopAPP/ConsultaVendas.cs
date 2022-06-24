using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProjetoSupriMed.Code.BLL;
using ProjetoSupriMed.Code.DTO;
using System.Data.SqlClient;
using ProjetoSupriMed.Code.DAL;

namespace ProjetoSupriMed.DesktopAPP
{
    public partial class ConsultaVendas : Form
    {
        
        ConexaoDAL con = new ConexaoDAL();
        public ConsultaVendas()
        {
            InitializeComponent();


        }

        private void tSMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }


        private void btPesquisar_Click(object sender, EventArgs e)
        {
            ConsultaVendasBLL bll = new ConsultaVendasBLL();

            if(txtPesquisar.Text == "")
            {
                MessageBox.Show("Digite um nome de Cliente, Vendedor ou Produto para pesquisar!");
            }else
            {
                if (RBCliente.Checked)
                {

                    bll.GetCliente(DataGridPesquisa, txtPesquisar);
                    txtPesquisar.Text = "";
                    DataGridPesquisa.Columns[0].Visible = false;
                    DataGridPesquisa.Columns[1].Visible = true;
                    DataGridPesquisa.Columns[2].Visible = false;
                }
                else if (RBVendedor.Checked)
                {
                    bll.GetVendedor(DataGridPesquisa, txtPesquisar);
                    txtPesquisar.Text = "";
                    DataGridPesquisa.Columns[0].Visible = true;
                    DataGridPesquisa.Columns[1].Visible = false;
                    DataGridPesquisa.Columns[2].Visible = false;
                }
                else if (RBProduto.Checked)
                {
                    bll.GetProduto(DataGridPesquisa, txtPesquisar);
                    txtPesquisar.Text = "";
                    DataGridPesquisa.Columns[0].Visible = false;
                    DataGridPesquisa.Columns[1].Visible = false;
                    DataGridPesquisa.Columns[2].Visible = true;
                }
            }

            if (DataGridPesquisa.Rows.Count == 0)
            {

                MessageBox.Show("Nenhum registro encontrado !");
                txtPesquisar.Text = "";
            }
            txtPesquisar.Text = "";
        }

        private void ConsultaVendas_Load(object sender, EventArgs e)
        {
            DataGridPesquisa.AutoGenerateColumns = false;
        }
    }
}


        
    

