using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoSupriMed.DesktopAPP;

namespace ProjetoSupriMed.FormBase
{
    public partial class FrmBase : Form
    {


        public FrmBase()
        {
            InitializeComponent();
        }

        private void FrmBase_Load(object sender, EventArgs e)
        {
           
            LimpaControles();
            HabilitaDesabilitaControles(true);
        }

        public void FrmBase_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }


        #region Metodos Virtuais Salvar,Excluir,Pesquisar e Carregar Dados
        public virtual bool Salvar()
        {
            return false;
        }

        public virtual bool Excluir()
        {
            return false;
        }

        public virtual bool Atualizar()
        {
            return false;
        }

        public virtual void CarregaValoresCliente()
        {

        }
        #endregion

        #region Eventos dos botões
        public void btnNovo_Click(object sender, EventArgs e)
        {
            HabilitaDesabilitaControles(true);
            LimpaControles();
            btnSalvar.Enabled = true;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (Salvar())
            {

                //HabilitaDesabilitaControles(true);
                LimpaControles();
                MessageBox.Show("Registro salvo com sucesso", "Aviso do Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            if (Excluir())
            {
                
                LimpaControles();
                MessageBox.Show("Registro excluido com sucesso", "Aviso do Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Metodos de limpar,hablitar controles e status do cadastro
        public virtual void HabilitaDesabilitaControles(bool bValue)
        {
            foreach (Control ctl in this.Controls)
            {
                if (ctl is ToolStrip)
                    continue;
                ctl.Enabled = bValue;
            }          
        }

        public virtual void HabilitaBotao(bool value)
        {
           
            btnNovo.Enabled = true;
            btnSalvar.Enabled = true;
            btnDeletar.Enabled = true;
            btnAtualizar.Enabled = true;
            btnVoltar.Enabled = true;
            toolStripSeparator3.Visible = true;
        }

        public virtual void LimpaControles()
        {
            foreach (Control ctl in this.Controls)
            {

                if (ctl is ComboBox)
                    (ctl as ComboBox).SelectedIndex = -1;
                if (ctl is ListBox)
                    (ctl as ListBox).SelectedIndex = -1;
                if (ctl is RadioButton)
                    (ctl as RadioButton).Checked = false;
                if (ctl is CheckBox)
                    (ctl as CheckBox).Checked = false;
                if (ctl is CheckedListBox)
                {
                    foreach (ListControl item in (ctl as CheckedListBox).Items)
                        item.SelectedIndex = -1;
                }
            }
        }

      
        #endregion

        public void btnAtualizar_Click(object sender, EventArgs e)
        {
            if (Atualizar())
            {
                

                LimpaControles();
                MessageBox.Show("Registro atualizado com sucesso", "Aviso do Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
