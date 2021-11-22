using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using Npgsql;


namespace TokoPlastikMandiri
{
    public partial class LoginMain : Form
    {
       

        public LoginMain()                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "maman";
            txtPassword.Text = "maman";
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Username atau Password Tidak Boleh Kosong");
            }
            else {
                try
                {
                    
                    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
                    conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "select username, password, role from loginuser where username = '"+ txtUsername.Text +"' and password = '"+txtPassword.Text+"'";
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    conn.Dispose();
                    if (dt.Rows.Count > 0)
                    {
                        Main.MenuForm menu = new Main.MenuForm();
                        menu.ShowDialog();
                        this.Hide();
                    }
                    else {
                        MessageBox.Show("pass");
                    }
                    
                    
                }
                catch (Exception) {
                    MessageBox.Show("COKK");
                }
                
            }
        }
    }
}
