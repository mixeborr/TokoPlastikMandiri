
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
            this.tbHargaBeliBarang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNamaBarang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNoTrans = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NamaBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QtyBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SatuanBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HargaJualBarang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBoxInputBarang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NamaBarang,
            this.QtyBarang,
            this.SatuanBarang,
            this.HargaJualBarang});
            this.dataGridView1.Location = new System.Drawing.Point(6, 169);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(774, 224);
            this.dataGridView1.TabIndex = 6;
            // 
            // groupBoxInputBarang
            // 
            this.groupBoxInputBarang.Controls.Add(this.tbHargaBeliBarang);
            this.groupBoxInputBarang.Controls.Add(this.label4);
            this.groupBoxInputBarang.Controls.Add(this.tbNamaBarang);
            this.groupBoxInputBarang.Controls.Add(this.label2);
            this.groupBoxInputBarang.Controls.Add(this.tbNoTrans);
            this.groupBoxInputBarang.Controls.Add(this.label1);
            this.groupBoxInputBarang.Location = new System.Drawing.Point(6, 20);
            this.groupBoxInputBarang.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxInputBarang.Name = "groupBoxInputBarang";
            this.groupBoxInputBarang.Padding = new System.Windows.Forms.Padding(2);
            this.groupBoxInputBarang.Size = new System.Drawing.Size(774, 111);
            this.groupBoxInputBarang.TabIndex = 5;
            this.groupBoxInputBarang.TabStop = false;
            this.groupBoxInputBarang.Text = "Master Barang";
            // 
            // tbHargaBeliBarang
            // 
            this.tbHargaBeliBarang.Location = new System.Drawing.Point(90, 84);
            this.tbHargaBeliBarang.Margin = new System.Windows.Forms.Padding(2);
            this.tbHargaBeliBarang.Name = "tbHargaBeliBarang";
            this.tbHargaBeliBarang.Size = new System.Drawing.Size(155, 20);
            this.tbHargaBeliBarang.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 90);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Alamat";
            // 
            // tbNamaBarang
            // 
            this.tbNamaBarang.Location = new System.Drawing.Point(91, 55);
            this.tbNamaBarang.Margin = new System.Windows.Forms.Padding(2);
            this.tbNamaBarang.Name = "tbNamaBarang";
            this.tbNamaBarang.Size = new System.Drawing.Size(155, 20);
            this.tbNamaBarang.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama Customer";
            // 
            // tbNoTrans
            // 
            this.tbNoTrans.BackColor = System.Drawing.SystemColors.Control;
            this.tbNoTrans.Enabled = false;
            this.tbNoTrans.Location = new System.Drawing.Point(91, 25);
            this.tbNoTrans.Margin = new System.Windows.Forms.Padding(2);
            this.tbNoTrans.Name = "tbNoTrans";
            this.tbNoTrans.Size = new System.Drawing.Size(155, 20);
            this.tbNoTrans.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No. Transaksi";
            // 
            // NamaBarang
            // 
            this.NamaBarang.DataPropertyName = "nama";
            this.NamaBarang.HeaderText = "Nama";
            this.NamaBarang.MinimumWidth = 8;
            this.NamaBarang.Name = "NamaBarang";
            this.NamaBarang.ReadOnly = true;
            this.NamaBarang.Width = 150;
            // 
            // QtyBarang
            // 
            this.QtyBarang.DataPropertyName = "qty";
            this.QtyBarang.HeaderText = "Qty";
            this.QtyBarang.MinimumWidth = 8;
            this.QtyBarang.Name = "QtyBarang";
            this.QtyBarang.ReadOnly = true;
            this.QtyBarang.Width = 150;
            // 
            // SatuanBarang
            // 
            this.SatuanBarang.DataPropertyName = "satuan";
            this.SatuanBarang.HeaderText = "Satuan";
            this.SatuanBarang.MinimumWidth = 8;
            this.SatuanBarang.Name = "SatuanBarang";
            this.SatuanBarang.ReadOnly = true;
            this.SatuanBarang.Width = 150;
            // 
            // HargaJualBarang
            // 
            this.HargaJualBarang.DataPropertyName = "hjual";
            this.HargaJualBarang.HeaderText = "Harga Jual";
            this.HargaJualBarang.MinimumWidth = 8;
            this.HargaJualBarang.Name = "HargaJualBarang";
            this.HargaJualBarang.ReadOnly = true;
            this.HargaJualBarang.Width = 150;
            // 
            // FormTransaksiPembelian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 413);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBoxInputBarang);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormTransaksiPembelian";
            this.Text = "Transaksi Pembelian";
            this.Load += new System.EventHandler(this.FormTransaksiPembelian_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBoxInputBarang.ResumeLayout(false);
            this.groupBoxInputBarang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamaBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn QtyBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SatuanBarang;
        private System.Windows.Forms.DataGridViewTextBoxColumn HargaJualBarang;
        private System.Windows.Forms.GroupBox groupBoxInputBarang;
        private System.Windows.Forms.TextBox tbHargaBeliBarang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNamaBarang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNoTrans;
        private System.Windows.Forms.Label label1;
    }
}