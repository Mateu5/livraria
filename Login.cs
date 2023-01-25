using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LivrariaTeste
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // conexao com banco de dados SQL server
        SqlConnection conn = new SqlConnection(@"Data source=DESKTOP-SBQFKB3\SQLSERVER;integrated security=SSPI;initial Catalog=db_livraria");

        SqlCommand cmd = new SqlCommand();
        SqlDataReader dt;

        private void Btn_acessar_Click(object sender, EventArgs e)
        {
            if(txt_login.Text == "" || txt_senha.Text == "")
            {
                MessageBox.Show("Obrigatório preencher os campos Login e Senha", "Atenção!!", MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
            else
            {
                try
                {
                    conn.Open();
                    cmd.CommandText = "select * from tbl_atendente where ds_Login = ('" + txt_login.Text + "') and ds_Senha = ('"+txt_senha.Text+"')" ;
                    cmd.Connection= conn;
                    dt = cmd.ExecuteReader();

                    if(dt.HasRows) 
                    {
                        Frm_Menu menu = new Frm_Menu();
                        menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("erro");
                        txt_login.Clear();
                        txt_senha.Clear();
                        txt_login.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally { conn.Close(); }
            }
        }
    }
}
