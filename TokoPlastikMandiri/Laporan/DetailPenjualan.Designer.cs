
namespace TokoPlastikMandiri.Laporan
{
    partial class DetailPenjualan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.namabrng = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxInputBarang = new System.Windows.Forms.GroupBox();
            this.tbSuppliernm = new System.Windows.Forms.TextBox();
            this.tbAlamatPembelian = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNoTransPembelian = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxInputBarang.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(17, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 23);
            this.button2.TabIndex = 20;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namabrng,
            this.qty,
            this.satuan});
            this.dataGridView1.Location = new System.Drawing.Point(14, 168);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(773, 215);
            this.dataGridView1.TabIndex = 19;
            // 
            // namabrng
            // 
            this.namabrng.DataPropertyName = "namabrng";
            this.namabrng.HeaderText = "Nama";
            this.namabrng.MinimumWidth = 8;
            this.namabrng.Name = "namabrng";
            this.namabrng.ReadOnly = true;
            this.namabrng.Width = 235;
            // 
            // qty
            // 
            this.qty.DataPropertyName = "qty";
            this.qty.HeaderText = "Qty";
            this.qty.MinimumWidth = 8;
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 235;
            // 
            // satuan
            // 
            this.satuan.DataPropertyName = "satuan";
            this.satuan.HeaderText = "Satuan";
            this.satuan.MinimumWidth = 8;
            this.satuan.Name = "satuan";
            this.satuan.ReadOnly = true;
            this.satuan.Width = 235;
            // 
            // groupBoxInputBarang
            // 
            this.groupBoxInputBarang.Controls.Add(this.tbSuppliernm);
            this.groupBoxInputBarang.Controls.Add(this.tbAlamatPembelian);
            this.groupBoxInputBarang.Controls.Add(this.label4);
            this.groupBoxInputBarang.Controls.Add(this.label2);
            this.groupBoxInputBarang.Controls.Add(this.tbNoTransPembelian);
            this.groupBoxInputBarang.Controls.Add(this.label1);
            this.groupBoxInputBarang.Location = new System.Drawing.Point(13, 20);
            this.groupBoxInputBarang.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxInputBarang.Name = "groupBoxInputBarang";
            this.groupBoxInputBarang.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxInputBarang.Size = new System.Drawing.Size(774, 132);
            this.groupBoxInputBarang.TabIndex = 18;
            this.groupBoxInputBarang.TabStop = false;
            this.groupBoxInputBarang.Text = "Data Penjualan";
            // 
            // tbSuppliernm
            // 
            this.tbSuppliernm.Location = new System.Drawing.Point(99, 61);
            this.tbSuppliernm.Margin = new System.Windows.Forms.Padding(2);
            this.tbSuppliernm.Name = "tbSuppliernm";
            this.tbSuppliernm.ReadOnly = true;
            this.tbSuppliernm.Size = new System.Drawing.Size(155, 20);
            this.tbSuppliernm.TabIndex = 8;
            // 
            // tbAlamatPembelian
            // 
            this.tbAlamatPembelian.Location = new System.Drawing.Point(99, 90);
            this.tbAlamatPembelian.Margin = new System.Windows.Forms.Padding(2);
            this.tbAlamatPembelian.Name = "tbAlamatPembelian";
            this.tbAlamatPembelian.ReadOnly = true;
            this.tbAlamatPembelian.Size = new System.Drawing.Size(155, 20);
            this.tbAlamatPembelian.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Alamat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Customer";
            // 
            // tbNoTransPembelian
            // 
            this.tbNoTransPembelian.BackColor = System.Drawing.SystemColors.Control;
            this.tbNoTransPembelian.Enabled = false;
            this.tbNoTransPembelian.Location = new System.Drawing.Point(99, 29);
            this.tbNoTransPembelian.Margin = new System.Windows.Forms.Padding(2);
            this.tbNoTransPembelian.Name = "tbNoTransPembelian";
            this.tbNoTransPembelian.Size = new System.Drawing.Size(155, 20);
            this.tbNoTransPembelian.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Transaksi";
            // 
            // DetailPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxInputBarang);
            this.Name = "DetailPenjualan";
            this.Text = "DetailPenjualan";
            this.Load += new System.EventHandler(this.DetailPenjualan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxInputBarang.ResumeLayout(false);
            this.groupBoxInputBarang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namabrng;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn satuan;
        private System.Windows.Forms.GroupBox groupBoxInputBarang;
        private System.Windows.Forms.TextBox tbSuppliernm;
        private System.Windows.Forms.TextBox tbAlamatPembelian;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNoTransPembelian;
        private System.Windows.Forms.Label label1;
    }
}