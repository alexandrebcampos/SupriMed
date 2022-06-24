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
using ProjetoSupriMed.Code.DTO;
using System.Data.SqlClient;
using ProjetoSupriMed.Code.DAL;
using System.Text.RegularExpressions;

namespace ProjetoSupriMed.DesktopAPP
{
    public partial class FrmPecas : Form
    {
        public FrmPecas()
        {
            InitializeComponent();
        }
              
      
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void btnPesquisaPeca_Click(object sender, EventArgs e)
        {
            //txtcodigo.Enabled     = true;
            txtfabricante.Enabled = true;
            txtnome.Enabled       = true;
            txtqtde.Enabled       = true;

            btnDeletar.Enabled    = true;
            btnAtualizar.Enabled  = true;


            if (rBCod.Checked)
            {
                dgvPesquisaPeca.DataSource = null;
                dgvPesquisaPeca.Rows.Clear();
                dgvPesquisaPeca.Refresh();
                string strSql = "SELECT * FROM PECAS Where PEC_ID LIKE '" + txtPesquisaPeca.Text + "'";

                ConexaoDAL conn = new ConexaoDAL();
                SqlCommand cmd = new SqlCommand(strSql, conn.Conexao);
                conn.Conexao.Open();
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvPesquisaPeca.DataSource = dt;

            }
            else if (rbPeca.Checked)
            {
                dgvPesquisaPeca.DataSource = null;
                dgvPesquisaPeca.Rows.Clear();
                dgvPesquisaPeca.Refresh();
                string strSql = "SELECT * FROM PECAS Where PEC_NOME LIKE '" + txtPesquisaPeca.Text + "'";

                ConexaoDAL conn = new ConexaoDAL();
                SqlCommand cmd = new SqlCommand(strSql, conn.Conexao);
                conn.Conexao.Open();
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);
                dgvPesquisaPeca.DataSource = dt;
            }
            txtPesquisaPeca.Text = "";
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            PecasBLL pecaBll = new PecasBLL();
            PecasDTO pecaDto = new PecasDTO();

            //pecaDto.PEC_ID = int.Parse(txtcodigo.Text);

            pecaBll.Excluir(pecaDto);

            MessageBox.Show("Peça excluída com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //txtcodigo.Text     = "";
            txtfabricante.Text = "";
            txtnome.Text       = "";
            txtqtde.Text       = "";
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            PecasBLL pecaAtualiza = new PecasBLL();
            PecasDTO pecaDto = new PecasDTO();

            //pecaDto.PEC_ID = int.Parse(txtcodigo.Text);
            pecaDto.PEC_NOME = txtnome.Text;
            pecaDto.PEC_FABRICANTE = txtfabricante.Text;
            pecaDto.PEC_QUANTIDADE = int.Parse(txtqtde.Text);

            pecaAtualiza.AtualizaPeca(pecaDto);

            MessageBox.Show("Peça atualizada com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

           // txtcodigo.Text = "";
            txtnome.Text = "";
            txtfabricante.Text = "";
            txtqtde.Text = "";

        }

        private void btnNovo_Click_1(object sender, EventArgs e)
        {
            //txtcodigo.Enabled     = true;
            txtnome.Enabled       = true;
            txtfabricante.Enabled = true;
            txtqtde.Enabled       = true;
            btnSalvar.Enabled     = true;

            GeraNumero();

            txtnome.Focus();
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            btnDeletar.Enabled = true;
            btnAtualizar.Enabled = true;
            PecasBLL pecas = new PecasBLL();
            PecasDTO pecDto = new PecasDTO();


            if (txtnome.Text == "" || txtfabricante.Text == "" || txtqtde.Text == "")
            {
                MessageBox.Show("Preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //pecDto.PEC_ID = Convert.ToInt32(txtCodigo.Text);
                pecDto.PEC_NOME = txtnome.Text;
                pecDto.PEC_FABRICANTE = txtfabricante.Text;
                pecDto.PEC_QUANTIDADE = int.Parse(txtqtde.Text);


                pecas.Salvar(pecDto);

                MessageBox.Show("Cadastro efetuado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtnome.Text = "";
                txtfabricante.Text = "";
                txtqtde.Text = "";


                

            }

        }

        private void btnVoltar_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvPesquisaPeca_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

           
          
        }
        public void GeraNumero()
        {

            GerandoAutoIncrementoPecas.AutoIncremento("SELECT MAX(PEC_ID) FROM PECAS",txtCodigo);

        }

        private void txtnome_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtnome.Text, @"^[a-z A-Z]+$"))
            {
                //lbErroNome.Visible = true;
                //lbErroNome.Text = "Erro no campo Nome insira apenas letras";
                //txtnome.Focus();
            }
            else
            {
                //lbErroNome.Visible = false;
        }
        }

        private void txtfabricante_Validating(object sender, CancelEventArgs e)
        {
            GerandoAutoIncrementoPecas.AutoIncremento("SELECT MAX(PEC_ID) FROM PECAS", txtCodigo);
        }

        private void txtqtde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                //lbErroQnt.Visible = true;
                //lbErroQnt.Text = "Erro!! Informe apenas números";
            }
            else
            {
                //lbErroQnt.Visible = false;
            }
        }

        private void FrmPecas_Load(object sender, EventArgs e)
        {
            btnDeletar.Visible = false;
        }

        private void dgvPesquisaPeca_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgvPesquisaPeca.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtnome.Text = dgvPesquisaPeca.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtfabricante.Text = dgvPesquisaPeca.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtqtde.Text = dgvPesquisaPeca.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }

} 

