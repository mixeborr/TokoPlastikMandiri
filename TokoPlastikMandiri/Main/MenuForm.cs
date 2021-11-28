using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokoPlastikMandiri.Main
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Show();
            gbTransaksi.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            gbTransaksi.Show();
            groupBox1.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Master.MasterKategori masterKategori = new Master.MasterKategori();
            masterKategori.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Master.MasterCustomer masterCustomer = new Master.MasterCustomer();
            masterCustomer.Show();
            this.Hide();
        }

        private void btnBarang_Click(object sender, EventArgs e)
        {
            Master.MasterBarang masterBarang = new Master.MasterBarang();
            masterBarang.Show();
            this.Hide();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            Master.MasterSupplier masterSupplier = new Master.MasterSupplier();
            masterSupplier.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
