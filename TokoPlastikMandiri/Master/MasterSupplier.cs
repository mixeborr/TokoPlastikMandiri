using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TokoPlastikMandiri.Master
{
    public partial class MasterSupplier : Form
    {
        public MasterSupplier()
        {
            InitializeComponent();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            String UUID = Guid.NewGuid().ToString();
            MessageBox.Show(UUID);
        }
    }
}
