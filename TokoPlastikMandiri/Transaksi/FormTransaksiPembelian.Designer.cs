
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
            this.cbNmSupplier = new System.Windows.Forms.ComboBox();
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbNoTransPembelian = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTotalPembelian = new System.Windows.Forms.TextBox();
            this.ColumnNamaItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSatuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHargaBeli = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbHarga = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxInputBarang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNamaItem,
            this.ColumnQty,
            this.ColumnSatuan,
            this.ColumnHargaBeli,
            this.ColumnSubtotal});
            this.dataGridView1.Location = new System.Drawing.Point(7, 179);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(773, 196);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // groupBoxInputBarang
            // 
            this.groupBoxInputBarang.Controls.Add(this.tbHarga);
            this.groupBoxInputBarang.Controls.Add(this.label9);
            this.groupBoxInputBarang.Controls.Add(this.cbNmSupplier);
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
            this.groupBoxInputBarang.Controls.Add(this.label2);
            this.groupBoxInputBarang.Controls.Add(this.tbNoTransPembelian);
            this.groupBoxInputBarang.Controls.Add(this.label1);
            this.groupBoxInputBarang.Location = new System.Drawing.Point(6, 8);
            this.groupBoxInputBarang.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxInputBarang.Name = "groupBoxInputBarang";
            this.groupBoxInputBarang.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxInputBarang.Size = new System.Drawing.Size(774, 167);
            this.groupBoxInputBarang.TabIndex = 5;
            this.groupBoxInputBarang.TabStop = false;
            this.groupBoxInputBarang.Text = "Data Pembelian";
            // 
            // cbNmSupplier
            // 
            this.cbNmSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNmSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbNmSupplier.FormattingEnabled = true;
            this.cbNmSupplier.Location = new System.Drawing.Point(320, 54);
            this.cbNmSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.cbNmSupplier.Name = "cbNmSupplier";
            this.cbNmSupplier.Size = new System.Drawing.Size(155, 21);
            this.cbNmSupplier.TabIndex = 16;
            this.cbNmSupplier.TextChanged += new System.EventHandler(this.cbNmSupplier_TextChanged);
            // 
            // cbSatuanPembelian
            // 
            this.cbSatuanPembelian.FormattingEnabled = true;
            this.cbSatuanPembelian.Location = new System.Drawing.Point(78, 101);
            this.cbSatuanPembelian.Margin = new System.Windows.Forms.Padding(2);
            this.cbSatuanPembelian.Name = "cbSatuanPembelian";
            this.cbSatuanPembelian.Size = new System.Drawing.Size(126, 21);
            this.cbSatuanPembelian.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Satuan";
            // 
            // tbKodeItemPembelian
            // 
            this.tbKodeItemPembelian.Location = new System.Drawing.Point(78, 24);
            this.tbKodeItemPembelian.Margin = new System.Windows.Forms.Padding(2);
            this.tbKodeItemPembelian.Name = "tbKodeItemPembelian";
            this.tbKodeItemPembelian.Size = new System.Drawing.Size(126, 20);
            this.tbKodeItemPembelian.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 26);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kode Item ";
            // 
            // tbQtyPembelian
            // 
            this.tbQtyPembelian.Location = new System.Drawing.Point(78, 76);
            this.tbQtyPembelian.Margin = new System.Windows.Forms.Padding(2);
            this.tbQtyPembelian.Name = "tbQtyPembelian";
            this.tbQtyPembelian.Size = new System.Drawing.Size(126, 20);
            this.tbQtyPembelian.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Qty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nama Item";
            // 
            // cbNamaItemPembelian
            // 
            this.cbNamaItemPembelian.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbNamaItemPembelian.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbNamaItemPembelian.FormattingEnabled = true;
            this.cbNamaItemPembelian.Location = new System.Drawing.Point(77, 49);
            this.cbNamaItemPembelian.Margin = new System.Windows.Forms.Padding(2);
            this.cbNamaItemPembelian.Name = "cbNamaItemPembelian";
            this.cbNamaItemPembelian.Size = new System.Drawing.Size(126, 21);
            this.cbNamaItemPembelian.TabIndex = 8;
            this.cbNamaItemPembelian.TextChanged += new System.EventHandler(this.cbNamaItemPembelian_TextChanged);
            // 
            // tbAlamatPembelian
            // 
            this.tbAlamatPembelian.Location = new System.Drawing.Point(320, 83);
            this.tbAlamatPembelian.Margin = new System.Windows.Forms.Padding(2);
            this.tbAlamatPembelian.Name = "tbAlamatPembelian";
            this.tbAlamatPembelian.Size = new System.Drawing.Size(155, 20);
            this.tbAlamatPembelian.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 88);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Alamat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Supplier";
            // 
            // tbNoTransPembelian
            // 
            this.tbNoTransPembelian.BackColor = System.Drawing.SystemColors.Control;
            this.tbNoTransPembelian.Enabled = false;
            this.tbNoTransPembelian.Location = new System.Drawing.Point(320, 22);
            this.tbNoTransPembelian.Margin = new System.Windows.Forms.Padding(2);
            this.tbNoTransPembelian.Name = "tbNoTransPembelian";
            this.tbNoTransPembelian.Size = new System.Drawing.Size(155, 20);
            this.tbNoTransPembelian.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Transaksi";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(550, 418);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 22);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(628, 418);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(74, 22);
            this.btnEdit.TabIndex = 8;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(706, 418);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 22);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(609, 386);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Total";
            // 
            // tbTotalPembelian
            // 
            this.tbTotalPembelian.Location = new System.Drawing.Point(642, 382);
            this.tbTotalPembelian.Margin = new System.Windows.Forms.Padding(2);
            this.tbTotalPembelian.Name = "tbTotalPembelian";
            this.tbTotalPembelian.Size = new System.Drawing.Size(140, 20);
            this.tbTotalPembelian.TabIndex = 11;
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
            this.ColumnHargaBeli.HeaderText = "Harga Satuan";
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
            // tbHarga
            // 
            this.tbHarga.Location = new System.Drawing.Point(77, 126);
            this.tbHarga.Margin = new System.Windows.Forms.Padding(2);
            this.tbHarga.Name = "tbHarga";
            this.tbHarga.Size = new System.Drawing.Size(126, 20);
            this.tbHarga.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 128);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Harga Satuan";
            // 
            // FormTransaksiPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.tbTotalPembelian);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxInputBarang);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.ComboBox cbNmSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNamaItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSatuan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnHargaBeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSubtotal;
        private System.Windows.Forms.TextBox tbHarga;
        private System.Windows.Forms.Label label9;
    }
}