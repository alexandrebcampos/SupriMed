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
using ProjetoSupriMed.Code.DTO.Validação;
using System.Text.RegularExpressions;

namespace ProjetoSupriMed.DesktopAPP
{
    public partial class FrmCliente : Form
    {
        ClienteBLL cliente = new ClienteBLL();
        ClientesDTO cliDto = new ClientesDTO();

        ConexaoDAL conn;
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string cpf = txtcpf.Text;


            if (txtcpf.Text == "" || txttelefone.Text == "" || txtnumero.Text == "" || txtnome.Text == "" || txtsobrenome.Text == "" || txtendereco.Text == "" || txtemail.Text == "" || txtcidade.Text == "" || txtbairro.Text == "")
            {
                MessageBox.Show("Preencha todos os campos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(CadFuncionarioBLL.ValidaTelefone(txttelefone.Text)== false)
            {
                MessageBox.Show("Telefone está em formato inválido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                cliDto.CLI_CPF = txtcpf.Text;
                cliDto.CLI_PRIMNOME = txtnome.Text;
                cliDto.CLI_ULTNOME = txtsobrenome.Text;
                cliDto.CLI_DATANASC = DateTime.Parse(dtpdatanasc.Text);
                cliDto.CLI_EMAIL = txtemail.Text;
                cliDto.CLI_ENDERECO = txtendereco.Text;
                cliDto.CLI_ESTADO = cbuf.Text;
                cliDto.CLI_BAIRRO = txtbairro.Text;
                cliDto.CLI_CIDADE = txtcidade.Text;
                cliDto.CLI_TELEFONE = Convert.ToDecimal(txttelefone.Text);
                cliDto.CLI_CASANUMERO = int.Parse(txtnumero.Text);
                cliDto.CLI_SEXO = cBSexo.Text;
               


                        btnDeletar.Enabled = true;
                        btnAtualizar.Enabled = true;
               
                cliente.Salvar(cliDto);

                        CarregaGrid();

                        MessageBox.Show("Registro Incluído com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LimpaControles();
              }         
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
                               
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MtbDatanasc_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if(e.ReturnValue != null)
            {
                DateTime data = (DateTime)e.ReturnValue;
            }
            else
            {
                MessageBox.Show("Por favor verifique a data digitada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
                  

        private void btnNovo_Click(object sender, EventArgs e)
        {
            AbilitaTextBox();
            btnSalvar.Enabled = true;
            btnDeletar.Enabled = true;
            btnAtualizar.Enabled = true;
            LimpaControles();
        }
       
        
        private void btnPesquisa_Click(object sender, EventArgs e)
        {
            AbilitaTextBox();
            btnDeletar.Enabled   = true;
            btnAtualizar.Enabled = true;
                        
            if (rbCPF.Checked)
            {
                dgvPesquisaCliente.DataSource = null;
                dgvPesquisaCliente.Rows.Clear();
                dgvPesquisaCliente.Refresh();
                string strSql = "SELECT * FROM CLIENTES Where CLI_CPF LIKE '" + txtpesquisa.Text + "'";

                ConexaoDAL conn = new ConexaoDAL();
                SqlCommand cmd = new SqlCommand(strSql, conn.Conexao);
                conn.Conexao.Open();
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvPesquisaCliente.DataSource = dt;

            }
            else if (rbnome.Checked)
            {
                dgvPesquisaCliente.DataSource = null;
                dgvPesquisaCliente.Rows.Clear();
                dgvPesquisaCliente.Refresh();
                string strSql = "SELECT * FROM CLIENTES Where CLI_PRIMNOME LIKE '" + txtpesquisa.Text + "'";

                ConexaoDAL conn = new ConexaoDAL();
                SqlCommand cmd = new SqlCommand(strSql, conn.Conexao);
                conn.Conexao.Open();
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                DataTable dt = new DataTable();

                da.Fill(dt);
                dgvPesquisaCliente.DataSource = dt;
                dgvPesquisaCliente.RefreshEdit();
            }
            txtpesquisa.Text = "";
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            ClienteBLL cliDeleta = new ClienteBLL();
            ClientesDTO cliDtoDeleta = new ClientesDTO();
            cliDtoDeleta.CLI_CPF = txtcpf.Text;
            cliDeleta.Excluir(cliDtoDeleta);

            MessageBox.Show("Cliente deletado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpaControles();

            
        }

        
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ClienteBLL cliBll = new ClienteBLL();
            ClientesDTO cliDto = new ClientesDTO();

            cliDto.CLI_CPF        = txtcpf.Text;
            cliDto.CLI_PRIMNOME   = txtnome.Text;
            cliDto.CLI_ULTNOME    = txtsobrenome.Text;
            cliDto.CLI_DATANASC   = DateTime.Parse(dtpdatanasc.Text);
            cliDto.CLI_ENDERECO   = txtendereco.Text;
            cliDto.CLI_CIDADE     = txtcidade.Text;
            cliDto.CLI_BAIRRO     = txtbairro.Text;
            cliDto.CLI_CASANUMERO = int.Parse(txtnumero.Text);
            cliDto.CLI_EMAIL      = txtemail.Text;
            cliDto.CLI_ESTADO     = cbuf.Text;
            cliDto.CLI_SEXO       = cBSexo.Text;
            cliDto.CLI_TELEFONE   = Convert.ToChar(txttelefone.Text);

            cliBll.Atualizar(cliDto);
            CarregaGrid();
            MessageBox.Show("Cliente atualizado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);

            LimpaControles();
        }

       /* private void txtcpf_Leave(object sender, EventArgs e)
        {
            string valor = txtcpf.Text;
            if (ValidaCPF.IsCpf(valor))
            {
                
            }
            else
            {
                MessageBox.Show("CPF Inválido!");
                txtcpf.Text = "";
                txtcpf.Focus();
            }
        }*/
        public void LimpaControles()
        {
            txtcpf.Text = "";
            dtpdatanasc.Text = "";
            txttelefone.Text = "";
            txtnome.Text = "";
            txtsobrenome.Text = "";
            txtendereco.Text = "";
            txtemail.Text = "";
            txtcidade.Text = "";
            txtbairro.Text = "";
            cbuf.Text = "";
            txtnumero.Text = "";
    
        }
        private void CarregaGrid()
        {
            string strSql = "SELECT * FROM CLIENTES ORDER BY CLI_CPF ";


            conn = new ConexaoDAL();
            SqlCommand cmd = new SqlCommand(strSql, conn.Conexao);
            conn.Conexao.Open();
            cmd.CommandText = strSql;

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = cmd;

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            dgvPesquisaCliente.DataSource = dataSet;
            dgvPesquisaCliente.DataMember = dataSet.Tables[0].TableName;

            dgvPesquisaCliente.Refresh();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            btnDeletar.Visible = false;
            dgvPesquisaCliente.AutoGenerateColumns = false;
            CarregaGrid();
            CarregaComboSexo();
        }
        private void AbilitaTextBox()
        {
            txtcpf.Enabled = true;
            txtbairro.Enabled = true;
            txtcidade.Enabled = true;
            txtemail.Enabled = true;
            txtendereco.Enabled = true;
            txtnome.Enabled = true;
            txtsobrenome.Enabled = true;
            txttelefone.Enabled = true;
            txtcpf.Enabled = true;
            cbuf.Enabled = true;
            dtpdatanasc.Enabled = true;
            txtnumero.Enabled = true;
            cBSexo.Enabled = true;
            txtcpf.Focus();
        }

        private void dgvPesquisaCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AbilitaTextBox();
            txtcpf.Enabled = false;
            btnAtualizar.Enabled = true;
            
            //txtcpf.Text = dgvPesquisaCliente.Rows[e.RowIndex].Cells[0].Value.ToString();
            txttelefone.Text = dgvPesquisaCliente.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtnome.Text = dgvPesquisaCliente.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtsobrenome.Text = dgvPesquisaCliente.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtendereco.Text = dgvPesquisaCliente.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtemail.Text = dgvPesquisaCliente.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtcidade.Text = dgvPesquisaCliente.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtbairro.Text = dgvPesquisaCliente.Rows[e.RowIndex].Cells[6].Value.ToString();
            cbuf.Text = dgvPesquisaCliente.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtnumero.Text = dgvPesquisaCliente.Rows[e.RowIndex].Cells[11].Value.ToString();
            cBSexo.Text = dgvPesquisaCliente.Rows[e.RowIndex].Cells[10].Value.ToString();

            dgvPesquisaCliente.Refresh();
        }

        private void txtcpf_TextChanged(object sender, EventArgs e)
        {
            //cliente.VerificaDados(txtcpf.Text);

        }

        private void txtnome_Validating(object sender, CancelEventArgs e)
        {
            if(!Regex.IsMatch(txtnome.Text, @"^[a-z A-Z]+$"))
            {
                lbErroNome.Visible = true;
                lbErroNome.Text = "Erro no campo Nome insira apenas letras";                
                txtnome.Focus();               
            }
            else
            {
                lbErroNome.Visible = false;
            }
        }

        private void txtsobrenome_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtsobrenome.Text, @"^[a-z A-Z]+$"))
            {
                lbErroSobre.Visible = true;
                lbErroSobre.Text = "Erro no campo Sobrenome insira apenas letras";
                txtsobrenome.Focus();
            }
            else
            {
                lbErroSobre.Visible = false;
            }
        }

        private void txtendereco_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtendereco.Text, @"^[a-z A-Z]+$"))
            {
                lbErroEnd.Visible = true;
                lbErroEnd.Text = "Erro no campo Endereço insira apenas letras";
                txtendereco.Focus();
            }
            else
            {
                lbErroEnd.Visible = false;
            }
        }

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                lbErroNum.Visible = true;
                lbErroNum.Text = "Erro!! Informe apenas números";
            }
            else
            {
                lbErroNum.Visible = false;
            }
        }

        private void txtbairro_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtendereco.Text, @"^[a-z A-Z]+$"))
            {
                lbErroBairro.Visible = true;
                lbErroBairro.Text = "Erro no campo Bairro insira apenas letras";
                txtbairro.Focus();
            }
            else
            {
                lbErroBairro.Visible = false;
            }
        }

        private void txtcidade_Validating(object sender, CancelEventArgs e)
        {
            if (!Regex.IsMatch(txtendereco.Text, @"^[a-z A-Z]+$"))
            {
                lbErroCidade.Visible = true;
                lbErroCidade.Text = "Erro no campo Cidade insira apenas letras";
                txtbairro.Focus();
            }
            else
            {
                lbErroCidade.Visible = false;
            }
        }

        public void CarregaComboSexo()
        {
            cBSexo.DisplayMember = "Text";
            cBSexo.ValueMember = "Value";

            var items = new[] {
                new { Text = "M", Value = "M" },
                new { Text = "F", Value = "F" }

            };

            cBSexo.DataSource = items;
        }
        //#endregion
    }
}
    

