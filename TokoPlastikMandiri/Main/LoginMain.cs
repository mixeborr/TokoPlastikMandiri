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

        string role = "";
        public LoginMain()                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtUsername.Text = "admin";
            txtPassword.Text = "admin";
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
                    cmd.CommandText = "select role from loginuser where username = '"+ txtUsername.Text +"' and password = '"+txtPassword.Text+"'";
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    conn.Dispose();
                    conn.Close();
                    if (dt.Rows.Count > 0)
                    {
                        getRole();
                        if (role == "1")
                        {
                            Transaksi.FormTransaksiPenjualan penjualan = new Transaksi.FormTransaksiPenjualan();
                            penjualan.ShowDialog();
                            this.Hide();
                        }
                        else if(role == "0") {
                            Main.MenuForm menu = new Main.MenuForm();
                            menu.ShowDialog();
                            this.Hide();
                        }
                       
                    }
                    else {
                        MessageBox.Show("Password Salah");
                    }
                    
                    
                }
                catch (Exception) {
                    MessageBox.Show("Koneksi Gagal");
                }
                
            }
        }

        private void getRole() {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select role from loginuser where username = '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'";
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                role = dr["role"].ToString();
            }

            conn.Close();
        }
    }
}
