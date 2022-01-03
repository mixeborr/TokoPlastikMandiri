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

namespace TokoPlastikMandiri.Transaksi
{
    public partial class FormBayarPenjualan : Form
    {
        string notransaksi = "";
        public FormBayarPenjualan()
        {
            InitializeComponent();
        }

        public FormBayarPenjualan(String notrans) : this()
        {
            notransaksi = notrans;
        }

        private void FormBayarPenjualan_Load(object sender, EventArgs e)
        {
            timer1.Start();
            lbKembalian.Text = "0";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTimeStamp.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {;
            this.Hide();
        }

        private void tbBayar_TextChanged(object sender, EventArgs e)
        {
            if (tbBayar.TextLength > 0) {
                int total = Int32.Parse(lbTotalTransaksi.Text);
                int bayar = Int32.Parse(tbBayar.Text);
                int kembali = bayar - total;
                lbKembalian.Text =  kembali.ToString("#,##0");
            }
            
            
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            hapusHeaderTrans();
            this.Hide();
        }

        private void hapusHeaderTrans() {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from penjualan where notrans = '"+notransaksi+"'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Dispose();
            conn.Close();
            hapusDetailtrans();
        }

        private void hapusDetailtrans() {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from penjualandetail where notrans = '" + notransaksi + "'";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Dispose();
            conn.Close();
        }
    }
}
