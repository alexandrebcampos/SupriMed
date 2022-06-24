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
    public partial class FrmCadSetores : Form
    {
        SetoresBLL bll = new SetoresBLL();
        ConexaoDAL con;
        public FrmCadSetores()
        {
            InitializeComponent();
        }

        private void FrmCadSetores_Load(object sender, EventArgs e)
        {
            dGVPesquisa.AutoGenerateColumns = false;
            //CarregaGrid();
        }


        public void Salvar()
        {
            if (txtNomeSetor.Text == "")
            {

                MessageBox.Show("Preencha o campos Nome!");

            }
            else
            {
                SetoresDTO dto = new SetoresDTO();
                dto.SET_NOME= txtNomeSetor.Text;

                    bll.Salvar(dto);
                    LimpaControles();
                CarregaGrid();

                MessageBox.Show("Registro salvo com sucesso!");
            }
            
        }

        public void Atualizar()
        {
            if (txtNomeSetor.Text == "")
            {
                MessageBox.Show("Selecione um setor!");
               
            }
            else
            {
                var result = MessageBox.Show("Deseja realmente atualizar esse setor?", "Atualização de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {


                    SetoresDTO dto = new SetoresDTO();
                    dto.SET_ID = int.Parse(txtCod.Text);
                    dto.SET_NOME = txtNomeSetor.Text;

                    bll.Atualizar(dto);
                    CarregaGrid();
                    LimpaControles();
                    MessageBox.Show("Registro atualizado com sucesso!");
                }
            }

            
        }

        public void LimpaControles()
        {
            txtNomeSetor.Text = "";
        }

        public  void HabilitaBotao(bool value)
        {
            
            dGVPesquisa.Enabled = true;
        }

        private void CarregaGrid()
        {
            con = new ConexaoDAL();
            string strSql = "SELECT SET_ID,SET_NOME FROM SETORES order by SET_ID";
            SqlCommand cmd = new SqlCommand(strSql, con.Conexao);

            //abre a conexao
            con.Conexao.Open();

            //define o tipo do comando 
            cmd.CommandType = CommandType.Text;
            //cria um dataadapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //cria um objeto datatable
            DataTable setor = new DataTable();

            //preenche o datatable via dataadapter
            da.Fill(setor);

            //atribui o datatable ao datagridview para exibir o resultado
            dGVPesquisa.DataSource = setor;

            dGVPesquisa.Refresh();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if(txtPesquisar.Text == "")
            {
                MessageBox.Show("Digite um nome!");
            }
            else
            {
                string strSql = "SELECT * FROM SETORES Where SET_NOME LIKE '" + txtPesquisar.Text + "'";

                con = new ConexaoDAL();
                SqlCommand cmd = new SqlCommand(strSql, con.Conexao);
                con.Conexao.Open();
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dGVPesquisa.DataSource = dt;
            }
           
        }

        private void dGVPesquisa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            btnSalvar.Enabled = false;
           txtCod.Text = dGVPesquisa.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNomeSetor.Text = dGVPesquisa.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Atualizar();
            btnSalvar.Enabled = true;
        }
    }
}
