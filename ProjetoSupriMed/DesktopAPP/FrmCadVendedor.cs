using ProjetoSupriMed.Code.BLL;
using ProjetoSupriMed.Code.DAL;
using ProjetoSupriMed.Code.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoSupriMed.DesktopAPP
{
    public partial class FrmCadVendedor : Form
    {
        VendedoresBLL bll = new VendedoresBLL();
        ConexaoDAL con;
        public FrmCadVendedor()
        {
            InitializeComponent();
            CarregaComboVendedores();
        }

        public void Salvar()
        {
            if (cBVendedor.SelectedText == "")
            {

                MessageBox.Show("Selecione o campo vendedor!");

            }
            else
            {
                VendedoresDTO dto = new VendedoresDTO();
                dto.FUNC_CPF = cBVendedor.SelectedValue.ToString();
                dto.VEND_COMISSAO = float.Parse(txtComissao.Text);

                bll.Salvar(dto);
                LimpaControles();
                CarregaGrid();

                MessageBox.Show("Registro salvo com sucesso!");
            }

        }

        public void Atualizar()
        {
            if (cBVendedor.SelectedText == "")
            {
                MessageBox.Show("Selecione um Vendedor!");

            }
            else
            {
                var result = MessageBox.Show("Deseja realmente atualizar esse setor?", "Atualização de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {


                    VendedoresDTO dto = new VendedoresDTO();
                    dto.FUNC_CPF = cBVendedor.SelectedValue.ToString();
                    dto.VEND_COMISSAO = float.Parse(txtComissao.Text);

                    bll.Atualizar(dto);
                    CarregaGrid();
                    LimpaControles();
                    MessageBox.Show("Registro atualizado com sucesso!");
                }
            }


        }

        public void LimpaControles()
        {
            cBVendedor.Text = "";
        }

        public void HabilitaBotao(bool value)
        {

            dGVExibirPesquisa.Enabled = true;
        }

        private void CarregaGrid()
        {
            con = new ConexaoDAL();
            string strSql = "SELECT F.FUNC_NOME, V.FUNC_CPF,V.VEND_COMISSAO FROM VENDEDORES V INNER JOIN FUNCIONARIOS F ON F.FUNC_CPF = v.FUNC_CPF where F.SET_ID = 4";
            SqlCommand cmd = new SqlCommand(strSql, con.Conexao);

            //abre a conexao
            con.Conexao.Open();

            //define o tipo do comando 
            cmd.CommandType = CommandType.Text;
            //cria um dataadapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //cria um objeto datatable
            DataTable vendedor = new DataTable();

            //preenche o datatable via dataadapter
            da.Fill(vendedor);

            //atribui o datatable ao datagridview para exibir o resultado
            dGVExibirPesquisa.DataSource = vendedor;

            dGVExibirPesquisa.Refresh();
        }

        public  void CarregaComboVendedores()
        {
            //cBCPF.DropDownStyle = ComboBoxStyle.DropDownList;
            cBVendedor.DataSource = bll.CarregaComboVendedor();
            cBVendedor.ValueMember = "FUNC_CPF";
            cBVendedor.DisplayMember = "FUNC_NOME";
            cBVendedor.Update();
        }

        private void FrmCadVendedor_Load(object sender, EventArgs e)
        {
            dGVExibirPesquisa.AutoGenerateColumns = false;
            //CarregaGrid();
        }

        private void dGVExibirPesquisa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSalvar.Enabled = false;
            cBVendedor.Text = dGVExibirPesquisa.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtComissao.Text = dGVExibirPesquisa.Rows[e.RowIndex].Cells[2].Value.ToString();
            cBVendedor.Focus();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Atualizar();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (txtPesquisar.Text == "")
            {
                MessageBox.Show("Digite um nome!");
            }
            else
            {
                string strSql = "SELECT * FROM VENDEDORES Where FUNC_CPF LIKE '" + txtPesquisar.Text + "'";

                con = new ConexaoDAL();
                SqlCommand cmd = new SqlCommand(strSql, con.Conexao);
                con.Conexao.Open();
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dGVExibirPesquisa.DataSource = dt;
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
