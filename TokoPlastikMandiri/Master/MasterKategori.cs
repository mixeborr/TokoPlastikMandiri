using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace TokoPlastikMandiri.Master
{
    public partial class MasterKategori : Form
    {
        int idx;
        public MasterKategori()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Main.MenuForm().Show();
        }

        private void MasterKategori_Load(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Boolean cekAda = validasi();

            if (cekAda == false)
            {
                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into kategori(kategoricd, kategorinm) values (@kategoricd, @kategorinm)";
                cmd.Parameters.AddWithValue("@kategoricd", txtKode.Text);
                cmd.Parameters.AddWithValue("@kategorinm", txtKategori.Text);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Dispose();
                conn.Close();
                refreshTable();
            }else { 
                MessageBox.Show("Kode Sudah Ada");
            }
            
        }


        private void refreshTable() {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select kategoricd, kategorinm from kategori";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Dispose();
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idx = e.RowIndex;

            txtKode.Text = dataGridView1.Rows[idx].Cells[0].Value.ToString();
            txtKategori.Text = dataGridView1.Rows[idx].Cells[1].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtKode.Text == "" || txtKategori.Text == "")
            {
                MessageBox.Show("Pilih yang ingin di delete dari table");
            }
            else {
                Boolean cekAda = validasi();

                if (cekAda == false)
                {
                    MessageBox.Show("Kategori dengan kode tersebut tidak ada");
                }
                else {
                    NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
                    conn.Open();
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = "delete from kategori where kategoricd = '" + txtKode.Text + "' ";
                    NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    conn.Dispose();
                    dataGridView1.DataSource = dt;
                    conn.Close();
                    refreshTable();
                }
                
            }
            
        }

        private Boolean validasi() {
            Boolean cekAda = false;

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from kategori  where kategoricd = '" + txtKode.Text + "' ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Dispose();
            conn.Close();
            if (dt.Rows.Count >0) {
                cekAda = true;
            }

            return cekAda;

        }
    }
}
