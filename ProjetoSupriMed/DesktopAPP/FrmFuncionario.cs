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
    public partial class FrmFuncionario : ProjetoSupriMed.FormBase.FrmBase
    {

        ConexaoDAL con = new ConexaoDAL();
        CadFuncionarioBLL bll = new CadFuncionarioBLL();
        public FrmFuncionario()
        {
            InitializeComponent();
            CarregaValoresFuncionario();
            btnDeletar.Visible = true;
        }

        public override bool Salvar()
        {
            string cpf;

            if (txtNome.Text ==" " || dtpDataNascimento.Text ==" "  || mtbCpf.Text =="" || cbSetId.Text =="" || txtEmail.Text =="" || txtEndereco.Text =="" || txtBairro.Text =="" || txtCidade.Text =="" || cbEstado.Text =="" || txttelefone.Text == "" || txtSalario.Text == "")
            {

                MessageBox.Show("Preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            if (CadFuncionarioBLL.ValidaTelefone(txttelefone.Text) == false)
            {
                MessageBox.Show("Telefone esta  em um formato invalido!");
               
            }
                 
            else
            {
                FuncionariosDTO dto = new FuncionariosDTO();

                dto.FUNC_NOME = txtNome.Text;
                dto.FUNC_DATANASC = DateTime.Parse(dtpDataNascimento.Text);
                dto.FUNC_CPF = mtbCpf.Text;
                dto.SET_ID = int.Parse(cbSetId.SelectedValue.ToString());
                dto.FUNC_EMAIL = txtEmail.Text;
                dto.FUNC_ENDERECO = txtEndereco.Text;
                dto.FUNC_BAIRRO = txtBairro.Text;
                dto.FUNC_CIDADE = txtCidade.Text;
                dto.FUNC_ESTADO = cbEstado.Text;
                dto.FUNC_TELEFONE = int.Parse(txttelefone.Text);
                dto.FUNC_SALARIO = double.Parse(txtSalario.Text);


                cpf = mtbCpf.Text;


                if (bll.VerificaDados(cpf) == false)
                {
                    MessageBox.Show("CPF ja cadastrado!");
                }
                else
                {

                    bll.Salvar(dto);
                    CarregaGrid();
                    return true;
                }


            }
            return false;
        }

        public override bool Atualizar()
        {
            var result = MessageBox.Show("Deseja realmente atualizar o cadastro deste funcionario?", "Atualização de Dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {


                FuncionariosDTO dto = new FuncionariosDTO();
                dto.FUNC_NOME = txtNome.Text;
                dto.FUNC_DATANASC = DateTime.Parse(dtpDataNascimento.Text);
                dto.FUNC_CPF = mtbCpf.Text;
                dto.SET_ID = int.Parse(cbSetId.SelectedValue.ToString());
                dto.FUNC_EMAIL = txtEmail.Text;
                dto.FUNC_ENDERECO = txtEndereco.Text;
                dto.FUNC_BAIRRO = txtBairro.Text;
                dto.FUNC_CIDADE = txtCidade.Text;
                dto.FUNC_ESTADO = cbEstado.SelectedText;
                dto.FUNC_TELEFONE = int.Parse(txttelefone.Text);
                dto.FUNC_SALARIO = double.Parse(txtSalario.Text);


                bll.Atualizar(dto);
                CarregaGrid();

                return true;

            }

            return false;
        }

        public  void CarregaValoresFuncionario()
        {
            cbSetId.DataSource = bll.CarregaCombo();
            cbSetId.ValueMember = "SET_ID";
            cbSetId.DisplayMember = "SET_NOME";
            cbSetId.Update();
        }

        private void cbSetId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }


        public override void LimpaControles()
        {
            txtNome.Text = "";
            dtpDataNascimento.Text = "";
            mtbCpf.Text = "";
            txtEmail.Text = ""; ;
            txtEndereco.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            cbEstado.SelectedText = "";
            txttelefone.Text = "";
            txtSalario.Text = "";
        }

        public void CarregaGrid()
        {
            string strSql = "SELECT * FROM FUNCIONARIOS order by FUNC_CPF";

            con = new ConexaoDAL();
            SqlCommand cmd = new SqlCommand(strSql, con.Conexao);
            con.Conexao.Open();
            cmd.CommandText = strSql;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            dtgvPesquisa.DataSource = dataSet;
            dtgvPesquisa.DataMember = dataSet.Tables[0].TableName;
        }

        private void bntPesquisa_Click(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void dtgvPesquisa_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            mtbCpf.Text = dtgvPesquisa.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNome.Text = dtgvPesquisa.Rows[e.RowIndex].Cells[1].Value.ToString();
            dtpDataNascimento.Text = dtgvPesquisa.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dtgvPesquisa.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtEndereco.Text = dtgvPesquisa.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtBairro.Text = dtgvPesquisa.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtCidade.Text = dtgvPesquisa.Rows[e.RowIndex].Cells[6].Value.ToString();
            cbEstado.Text = dtgvPesquisa.Rows[e.RowIndex].Cells[7].Value.ToString();
            txttelefone.Text = dtgvPesquisa.Rows[e.RowIndex].Cells[8].Value.ToString();
            cbSetId.SelectedValue = dtgvPesquisa.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtSalario.Text = dtgvPesquisa.Rows[e.RowIndex].Cells[10].Value.ToString();
        }



        private void cbSetId_SelectedValueChanged(object sender, EventArgs e)
        {

            //txtIdSet.Text = cbSetId.SelectedValue.ToString();
            //txtIdSet.Enabled = false;
            //txtIdSet.Visible = true;
        }


        //Validaçoes 
        private void txtNome_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtNome.Text, @"^[a-z A-Z]+$"))
            {
                lbErro.Visible = true;
                lbErro.Text = "Erro no campo Nome introduza apenas as letras";
                txtNome.Focus();

            }
            else
            {
                lbErro.Visible = false;
            }
        }

        private void txtEndereco_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtEndereco.Text, @"^[a-z A-Z]+$"))
            {
                lbErroEdn.Visible = true;
                lbErroEdn.Text = "Erro no campo Endereço introduza apenas as letras";
                txtEndereco.Focus();
            }
            else
            {
                lbErroEdn.Visible = false;
            }
        }

        private void txtBairro_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtBairro.Text, @"^[a-z A-Z]+$"))
            {
                lbBrErro.Visible = true;
                lbBrErro.Text = "Erro no campo Bairro introduza apenas as letras";
                txtBairro.Focus();
            }
            else
            {
                lbBrErro.Visible = false;
            }
        }

        private void txtCidade_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtCidade.Text, @"^[a-z A-Z]+$"))
            {
                lbErroCit.Visible = true;
                lbErroCit.Text = "Erro no campo Cidade introduza apenas as letras";
                txtCidade.Focus();
            }
            else
            {
                lbErroCit.Visible = false;
            }
        }

    
        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {

                e.Handled = true;
                lbSaErro.Visible = true;
                lbSaErro.Text = "Erro!! Iforme apenas numeros";

            }
            else
            {
                lbSaErro.Visible = false;
            }
        }

        public override void HabilitaBotao(bool value)
        {

            btnDeletar.Visible = false;
            //toolStripSeparator3.Visible = false;
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            HabilitaBotao(false);
            dtgvPesquisa.AutoGenerateColumns = false;
            CarregaGrid();
        }

        private void bntPesquisa_Click_1(object sender, EventArgs e)
        {
            string strSql = "SELECT * FROM FUNCIONARIOS Where FUNC_CPF LIKE '" + pesqcpf.Text + "'";

            con = new ConexaoDAL();
            SqlCommand cmd = new SqlCommand(strSql, con.Conexao);
            con.Conexao.Open();
            cmd.CommandText = strSql;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            dtgvPesquisa.DataSource = dataSet;
            dtgvPesquisa.DataMember = dataSet.Tables[0].TableName;
        }

        private void mtbCpf_TextChanged(object sender, EventArgs e)
        {
         

            bll.Verifica(mtbCpf.Text);
        }
    }


}
