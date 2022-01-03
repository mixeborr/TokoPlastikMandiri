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
    public partial class DetailPenjualan : Form
    {
        String notransaksi = "";
        public DetailPenjualan()
        {
            InitializeComponent();
        }

        public DetailPenjualan(String notrans) :this()
        {
            notransaksi = notrans;
        }

        private void DetailPenjualan_Load(object sender, EventArgs e)
        {
            getDataHeader();
            getDataTable();
        }

        private void getDataHeader()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select notrans, customernm, customeralmt from penjualan where notrans = '" + notransaksi + "'";
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tbNoTransPembelian.Text = dr["notrans"].ToString();
                tbSuppliernm.Text = dr["customernm"].ToString();
                tbAlamatPembelian.Text = dr["customeralmt"].ToString();

            }
            conn.Close();
        }

        private void getDataTable()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select namabrng, qty, satuan  from penjualandetail where notrans = '" + notransaksi + "'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Dispose();
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Laporan.LaporanPenjualan penjualan = new Laporan.LaporanPenjualan();
            penjualan.Show();
            this.Hide();
        }
    }
}
