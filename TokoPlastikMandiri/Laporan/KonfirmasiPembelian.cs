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
    public partial class KonfirmasiPembelian : Form
    {
        string notransaksi = "";
        int qtyBarang = 0;
        public KonfirmasiPembelian()
        {
            InitializeComponent();
        }

        public KonfirmasiPembelian(string notrans) : this()
        {
            notransaksi = notrans;
        }

        private void KonfirmasiPembelian_Load(object sender, EventArgs e)
        {
            getDataHeader();
            getDataTable();

        }

        private void getDataHeader() {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select notrans, suppliernm, supplieralmt, flagkonfirm from pembelian where notrans = '"+notransaksi+"'";
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tbNoTransPembelian.Text = dr["notrans"].ToString();
                tbSuppliernm.Text = dr["suppliernm"].ToString();
                tbAlamatPembelian.Text = dr["supplieralmt"].ToString();
                if (dr["flagkonfirm"].ToString() == "Y")
                {
                    button1.Enabled = false;
                }
                else {
                    button1.Enabled = true;
                }
            }
            conn.Close();
        }

        private void getDataTable() {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select namabrng, qty, satuan  from pembeliandetail where notrans = '" + notransaksi + "'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Dispose();
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void getQtyItem(string nmBarang) {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select qty  from barang where nama = '" + nmBarang + "'";
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                /*collection.Add();*/
                qtyBarang = Int32.Parse(dr["qty"].ToString());
            }
            conn.Dispose();
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount - 1; i++) {
                getQtyItem(dataGridView1.Rows[i].Cells[0].Value.ToString());
                int qty = Int32.Parse(dataGridView1.Rows[i].Cells[1].Value.ToString());
                qtyBarang += qty;
                updateBarang(dataGridView1.Rows[i].Cells[0].Value.ToString());
            }
            updateHeader();
            MessageBox.Show("Terkonfirmasi");

            Laporan.LaporanPembelian LaporanPembelian = new Laporan.LaporanPembelian();
            LaporanPembelian.Show();
            this.Hide();
        }

        private void updateBarang(string nmBarang) {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update barang set qty = '" + qtyBarang + "'  where nama = '" + nmBarang + "' ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Dispose();
            conn.Close();
        }

        private void updateHeader() {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update pembelian set flagkonfirm = 'Y'  where notrans = '" + notransaksi + "' ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Dispose();
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Laporan.LaporanPembelian  LaporanPembelian = new Laporan.LaporanPembelian();
            LaporanPembelian.Show();
            this.Hide();
        }
    }
}
