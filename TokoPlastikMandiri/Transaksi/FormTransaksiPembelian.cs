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
        int totalSemua = 0;
        int tempHarga = 0;
        public FormTransaksiPembelian()
        {
            InitializeComponent();
        }

        private void FormTransaksiPembelian_Load(object sender, EventArgs e)
        {
            tbNoTransPembelian.Text = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString()+DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            autoCompleteSupplier();
            autoCompleteBarang();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            int rowIndex = dataGridView1.CurrentCell.RowIndex;
            totalSemua -= Int32.Parse(dataGridView1.Rows[idx].Cells[4].Value.ToString());
            dataGridView1.Rows.RemoveAt(rowIndex);
            tbTotalPembelian.Text = totalSemua.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            int qty = Convert.ToInt32(tbQtyPembelian.Text);
            int subtotal = qty * tempHarga;
            totalSemua += subtotal;
            tbTotalPembelian.Text = totalSemua.ToString("#,##0");
            string[] data = new string[] {
                cbNamaItemPembelian.Text,
                tbQtyPembelian.Text,
                cbSatuanPembelian.Text,
                tempHarga.ToString(),
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
            cmd.CommandText = "select satuan,hbeli from barang where nama = '" + cbNamaItemPembelian.Text + "'";
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cbSatuanPembelian.Text = dr["satuan"].ToString();
                tempHarga = Int32.Parse(dr["hbeli"].ToString());
                tbHarga.Text = tempHarga.ToString("#,##0");
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

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dataGridView1.RowCount.ToString());
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into pembelian (notrans,suppliernm, supplieralmt, flagkonfirm) values (@notrans, @nama, @alamat, @flag)";
            cmd.Parameters.AddWithValue("@notrans", tbNoTransPembelian.Text);
            cmd.Parameters.AddWithValue("@nama", cbNmSupplier.Text);
            cmd.Parameters.AddWithValue("@alamat", tbAlamatPembelian.Text);
            cmd.Parameters.AddWithValue("@flag", "N");
            //cmd.Parameters.AddWithValue("@cp", txtCP.Text);
            //cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Dispose();
            conn.Close();
            //refreshTable();
            //kosonginTextBox();
            insertDetail();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            idx = e.RowIndex;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idx = e.RowIndex;
        }

        private void insertDetail() {
            for (int rows = 0; rows < dataGridView1.Rows.Count-1; rows++)
            {
                List<string> termsList = new List<string>();
                for (int col = 0; col < dataGridView1.Rows[rows].Cells.Count; col++)
                {
                    termsList.Add(dataGridView1.Rows[rows].Cells[col].Value.ToString());
                }

                NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
                conn.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into pembeliandetail (notrans,namabrng, qty,harga,satuan) values (@notrans, @nama, @qty,@harga,@satuan)";
                cmd.Parameters.AddWithValue("@notrans", tbNoTransPembelian.Text);
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
            MessageBox.Show("sukses menyimpan");
            kosonginGrid();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            //insertDetail();
        }

        private void kosonginGrid()
        {
            tbNoTransPembelian.Text = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            tbAlamatPembelian.Text = "";
            tbHarga.Text = "";
            tbQtyPembelian.Text = "";
            tbTotalPembelian.Text = "";
            cbNmSupplier.Text = "";
            cbNamaItemPembelian.Text = "";
            cbSatuanPembelian.Text = "";
            dataGridView1.Rows.Clear();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Main.MenuForm().Show();
        }
    }
}
