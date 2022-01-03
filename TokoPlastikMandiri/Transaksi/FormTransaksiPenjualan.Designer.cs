
namespace TokoPlastikMandiri.Transaksi
{
    partial class FormTransaksiPenjualan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbNamaCustomer = new System.Windows.Forms.ComboBox();
            this.tbAlamatPenjualan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNoTransPenjualan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSatuanPenjualan = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbQtyPenjualan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNamaItemPenjualan = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColumnNamaItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSatuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHargaJual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbTotalPembelian = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBayar = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbHarga);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbNamaCustomer);
            this.groupBox1.Controls.Add(this.tbAlamatPenjualan);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbNoTransPenjualan);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbSatuanPenjualan);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbQtyPenjualan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbNamaItemPenjualan);
            this.groupBox1.Location = new System.Drawing.Point(9, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(770, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Penjualan";
            // 
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(83, 102);
            this.tbHarga.Margin = new System.Windows.Forms.Padding(2);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.ReadOnly = true;
            this.tbHarga.Size = new System.Drawing.Size(126, 20);
            this.tbHarga.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 104);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 31;
            this.label9.Text = "Harga Satuan";
            // 
            // cbNamaCustomer
            // 
            this.cbNamaCustomer.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNamaCustomer.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbNamaCustomer.FormattingEnabled = true;
            this.cbNamaCustomer.Location = new System.Drawing.Point(309, 54);
            this.cbNamaCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.cbNamaCustomer.Name = "cbNamaCustomer";
            this.cbNamaCustomer.Size = new System.Drawing.Size(155, 21);
            this.cbNamaCustomer.TabIndex = 30;
            this.cbNamaCustomer.TextChanged += new System.EventHandler(this.cbNamaCustomer_TextChanged);
            // 
            // tbAlamatPenjualan
            // 
            this.tbAlamatPenjualan.Location = new System.Drawing.Point(309, 83);
            this.tbAlamatPenjualan.Margin = new System.Windows.Forms.Padding(2);
            this.tbAlamatPenjualan.Name = "tbAlamatPenjualan";
            this.tbAlamatPenjualan.Size = new System.Drawing.Size(155, 20);
            this.tbAlamatPenjualan.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 89);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Alamat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(223, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 26;
            this.label2.Text = "Nama Customer";
            // 
            // tbNoTransPenjualan
            // 
            this.tbNoTransPenjualan.BackColor = System.Drawing.SystemColors.Control;
            this.tbNoTransPenjualan.Enabled = false;
            this.tbNoTransPenjualan.Location = new System.Drawing.Point(309, 23);
            this.tbNoTransPenjualan.Margin = new System.Windows.Forms.Padding(2);
            this.tbNoTransPenjualan.Name = "tbNoTransPenjualan";
            this.tbNoTransPenjualan.Size = new System.Drawing.Size(155, 20);
            this.tbNoTransPenjualan.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "No. Transaksi";
            // 
            // cbSatuanPenjualan
            // 
            this.cbSatuanPenjualan.FormattingEnabled = true;
            this.cbSatuanPenjualan.Location = new System.Drawing.Point(83, 77);
            this.cbSatuanPenjualan.Margin = new System.Windows.Forms.Padding(2);
            this.cbSatuanPenjualan.Name = "cbSatuanPenjualan";
            this.cbSatuanPenjualan.Size = new System.Drawing.Size(126, 21);
            this.cbSatuanPenjualan.TabIndex = 23;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 79);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Satuan";
            // 
            // tbQtyPenjualan
            // 
            this.tbQtyPenjualan.Location = new System.Drawing.Point(83, 52);
            this.tbQtyPenjualan.Margin = new System.Windows.Forms.Padding(2);
            this.tbQtyPenjualan.Name = "tbQtyPenjualan";
            this.tbQtyPenjualan.Size = new System.Drawing.Size(126, 20);
            this.tbQtyPenjualan.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Qty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Nama Item";
            // 
            // cbNamaItemPenjualan
            // 
            this.cbNamaItemPenjualan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNamaItemPenjualan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbNamaItemPenjualan.FormattingEnabled = true;
            this.cbNamaItemPenjualan.Location = new System.Drawing.Point(83, 25);
            this.cbNamaItemPenjualan.Margin = new System.Windows.Forms.Padding(2);
            this.cbNamaItemPenjualan.Name = "cbNamaItemPenjualan";
            this.cbNamaItemPenjualan.Size = new System.Drawing.Size(126, 21);
            this.cbNamaItemPenjualan.TabIndex = 16;
            this.cbNamaItemPenjualan.TextChanged += new System.EventHandler(this.cbNamaItemPenjualan_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNamaItem,
            this.ColumnQty,
            this.ColumnSatuan,
            this.ColumnHargaJual,
            this.ColumnSubtotal});
            this.dataGridView1.Location = new System.Drawing.Point(11, 177);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(770, 205);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ColumnNamaItem
            // 
            this.ColumnNamaItem.DataPropertyName = "NamaItemPenjualan";
            this.ColumnNamaItem.HeaderText = "Nama Item";
            this.ColumnNamaItem.MinimumWidth = 8;
            this.ColumnNamaItem.Name = "ColumnNamaItem";
            this.ColumnNamaItem.ReadOnly = true;
            this.ColumnNamaItem.Width = 150;
            // 
            // ColumnQty
            // 
            this.ColumnQty.DataPropertyName = "QtyPenjualan";
            this.ColumnQty.HeaderText = "Qty";
            this.ColumnQty.MinimumWidth = 8;
            this.ColumnQty.Name = "ColumnQty";
            this.ColumnQty.ReadOnly = true;
            this.ColumnQty.Width = 150;
            // 
            // ColumnSatuan
            // 
            this.ColumnSatuan.DataPropertyName = "SatuanPenjualan";
            this.ColumnSatuan.HeaderText = "Satuan";
            this.ColumnSatuan.MinimumWidth = 8;
            this.ColumnSatuan.Name = "ColumnSatuan";
            this.ColumnSatuan.ReadOnly = true;
            this.ColumnSatuan.Width = 150;
            // 
            // ColumnHargaJual
            // 
            this.ColumnHargaJual.DataPropertyName = "HargaJualPenjualan";
            this.ColumnHargaJual.HeaderText = "Harga";
            this.ColumnHargaJual.MinimumWidth = 8;
            this.ColumnHargaJual.Name = "ColumnHargaJual";
            this.ColumnHargaJual.ReadOnly = true;
            this.ColumnHargaJual.Width = 150;
            // 
            // ColumnSubtotal
            // 
            this.ColumnSubtotal.DataPropertyName = "SubtotalPenjualan";
            this.ColumnSubtotal.HeaderText = "Subtotal";
            this.ColumnSubtotal.MinimumWidth = 8;
            this.ColumnSubtotal.Name = "ColumnSubtotal";
            this.ColumnSubtotal.ReadOnly = true;
            this.ColumnSubtotal.Width = 150;
            // 
            // tbTotalPembelian
            // 
            this.tbTotalPembelian.Location = new System.Drawing.Point(642, 386);
            this.tbTotalPembelian.Margin = new System.Windows.Forms.Padding(2);
            this.tbTotalPembelian.Name = "tbTotalPembelian";
            this.tbTotalPembelian.ReadOnly = true;
            this.tbTotalPembelian.Size = new System.Drawing.Size(140, 20);
            this.tbTotalPembelian.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(609, 390);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Total";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(170, 151);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 22);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Hapus";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(92, 151);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(74, 22);
            this.btnEdit.TabIndex = 13;
            this.btnEdit.Text = "Ubah";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(14, 151);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 22);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Tambah";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnBayar
            // 
            this.btnBayar.Location = new System.Drawing.Point(11, 422);
            this.btnBayar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(74, 22);
            this.btnBayar.TabIndex = 17;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.UseVisualStyleBackColor = true;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(101, 422);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 19;
            this.btnBack.Text = "Kembali";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // FormTransaksiPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 454);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.tbTotalPembelian);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormTransaksiPenjualan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaksi Penjualan";
            this.Load += new System.EventHandler(this.FormTransaksiPenjualan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbSatuanPenjualan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbQtyPenjualan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNamaItemPenjualan;
        private System.Windows.Forms.TextBox tbAlamatPenjualan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNoTransPenjualan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbTotalPembelian;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNamaItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSatuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHargaJual;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubtotal;
        private System.Windows.Forms.ComboBox cbNamaCustomer;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBack;
    }
}