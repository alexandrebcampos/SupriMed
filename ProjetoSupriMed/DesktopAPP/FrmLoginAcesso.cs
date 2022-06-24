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

namespace ProjetoSupriMed.DesktopAPP
{
    public partial class FrmLoginAcesso : Form
    {

        
        public FrmLoginAcesso()
        {
            InitializeComponent();
        }

        AutenticarBLL bll = new AutenticarBLL();

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
            if (txtUsuarioLogin.Text == "" || txtSenhaLogin.Text == "")
            {
                MessageBox.Show("Informe um usuário e a senha.");
                return;
            }
            try
            {
                LoginDTO login = new LoginDTO();            
                login.LOG_USUARIO = txtUsuarioLogin.Text;
                login.LOG_SENHA = txtSenhaLogin.Text;
                


                    if (bll.AutenticarUsuario(login) == false)
                    {
                        MessageBox.Show("Usuario ou Senha invalidas!");
                    }
                    else
                    {


                        MessageBox.Show("Bem-Vindo " + txtUsuarioLogin.Text, "Aviso do Sistema",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        FrmPrincipal p = new FrmPrincipal();
                        UsuarioLogadoDTO.UsuarioLogado = txtUsuarioLogin.Text;
                        p.Show();
                        this.Visible = false;


                    }
                

                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro " + ex.Message);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
