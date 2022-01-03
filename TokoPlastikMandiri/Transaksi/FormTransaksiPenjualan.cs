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
    public partial class FormTransaksiPenjualan : Form
    {
        int idx = -1;
        int totalSemua = 0;
        public FormTransaksiPenjualan()
        {
            InitializeComponent();
        }

        private void FormTransaksiPenjualan_Load(object sender, EventArgs e)
        {
            tbNoTransPenjualan.Text = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            autoCompleteBarang();
            autoCompleteCustomer();
        }

        public void autoCompleteCustomer()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select nama from customer";
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                collection.Add(dr["nama"].ToString());
            }
            cbNamaCustomer.AutoCompleteCustomSource = collection;
            conn.Close();
        }
        public void autoCompleteBarang()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select nama from barang";
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                collection.Add(dr["nama"].ToString());
            }
            cbNamaItemPenjualan.AutoCompleteCustomSource = collection;
            conn.Close();
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            bayarSukses();
            Transaksi.FormBayarPenjualan bayar = new Transaksi.FormBayarPenjualan(tbNoTransPenjualan.Text);
            bayar.lbTotalTransaksi.Text = totalSemua.ToString() ;
            bayar.ShowDialog();
            /*kosonginGrid();*/
        }

        private void insertDetail()
        {
            for (int rows = 0; rows < dataGridView1.RowCount -1; rows++)
            {
                List<string> termsList = new List<string>();
                MessageBox.Show(dataGridView1.Rows[rows].Cells.Count + "");
                for (int col = 0; col < dataGridView1.Rows[rows].Cells.Count; col++)
                {
                    MessageBox.Show(dataGridView1.Rows[rows].Cells[col].Value.ToString());
                    termsList.Add(dataGridView1.Rows[rows].Cells[col].Value.ToString());
                }
                MessageBox.Show(termsList[0].ToString());
                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into penjualandetail (notrans,namabrng, qty,harga,satuan) values (@notrans, @nama, @qty,@harga,@satuan)";
                cmd.Parameters.AddWithValue("@notrans", tbNoTransPenjualan.Text);
                cmd.Parameters.AddWithValue("@nama", termsList[0].ToString());
                cmd.Parameters.AddWithValue("@qty", termsList[1].ToString());
                cmd.Parameters.AddWithValue("@harga", termsList[3].ToString());
                cmd.Parameters.AddWithValue("@satuan", termsList[2].ToString());
                //cmd.Parameters.AddWithValue("@cp", txtCP.Text);
                //cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                conn.Dispose();
                conn.Close();
            }
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            int qty = Convert.ToInt32(tbQtyPenjualan.Text);
            int harga = Convert.ToInt32(tbHarga.Text);
            int subtotal = qty * harga;
            totalSemua += subtotal;
            tbTotalPembelian.Text = totalSemua.ToString("#,##0");
            MessageBox.Show(subtotal + "");
            string[] data = new string[] {
                cbNamaItemPenjualan.Text,
                tbQtyPenjualan.Text,
                cbSatuanPenjualan.Text,
                tbHarga.Text,
                subtotal.ToString()
            };
            dataGridView1.Rows.Add(data);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            totalSemua -= Int32.Parse(dataGridView1.Rows[idx].Cells[4].Value.ToString());
            dataGridView1.Rows.RemoveAt(rowIndex);
            tbTotalPembelian.Text = totalSemua.ToString("#,##0");
        }

        private void cbNamaItemPenjualan_TextChanged(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select satuan,hjual from barang where nama = '" + cbNamaItemPenjualan.Text + "'";
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbSatuanPenjualan.Text = dr["satuan"].ToString();
                tbHarga.Text = dr["hjual"].ToString();
            }

            conn.Close();
        }

        private void cbNamaCustomer_TextChanged(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select alamat from customer where nama = '" + cbNamaCustomer.Text + "'";
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tbAlamatPenjualan.Text = dr["alamat"].ToString();
            }

            conn.Close();
        }

        private void kosonginGrid() {
            tbNoTransPenjualan.Text = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            tbAlamatPenjualan.Text = "";
            tbHarga.Text = "";
            tbQtyPenjualan.Text = "";
            tbTotalPembelian.Text = "0";
            cbNamaCustomer.Text = "";
            cbNamaItemPenjualan.Text = "";
            cbSatuanPenjualan.Text = "";
            dataGridView1.Rows.Clear();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idx = e.RowIndex;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idx = e.RowIndex;
        }

        public void bayarSukses() {
            MessageBox.Show(tbNoTransPenjualan.Text);
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into penjualan (notrans,customernm, customeralmt) values (@notrans, @nama, @alamat)";
            cmd.Parameters.AddWithValue("@notrans", tbNoTransPenjualan.Text);
            cmd.Parameters.AddWithValue("@nama", cbNamaCustomer.Text);
            cmd.Parameters.AddWithValue("@alamat", tbAlamatPenjualan.Text);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Dispose();
            conn.Close();
            insertDetail();
            kosonginGrid();
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Main.MenuForm().Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
        }
    }
}
