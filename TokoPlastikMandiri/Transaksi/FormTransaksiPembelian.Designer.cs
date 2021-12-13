
namespace TokoPlastikMandiri.Transaksi
{
    partial class FormTransaksiPembelian
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBoxInputBarang = new System.Windows.Forms.GroupBox();
            this.cbSatuanPembelian = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbKodeItemPembelian = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbQtyPembelian = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNamaItemPembelian = new System.Windows.Forms.ComboBox();
            this.tbAlamatPembelian = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNamaSupplierPembelian = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNoTransPembelian = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTotalPembelian = new System.Windows.Forms.TextBox();
            this.ColumnKodeItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNamaItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSatuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHargaBeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxInputBarang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnKodeItem,
            this.ColumnNamaItem,
            this.ColumnQty,
            this.ColumnSatuan,
            this.ColumnHargaBeli,
            this.ColumnSubtotal});
            this.dataGridView1.Location = new System.Drawing.Point(9, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1159, 301);
            this.dataGridView1.TabIndex = 6;
            // 
            // groupBoxInputBarang
            // 
            this.groupBoxInputBarang.Controls.Add(this.cbSatuanPembelian);
            this.groupBoxInputBarang.Controls.Add(this.label7);
            this.groupBoxInputBarang.Controls.Add(this.tbKodeItemPembelian);
            this.groupBoxInputBarang.Controls.Add(this.label6);
            this.groupBoxInputBarang.Controls.Add(this.tbQtyPembelian);
            this.groupBoxInputBarang.Controls.Add(this.label5);
            this.groupBoxInputBarang.Controls.Add(this.label3);
            this.groupBoxInputBarang.Controls.Add(this.cbNamaItemPembelian);
            this.groupBoxInputBarang.Controls.Add(this.tbAlamatPembelian);
            this.groupBoxInputBarang.Controls.Add(this.label4);
            this.groupBoxInputBarang.Controls.Add(this.tbNamaSupplierPembelian);
            this.groupBoxInputBarang.Controls.Add(this.label2);
            this.groupBoxInputBarang.Controls.Add(this.tbNoTransPembelian);
            this.groupBoxInputBarang.Controls.Add(this.label1);
            this.groupBoxInputBarang.Location = new System.Drawing.Point(9, 12);
            this.groupBoxInputBarang.Name = "groupBoxInputBarang";
            this.groupBoxInputBarang.Size = new System.Drawing.Size(1161, 194);
            this.groupBoxInputBarang.TabIndex = 5;
            this.groupBoxInputBarang.TabStop = false;
            this.groupBoxInputBarang.Text = "Data Pembelian";
            // 
            // cbSatuanPembelian
            // 
            this.cbSatuanPembelian.FormattingEnabled = true;
            this.cbSatuanPembelian.Location = new System.Drawing.Point(117, 156);
            this.cbSatuanPembelian.Name = "cbSatuanPembelian";
            this.cbSatuanPembelian.Size = new System.Drawing.Size(187, 28);
            this.cbSatuanPembelian.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Satuan";
            // 
            // tbKodeItemPembelian
            // 
            this.tbKodeItemPembelian.Location = new System.Drawing.Point(117, 37);
            this.tbKodeItemPembelian.Name = "tbKodeItemPembelian";
            this.tbKodeItemPembelian.Size = new System.Drawing.Size(187, 26);
            this.tbKodeItemPembelian.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kode Item ";
            // 
            // tbQtyPembelian
            // 
            this.tbQtyPembelian.Location = new System.Drawing.Point(117, 117);
            this.tbQtyPembelian.Name = "tbQtyPembelian";
            this.tbQtyPembelian.Size = new System.Drawing.Size(187, 26);
            this.tbQtyPembelian.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Qty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nama Item";
            // 
            // cbNamaItemPembelian
            // 
            this.cbNamaItemPembelian.FormattingEnabled = true;
            this.cbNamaItemPembelian.Location = new System.Drawing.Point(116, 76);
            this.cbNamaItemPembelian.Name = "cbNamaItemPembelian";
            this.cbNamaItemPembelian.Size = new System.Drawing.Size(187, 28);
            this.cbNamaItemPembelian.TabIndex = 8;
            // 
            // tbAlamatPembelian
            // 
            this.tbAlamatPembelian.Location = new System.Drawing.Point(480, 127);
            this.tbAlamatPembelian.Name = "tbAlamatPembelian";
            this.tbAlamatPembelian.Size = new System.Drawing.Size(230, 26);
            this.tbAlamatPembelian.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Alamat";
            // 
            // tbNamaSupplierPembelian
            // 
            this.tbNamaSupplierPembelian.Location = new System.Drawing.Point(481, 83);
            this.tbNamaSupplierPembelian.Name = "tbNamaSupplierPembelian";
            this.tbNamaSupplierPembelian.Size = new System.Drawing.Size(230, 26);
            this.tbNamaSupplierPembelian.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(351, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Supplier";
            // 
            // tbNoTransPembelian
            // 
            this.tbNoTransPembelian.BackColor = System.Drawing.SystemColors.Control;
            this.tbNoTransPembelian.Enabled = false;
            this.tbNoTransPembelian.Location = new System.Drawing.Point(480, 34);
            this.tbNoTransPembelian.Name = "tbNoTransPembelian";
            this.tbNoTransPembelian.Size = new System.Drawing.Size(230, 26);
            this.tbNoTransPembelian.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Transaksi";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(823, 589);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 34);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(940, 589);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(111, 34);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1057, 589);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 34);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(912, 540);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Total";
            // 
            // tbTotalPembelian
            // 
            this.tbTotalPembelian.Location = new System.Drawing.Point(962, 534);
            this.tbTotalPembelian.Name = "tbTotalPembelian";
            this.tbTotalPembelian.Size = new System.Drawing.Size(208, 26);
            this.tbTotalPembelian.TabIndex = 11;
            // 
            // ColumnKodeItem
            // 
            this.ColumnKodeItem.DataPropertyName = "KodeItemPembelian";
            this.ColumnKodeItem.HeaderText = "Kode Item";
            this.ColumnKodeItem.MinimumWidth = 8;
            this.ColumnKodeItem.Name = "ColumnKodeItem";
            this.ColumnKodeItem.ReadOnly = true;
            this.ColumnKodeItem.Width = 150;
            // 
            // ColumnNamaItem
            // 
            this.ColumnNamaItem.DataPropertyName = "NamaItemPembelian";
            this.ColumnNamaItem.HeaderText = "Nama";
            this.ColumnNamaItem.MinimumWidth = 8;
            this.ColumnNamaItem.Name = "ColumnNamaItem";
            this.ColumnNamaItem.ReadOnly = true;
            this.ColumnNamaItem.Width = 150;
            // 
            // ColumnQty
            // 
            this.ColumnQty.DataPropertyName = "QtyPembelian";
            this.ColumnQty.HeaderText = "Qty";
            this.ColumnQty.MinimumWidth = 8;
            this.ColumnQty.Name = "ColumnQty";
            this.ColumnQty.ReadOnly = true;
            this.ColumnQty.Width = 150;
            // 
            // ColumnSatuan
            // 
            this.ColumnSatuan.DataPropertyName = "SatuanPembelian";
            this.ColumnSatuan.HeaderText = "Satuan";
            this.ColumnSatuan.MinimumWidth = 8;
            this.ColumnSatuan.Name = "ColumnSatuan";
            this.ColumnSatuan.ReadOnly = true;
            this.ColumnSatuan.Width = 150;
            // 
            // ColumnHargaBeli
            // 
            this.ColumnHargaBeli.DataPropertyName = "HargaBeliPembelian";
            this.ColumnHargaBeli.HeaderText = "Harga Beli";
            this.ColumnHargaBeli.MinimumWidth = 8;
            this.ColumnHargaBeli.Name = "ColumnHargaBeli";
            this.ColumnHargaBeli.ReadOnly = true;
            this.ColumnHargaBeli.Width = 150;
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
            // FormTransaksiPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 635);
            this.Controls.Add(this.tbTotalPembelian);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxInputBarang);
            this.Controls.Add(this.btnAdd);
            this.Name = "FormTransaksiPembelian";
            this.Text = "Transaksi Pembelian";
            this.Load += new System.EventHandler(this.FormTransaksiPembelian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxInputBarang.ResumeLayout(false);
            this.groupBoxInputBarang.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBoxInputBarang;
        private System.Windows.Forms.TextBox tbAlamatPembelian;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNamaSupplierPembelian;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNoTransPembelian;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbKodeItemPembelian;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbQtyPembelian;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNamaItemPembelian;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ComboBox cbSatuanPembelian;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTotalPembelian;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKodeItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNamaItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSatuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHargaBeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubtotal;
    }
}