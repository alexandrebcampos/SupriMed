using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProjetoSupriMed.Code.BLL;
using ProjetoSupriMed.Code.DAL;
using System.Data.SqlClient;
using ProjetoSupriMed.Code.DTO;

namespace ProjetoSupriMed.DesktopAPP
{
    public partial class FrmAgendaVisitas : ProjetoSupriMed.FormBase.FrmBase
    {
        AgendaVisitasBLL bll = new AgendaVisitasBLL();
        ConexaoDAL con;

        public FrmAgendaVisitas()
        {
            InitializeComponent();
        }

        #region Metodos
        public override bool Salvar()
        {
            if (cBCliente.SelectedText == "" && cBVendedor.SelectedText == "" && dTPData.Text == "" && dTPHora.Text == "" && txtDescrição.Text == "")
            {

                MessageBox.Show("Preencha todos os campos!");

            }
            else
            {
                try
                {
                    VisitasDTO dto = new VisitasDTO();
                    dto.CLI_CPF = cBCliente.SelectedValue.ToString();
                    dto.VEND_ID = int.Parse(cBVendedor.SelectedValue.ToString());
                    dto.VIS_DATA = DateTime.Parse(dTPData.Text);
                    dto.VIS_HORA = TimeSpan.Parse(dTPHora.Text);
                    dto.VIS_DESCRICAO = txtDescrição.Text;


                    bll.Salvar(dto);
                    CarregaGrid();

                    btnDeletar.Enabled = true;
                    btnAtualizar.Enabled = true;

                }catch(Exception)
                {

                }
                       

            }
            return true;
        }

        public override bool Excluir()
        {
            if (cBCliente.SelectedText == "")
            {
                MessageBox.Show("Escolha um cliente para deletar!");
                return false;
            }
            else
            {
                var result = MessageBox.Show("Deseja realmente deletar esse agendamento?", "Exclusão de Login", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    VisitasDTO dto = new VisitasDTO();
                    dto.CLI_CPF = cBCliente.SelectedValue.ToString();

                    bll.Excluir(dto);
                    CarregaGrid();
                    return true;
                }
            }

            return false;
        }

        public override bool Atualizar()
        {
            if (cBCliente.Text == "")
            {
                MessageBox.Show("Selecione um Cliente para atualizar!");
                return false;
            }
            else
            {
                var result = MessageBox.Show("Deseja realmente atualizar esse agendamento?", "Atualização de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    VisitasDTO dto = new VisitasDTO();
                    dto.CLI_CPF = cBCliente.SelectedValue.ToString();
                    dto.VEND_ID = int.Parse(cBVendedor.SelectedValue.ToString());
                    dto.VIS_DATA = DateTime.Parse(dTPData.Text);
                    dto.VIS_HORA = TimeSpan.Parse(dTPHora.Text);
                    dto.VIS_DESCRICAO = txtDescrição.Text;

                    bll.Atualizar(dto);
                    CarregaGrid();
                    LimpaControles();
                    return true;
                }

               
                return false;
            }
        }

        private void CarregaGrid()
        {
            con = new ConexaoDAL();
            string strSql = "SELECT CLI_CPF,VEND_ID,VIS_DATA,VIS_HORA,VIS_DESCRICAO FROM VISITAS order by CLI_CPF";
            SqlCommand cmd = new SqlCommand(strSql, con.Conexao);

            //abre a conexao
            con.Conexao.Open();

            //define o tipo do comando 
            cmd.CommandType = CommandType.Text;
            //cria um dataadapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //cria um objeto datatable
            DataTable a = new DataTable();

            //preenche o datatable via dataadapter
            da.Fill(a);

            //atribui o datatable ao datagridview para exibir o resultado
            dGVExibirPesquisa.DataSource = a;

            dGVExibirPesquisa.Refresh();
        }

        public override void LimpaControles()
        {       
            
            txtEndereco.Text  = "";
            txtBairro.Text    = "";
            txtCidade.Text    = "";
            txtUF.Text        = "";
            txtTelefone.Text  = "";
            txtNumero.Text    = "";
            cBCliente.Text = "";
            cBVendedor.Text = "";
            dTPData.Text      = "";
            dTPHora.Text      = "";
            txtDescrição.Text = "";
        }

