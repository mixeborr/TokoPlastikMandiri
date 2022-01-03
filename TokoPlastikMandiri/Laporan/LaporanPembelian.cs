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

namespace TokoPlastikMandiri.Laporan
{
    public partial class LaporanPembelian : Form
    {
        public LaporanPembelian()
        {
            InitializeComponent();
        }

        private void LaporanPembelian_Load(object sender, EventArgs e)
        {
            allPembelian();
        }

        private void allPembelian() {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select notrans, suppliernm, supplieralmt  from pembelian";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Dispose();
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void pembelianBerdasarkanFilter()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select notrans, suppliernm, supplieralmt  from pembelian where notrans LIKE '%"+textBox1.Text+"%'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Dispose();
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Laporan.KonfirmasiPembelian konfirm = new Laporan.KonfirmasiPembelian(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            konfirm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main.MenuForm mainMenu = new Main.MenuForm();
            mainMenu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pembelianBerdasarkanFilter();
        }
    }
}
