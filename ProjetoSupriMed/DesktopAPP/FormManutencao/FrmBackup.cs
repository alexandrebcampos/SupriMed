using ProjetoSupriMed.Code.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSupriMed.DesktopAPP.FormManutencao
{
    public partial class FrmBackup : Form
    {
        ConexaoDAL con;
        private SqlDataReader reader;
        string sql = "";

        public FrmBackup()
        {
            InitializeComponent();
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            cBDataBase.Enabled = false;
            btnBackup.Enabled = false;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {

                if(cBDataBase.Text.CompareTo("")==0)
                {
                    MessageBox.Show("Selecione a base de dados!");
                    return;
                }else
                {
                    con = new ConexaoDAL();
                    con.Conectar();
                    sql = "BACKUP DATABASE " + cBDataBase.Text + " TO DISK = '" + txtLocal.Text + "\\" + cBDataBase.Text + "-" + DateTime.Now.Ticks.ToString() + ".bak'";
                    SqlCommand command = new SqlCommand(sql, con.Conexao);
                    command.ExecuteNonQuery();
                    con.Conexao.Close();
                    con.Conexao.Dispose();
                    MessageBox.Show("Backup realizado com sucesso!");
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbl = new FolderBrowserDialog();
            if(fbl.ShowDialog() == DialogResult.OK)
            {
                txtLocal.Text = fbl.SelectedPath;
            }
        }

        private void FrmBackup_Load(object sender, EventArgs e)
        {
            try
            {
                con = new ConexaoDAL();
                con.Conectar();
                SqlCommand command = new SqlCommand("SELECT * FROM sys.databases d WHERE d.database_id>4",con.Conexao);
                reader = command.ExecuteReader();
                cBDataBase.Items.Clear();
                while (reader.Read())
                {
                    cBDataBase.Items.Add(reader[0].ToString());
                }

                con.Conexao.Close();

                btnBackup.Enabled = true;
                cBDataBase.Enabled = true;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