        public override void HabilitaDesabilitaControles(bool bValue)
        {
            
            gBClientes.Enabled = true;
            gBVendedor.Enabled = true;
            gBAgendamento.Enabled = true;
            btnSalvar.Enabled = false;
            
        }
       

        public override void CarregaValoresCliente()
        {
            cBCliente.DataSource = bll.CarregaComboCpfCliente();
            cBCliente.ValueMember = "CLI_CPF";
            cBCliente.DisplayMember = "CLI_PRIMNOME";
            cBCliente.Update();
        }

        #endregion

        private void FrmAgendaVisitas_Load(object sender, EventArgs e)
        {
            LimpaControles();
            gBClientes.Enabled = false;
            gBVendedor.Enabled = false;
            gBAgendamento.Enabled = false;
            CarregaValoresCliente();
            bll.ComboVendedor(cBVendedor);
            dGVExibirPesquisa.AutoGenerateColumns = false;
            CarregaGrid();
        }

        public void ExibiDadosClientes()
        {
            ConexaoDAL con = new ConexaoDAL();
            string query = "SELECT CLI_CPF, CLI_PRIMNOME,CLI_ENDERECO,CLI_BAIRRO,CLI_CIDADE,CLI_ESTADO,CLI_TELEFONE,CLI_CASANUMERO FROM CLIENTES  where CLI_PRIMNOME = '" + cBCliente.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con.Conexao);
            SqlDataReader rd;

            try
            {
                con.Conectar();
                rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    string primnome = (string)rd["CLI_CPF"];
                    string end = (string)rd["CLI_ENDERECO"];
                    string bairro = (string)rd["CLI_BAIRRO"];
                    string cidade = (string)rd["CLI_CIDADE"];
                    string uf = (string)rd["CLI_ESTADO"];
                    decimal tel = System.Convert.ToDecimal(rd["CLI_TELEFONE"]);
                    int numero = System.Convert.ToInt32(rd["CLI_CASANUMERO"]);
                    cBCliente.SelectedValue = primnome;
                    txtEndereco.Text = end;
                    txtBairro.Text = bairro;
                    txtCidade.Text = cidade;
                    txtUF.Text = uf;
                    txtTelefone.Text = tel.ToString();
                    txtNumero.Text = numero.ToString();



                }

            }
            catch (Exception es)
            {
                MessageBox.Show(es.Message);
            }
        }

        private void cBCPFCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            
            ExibiDadosClientes();
        }

        private void cBIDVendedor_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cBCPFCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dGVExibirPesquisa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitaDesabilitaControles(true);
            btnSalvar.Enabled = false;
            cBCliente.Focus();

            cBCliente.SelectedValue = dGVExibirPesquisa.Rows[e.RowIndex].Cells[0].Value.ToString();
            cBVendedor.SelectedValue = dGVExibirPesquisa.Rows[e.RowIndex].Cells[1].Value.ToString();
            dTPData.Text = dGVExibirPesquisa.Rows[e.RowIndex].Cells[2].Value.ToString();
            dTPHora.Text = dGVExibirPesquisa.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtDescrição.Text = dGVExibirPesquisa.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rBCliente.Checked)
            {
                dGVExibirPesquisa.DataSource = null;
                dGVExibirPesquisa.Rows.Clear();
                dGVExibirPesquisa.Refresh();
                string strSql = "SELECT * FROM VISITAS Where CLI_CPF LIKE '" + txtPesquisar.Text + "'";

                con = new ConexaoDAL();
                SqlCommand cmd = new SqlCommand(strSql, con.Conexao);
                con.Conexao.Open();
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dGVExibirPesquisa.DataSource = dt;

            }
            else if (rBVendedor.Checked)
            {
                dGVExibirPesquisa.DataSource = null;
                dGVExibirPesquisa.Rows.Clear();
                dGVExibirPesquisa.Refresh();
                string strSql = "SELECT * FROM VISITAS Where VEND_ID LIKE '" + txtPesquisar.Text + "'";

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

        private void cBVendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
