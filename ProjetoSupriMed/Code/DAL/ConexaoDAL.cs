using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSupriMed.Code.DAL
{
    public class ConexaoDAL
    {
        private String _strconexao = @"Data Source=.\SQLEXPRESS;Initial Catalog=SUPRIMEDICO;Persist Security Info=True;User ID=sa;Password=064871";
        private SqlConnection _conexao;

        public ConexaoDAL()
        {
            this._conexao = new SqlConnection();


            this._conexao.ConnectionString = _strconexao;
        }

        public SqlConnection Conexao
        {
            get
            {
                return this._conexao;
            }
            set
            {
                this._conexao = value;
            }
        }
        public void Conectar()
        {
            this._conexao.Open();
        }
        public void Desconectar()
        {
            this._conexao.Close();
        }
    }

    public class GerandoAutoIncremento
    {
       
        public static void AutoIncremento(string sql, Control textbox)
        {
            ConexaoDAL con = new ConexaoDAL();
            con.Conectar();
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = con.Conexao;
            SqlDataReader dr = cmd.ExecuteReader();
            

            if(dr.Read())
            {
                string value = dr[0].ToString();
                if(value == "")
                {
                    textbox.Text = "111";
                }else
                {
                    int x = Convert.ToInt16(dr[0].ToString());
                    textbox.Text = x.ToString();
                }
            }
        }
    }

    public class GerandoAutoIncrementoPecas
    {

        public static void AutoIncremento(string sql, Control textbox)
        {
            ConexaoDAL con = new ConexaoDAL();
            con.Conectar();
            SqlCommand cmd = new SqlCommand(sql);
            cmd.Connection = con.Conexao;
            SqlDataReader dr = cmd.ExecuteReader();


            if (dr.Read())
            {
                string value = dr[0].ToString();
                if (value == "")
                {
                    textbox.Text = "111";
                }
                else
                {
                    int x = Convert.ToInt16(dr[0].ToString());
                    x = x + 1;
                    textbox.Text = x.ToString();
                }
            }
        }
    }
}
