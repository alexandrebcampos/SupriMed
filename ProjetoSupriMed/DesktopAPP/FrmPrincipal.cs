using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoSupriMed.Code.DTO;
using ProjetoSupriMed.DesktopAPP.FormManutencao;

namespace ProjetoSupriMed.DesktopAPP
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();

            tSSLExibiData.Text = DateTime.Today.ToString("dd/MM/yyyy");

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            tSSLUsuarioLogado.Text = UsuarioLogadoDTO.UsuarioLogado;
        }

        private void btnTSBLogout_Click(object sender, EventArgs e)
        {
            FrmLoginAcesso login = new FrmLoginAcesso();
            login.Show();
            this.Visible = false;
        }

        private void btnTSBSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLoginAcesso login = new FrmLoginAcesso();
            login.Show();
            this.Visible = false;
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadLogin clogin = new FrmCadLogin();
            clogin.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
                FrmCliente cli = new FrmCliente();
                cli.ShowDialog();
                       
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBackup ba = new FrmBackup();
            ba.ShowDialog();
        }

        private void peçasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPecas pec = new FrmPecas();
            pec.ShowDialog();
        }

        private void agendarVisitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgendaVisitas a = new FrmAgendaVisitas();
            a.ShowDialog();
        }

        private void tSDDBAgendamentos_Click(object sender, EventArgs e)
        {

        }

        private void tSDDBVendas_Click(object sender, EventArgs e)
        {

        }

        private void consultarVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaVendas a = new ConsultaVendas();
            a.ShowDialog();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProduto p = new FrmProduto();
            p.ShowDialog();
        }

        private void realizarVendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVendas v = new FrmVendas();
            v.ShowDialog();
        }

        private void consultarVisitasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmConsultaVisita cV = new FrmConsultaVisita();
            cV.ShowDialog();
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmFuncionario f = new FrmFuncionario();
            f.ShowDialog();
        }

        private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadVendedor v = new FrmCadVendedor();
            v.ShowDialog();
        }

        private void setoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadSetores s = new FrmCadSetores();
            s.ShowDialog();
        }

        private void sSRodape_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tSSSLExibirHora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
    }
}
