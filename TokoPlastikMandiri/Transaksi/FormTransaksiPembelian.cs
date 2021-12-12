using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokoPlastikMandiri.Transaksi
{
    public partial class FormTransaksiPembelian : Form
    {
        public FormTransaksiPembelian()
        {
            InitializeComponent();
        }

        private void FormTransaksiPembelian_Load(object sender, EventArgs e)
        {
            tbNoTrans.Text = DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();
        }
    }
}
