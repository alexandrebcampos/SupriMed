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
    public partial class FrmCadLogin : ProjetoSupriMed.FormBase.FrmBase
    {
        CadLoginBLL bll = new CadLoginBLL();
        ConexaoDAL con;
        public FrmCadLogin()
        {
            InitializeComponent();
            CarregaValoresCliente();
            CarregaComboPri();
        }

        #region Metodos Salvar/Excluir/Atualizar entre outros
        
        public override bool Salvar()
        {
            //string cpf;
            //cpf = cBCPF.Text;
            

                if (cBCPF.SelectedText == "" && txtUsuario.Text == "" && txtSenha.Text == "" && cBPrivilegio.SelectedText == "")
                {

                    MessageBox.Show("Preencha todos os campos!");

                }
                else
                {
                
				        LoginDTO dto = new LoginDTO();
				        dto.FUNC_CPF = cBCPF.SelectedValue.ToString();
				        dto.LOG_USUARIO = txtUsuario.Text;
				        dto.LOG_SENHA = txtSenha.Text;
				        dto.LOG_PRIVILEGIO = cBPrivilegio.SelectedText;
				        dto.LOG_DATACADASTRO = DateTime.Parse(dTPDataCadastro.Text);

                //if (bll.VerificaDados(cpf))
                //{
                //    MessageBox.Show("Esse Cpf ja possui um login cadastrado!");
                //}else
                //{
                    bll.Salvar(dto);
                    LimpaControles();
                    CarregaGrid();
                    //return false;
                //}
                
                   
            

            }
            return true;
        }


        public override bool Excluir()
        {
            if (cBCPF.SelectedText == "")
            {
                MessageBox.Show("Escolha um cpf para deletar!");
                return false;
            }
            else
            {
                var result = MessageBox.Show("Deseja realmente deletar esse usuario?", "Exclusão de Login", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    LoginDTO dto = new LoginDTO();
                    dto.FUNC_CPF = cBCPF.SelectedValue.ToString();

                    bll.Excluir(dto);
                    LimpaControles();
                    CarregaGrid(); 
                    return true;
                }
            }

            return false;

        }

        public override bool Atualizar()
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Selecione um usuário!");
                return false;
            }
            else
            {
                var result = MessageBox.Show("Deseja realmente atualizar esse usuario?", "Atualização de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    lbDataCadastro.Visible = false;
                    dTPDataCadastro.Visible = false;
                    cBCPF.Focus();
                    cBPrivilegio.Focus();

                    LoginDTO dto = new LoginDTO();
                    dto.FUNC_CPF = cBCPF.SelectedValue.ToString();
                    dto.LOG_USUARIO = txtUsuario.Text;
                    dto.LOG_SENHA = txtSenha.Text;
                    dto.LOG_PRIVILEGIO = cBPrivilegio.SelectedText;
                    dto.LOG_ATUALIZADOEM = DateTime.Parse(dTPAtualizacaoCad.Text);

                    bll.Atualizar(dto);
                    CarregaGrid();
                    LimpaControles();
                    return true;
                }
            }

            return false;
        }


        public override void CarregaValoresCliente()
        {
            //cBCPF.DropDownStyle = ComboBoxStyle.DropDownList;
            cBCPF.DataSource = bll.CarregaCombo();
            cBCPF.ValueMember = "FUNC_CPF";
            cBCPF.DisplayMember = "FUNC_NOME";
            cBCPF.Update();
        }

        public void CarregaComboPri()
        {
            cBPrivilegio.DisplayMember = "Text";
            cBPrivilegio.ValueMember = "Value";

            var items = new[] {
                new { Text = "ADMINISTRADOR", Value = "ADMINISTRADOR" },
                new { Text = "OPERADOR", Value = "OPERADOR" }

            };

            cBPrivilegio.DataSource = items;
        }

        public override void LimpaControles()
        {
            cBCPF.Text = "";
            txtSenha.Text = "";
            txtUsuario.Text = "";
            cBPrivilegio.Text = "";
            
        }

        public override void HabilitaDesabilitaControles(bool bValue)
        {
            base.HabilitaDesabilitaControles(bValue);
            dTPDataCadastro.Enabled = false;
            dTPAtualizacaoCad.Enabled = false;
            btnSalvar.Enabled = true;
           
        }
        #endregion


        #region Eventos
        private void cBCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cBPrivilegio_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void FrmCadLogin_Load(object sender, EventArgs e)
        {
            gBPesquisa.Enabled = true;
            dTPDataCadastro.Text = DateTime.Now.ToString();
            dTPAtualizacaoCad.Text = DateTime.Now.ToString();
            dGVExibirPesquisa.AutoGenerateColumns = false;
            CarregaGrid();

        }

        public void CarregaGrid()
        {
            con = new ConexaoDAL();
            string strSql = "SELECT FUNC_CPF,LOG_USUARIO,LOG_SENHA,LOG_PRIVILEGIO,LOG_DATACADASTRO,LOG_ATUALIZADOEM FROM LOGIN order by FUNC_CPF";
            SqlCommand cmd = new SqlCommand(strSql, con.Conexao);

            //abre a conexao
            con.Conexao.Open();

            //define o tipo do comando 
            cmd.CommandType = CommandType.Text;
            //cria um dataadapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            //cria um objeto datatable
            DataTable login = new DataTable();

            //preenche o datatable via dataadapter
            da.Fill(login);

            //atribui o datatable ao datagridview para exibir o resultado
           dGVExibirPesquisa.DataSource = login;

            dGVExibirPesquisa.Refresh();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rBCPF.Checked)
            {
                dGVExibirPesquisa.DataSource = null;
                dGVExibirPesquisa.Rows.Clear();
                dGVExibirPesquisa.Refresh();
            string strSql = "SELECT * FROM LOGIN Where FUNC_CPF LIKE '" + txtPesquisar.Text + "'";

            con = new ConexaoDAL();
            SqlCommand cmd = new SqlCommand(strSql, con.Conexao);
            con.Conexao.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();

            da.Fill(dt);

                dGVExibirPesquisa.DataSource = dt;

            }
            else if(rBUsuario.Checked)
            {
                dGVExibirPesquisa.DataSource = null;
                dGVExibirPesquisa.Rows.Clear();
                dGVExibirPesquisa.Refresh();
                string strSql = "SELECT * FROM LOGIN Where LOG_USUARIO LIKE '" + txtPesquisar.Text + "'";

                con = new ConexaoDAL();
                SqlCommand cmd = new SqlCommand(strSql, con.Conexao);
                con.Conexao.Open();
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);
                dGVExibirPesquisa.DataSource = dt;

                if (dGVExibirPesquisa.Rows.Count == 0)
                {

                    MessageBox.Show("Nenhum registro encontrado !");
                    txtPesquisar.Text = "";
                }
            }
        }
        #endregion

        private void cBCPF_SelectedValueChanged(object sender, EventArgs e)
        {
            //txtFuncionario.Text = cBCPF.SelectedValue.ToString();
        }

        private void dGVExibirPesquisa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HabilitaDesabilitaControles(true);
            btnSalvar.Enabled = false;
            cBCPF.Focus();

            cBCPF.SelectedValue = dGVExibirPesquisa.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUsuario.Text = dGVExibirPesquisa.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSenha.Text = dGVExibirPesquisa.Rows[e.RowIndex].Cells[2].Value.ToString();
            cBPrivilegio.Text = dGVExibirPesquisa.Rows[e.RowIndex].Cells[3].Value.ToString();
            dTPAtualizacaoCad.Text = dGVExibirPesquisa.Rows[e.RowIndex].Cells[4].Value.ToString();
              
        }
    }
}
