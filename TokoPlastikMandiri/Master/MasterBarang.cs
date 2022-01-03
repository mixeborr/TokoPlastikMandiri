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
    public partial class MasterBarang : Form
    {
        int idx = -1;
        public MasterBarang()
        {
            InitializeComponent();
        }

        private void btnTambahMasterBarang_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into barang(kode,nama, qty,hbeli,hjual, kategori, satuan) values (@kode, @nama,@qty,@hbeli,@hjual, @kategori, @satuan)";
            cmd.Parameters.AddWithValue("@kode", tbKodeBarang.Text);
            cmd.Parameters.AddWithValue("@nama", tbNamaBarang.Text);
            cmd.Parameters.AddWithValue("@qty", tbQty.Text);
            cmd.Parameters.AddWithValue("@hjual", tbHargaJualBarang.Text);
            cmd.Parameters.AddWithValue("@hbeli", tbHargaBeliBarang.Text);
            cmd.Parameters.AddWithValue("@kategori", (string)cbKategoriBarang.SelectedItem);
            cmd.Parameters.AddWithValue("@satuan", (string)cbSatuanBarang.SelectedItem);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Dispose();
            conn.Close();
            refreshTable();
            kosonginTextBox();
        }

        private void MasterBarang_Load(object sender, EventArgs e)
        {
            refreshTable();
            isiCbKategori();
        }

        private void isiCbKategori() {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select kategoricd, kategorinm from kategori";
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read()) {
                cbKategoriBarang.Items.Add(dr[1].ToString());
            }
            conn.Close();
        }

        private void refreshTable()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select kode, nama, qty, kategori, satuan, hbeli, hjual  from barang order by kategori asc";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Dispose();
            String UUID = Guid.NewGuid().ToString();
            tbKodeBarang.Text = UUID;
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void kosonginTextBox()
        {
            tbNamaBarang.Text = "";
            tbQty.Text = "";
            tbHargaJualBarang.Text = "";
            tbHargaBeliBarang.Text = "";
            cbKategoriBarang.Text = "";
            cbSatuanBarang.Text = "";
        }

        private void btnHapusMasterBarang_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from barang where kode = '" + tbKodeBarang.Text + "' ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Dispose();
            dataGridView1.DataSource = dt;
            conn.Close();
            refreshTable();
            kosonginTextBox();
        }

        private void isiTextBox()
        {
            if (idx >= 0)
            {
                tbKodeBarang.Text = dataGridView1.Rows[idx].Cells[0].Value.ToString();
                tbNamaBarang.Text = dataGridView1.Rows[idx].Cells[1].Value.ToString();
                tbQty.Text = dataGridView1.Rows[idx].Cells[2].Value.ToString();
                cbKategoriBarang.Text = dataGridView1.Rows[idx].Cells[3].Value.ToString();
                cbSatuanBarang.Text = dataGridView1.Rows[idx].Cells[4].Value.ToString();
                tbHargaBeliBarang.Text = dataGridView1.Rows[idx].Cells[5].Value.ToString();
                tbHargaJualBarang.Text = dataGridView1.Rows[idx].Cells[6].Value.ToString();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            idx = e.RowIndex;
            isiTextBox();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idx = e.RowIndex;
            isiTextBox();
        }

        private void btnUbahMasterBarang_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update barang set nama = '" + tbNamaBarang.Text + "', qty = '" + tbQty.Text + "', hjual = '" + tbHargaJualBarang.Text + "', hbeli = '" + tbHargaBeliBarang.Text + "', kategori = '" + (string)cbKategoriBarang.SelectedItem + "',  satuan = '" + (string)cbSatuanBarang.SelectedItem + "'  where kode = '" + tbKodeBarang.Text + "' ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Dispose();
            dataGridView1.DataSource = dt;
            conn.Close();
            refreshTable();
            kosonginTextBox();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Main.MenuForm().Show();
        }
    }
}
