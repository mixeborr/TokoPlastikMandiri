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
    public partial class FormTransaksiPembelian : Form
    {
        int idx = -1;
        public FormTransaksiPembelian()
        {
            InitializeComponent();
        }

        private void FormTransaksiPembelian_Load(object sender, EventArgs e)
        {
            tbNoTransPembelian.Text = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
            autoCompleteSupplier();
            autoCompleteBarang();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(rowIndex);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int qty = Convert.ToInt32(tbQtyPembelian.Text);
            int harga = Convert.ToInt32(tbHarga.Text);
            int subtotal = qty * harga;
            MessageBox.Show(subtotal+"");
            string[] data = new string[] {
                cbNamaItemPembelian.Text,
                tbQtyPembelian.Text,
                cbSatuanPembelian.Text,
                tbHarga.Text,
                subtotal.ToString()
            };
            dataGridView1.Rows.Add(data);
        }

        public void autoCompleteSupplier() {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select nama from supplier";
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                collection.Add(dr["nama"].ToString());
            }
            cbNmSupplier.AutoCompleteCustomSource = collection;
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
            cbNamaItemPembelian.AutoCompleteCustomSource = collection;
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idx = e.RowIndex;
        }

        private void cbNamaItemPembelian_TextChanged(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select satuan,hjual from barang where nama = '" + cbNamaItemPembelian.Text + "'";
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbSatuanPembelian.Text = dr["satuan"].ToString();
                tbHarga.Text = dr["hjual"].ToString();
            }

            conn.Close();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idx = e.RowIndex;
        }

        private void cbNmSupplier_TextChanged(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select alamat from supplier where nama = '" + cbNmSupplier.Text + "'";
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tbAlamatPembelian.Text = dr["alamat"].ToString();
            }

            conn.Close();
        }
    }
}
