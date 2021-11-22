using Npgsql;
using System;
using System.Data;
using System.Windows.Forms;

namespace TokoPlastikMandiri.Master
{
    public partial class MasterCustomer : Form
    {
        public MasterCustomer()
        {
            InitializeComponent();
        }

        private void MasterCustomer_Load(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void refreshTable()
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select kode, nama, alamat, cp, email  from customer";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Dispose();
            String UUID = Guid.NewGuid().ToString();
            txtKode.Text = UUID;
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into customer(kode,nama, alamat,cp,email) values (@kode, @nama, @alamat, @cp, @email)";
            cmd.Parameters.AddWithValue("@kode", txtKode.Text);
            cmd.Parameters.AddWithValue("@nama", txtNama.Text);
            cmd.Parameters.AddWithValue("@alamat", txtAlamat.Text);
            cmd.Parameters.AddWithValue("@cp", txtCP.Text);
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Dispose();
            conn.Close();
            refreshTable();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from customer where nama = '" + txtNama.Text + "' ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            conn.Dispose();
            dataGridView1.DataSource = dt;
            conn.Close();
            refreshTable();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=user;Database=TokoPlastik;");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update customer set nama = '" + txtNama.Text + "', alamat = '" + txtAlamat.Text + "', cp = '" + txtCP.Text + "', email = '" + txtEmail.Text + "' where kode = '" + txtKode.Text + "' ";
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
