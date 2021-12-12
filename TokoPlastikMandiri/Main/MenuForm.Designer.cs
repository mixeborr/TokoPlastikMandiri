namespace TokoPlastikMandiri.Main
{
    partial class MenuForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnKategori = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnBarang = new System.Windows.Forms.Button();
            this.gbTransaksi = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.gbTransaksi.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 59);
            this.button1.TabIndex = 0;
            this.button1.Text = "Master";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKategori
            // 
            this.btnKategori.Location = new System.Drawing.Point(72, 29);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(121, 31);
            this.btnKategori.TabIndex = 1;
            this.btnKategori.Text = "Master Kategori";
            this.btnKategori.UseVisualStyleBackColor = true;
            this.btnKategori.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(158, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 59);
            this.button3.TabIndex = 2;
            this.button3.Text = "Transaksi";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnCustomer);
            this.groupBox1.Controls.Add(this.btnSupplier);
            this.groupBox1.Controls.Add(this.btnBarang);
            this.groupBox1.Controls.Add(this.btnKategori);
            this.groupBox1.Location = new System.Drawing.Point(24, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(434, 114);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Master";
            this.groupBox1.Visible = false;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(72, 66);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(121, 31);
            this.btnCustomer.TabIndex = 5;
            this.btnCustomer.Text = "Master Customer";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.Location = new System.Drawing.Point(251, 66);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(121, 31);
            this.btnSupplier.TabIndex = 4;
            this.btnSupplier.Text = "Master Supplier";
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnBarang
            // 
            this.btnBarang.Location = new System.Drawing.Point(251, 29);
            this.btnBarang.Name = "btnBarang";
            this.btnBarang.Size = new System.Drawing.Size(121, 31);
            this.btnBarang.TabIndex = 4;
            this.btnBarang.Text = "Master Barang";
            this.btnBarang.UseVisualStyleBackColor = true;
            this.btnBarang.Click += new System.EventHandler(this.btnBarang_Click);
            // 
            // gbTransaksi
            // 
            this.gbTransaksi.BackColor = System.Drawing.Color.Transparent;
            this.gbTransaksi.Controls.Add(this.button9);
            this.gbTransaksi.Controls.Add(this.button10);
            this.gbTransaksi.Location = new System.Drawing.Point(24, 36);
            this.gbTransaksi.Name = "gbTransaksi";
            this.gbTransaksi.Size = new System.Drawing.Size(434, 114);
            this.gbTransaksi.TabIndex = 4;
            this.gbTransaksi.TabStop = false;
            this.gbTransaksi.Text = "Transaksi";
            this.gbTransaksi.Visible = false;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(249, 44);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(121, 41);
            this.button9.TabIndex = 4;
            this.button9.Text = "Pembelian";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(70, 44);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(121, 41);
            this.button10.TabIndex = 1;
            this.button10.Text = "Penjualan";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TokoPlastikMandiri.Properties.Resources._360_F_355607062_zYMS8jaz4SfoykpWz5oViRVKL32IabTP;
            this.ClientSize = new System.Drawing.Size(487, 450);
            this.Controls.Add(this.gbTransaksi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Name = "MenuForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuForm";
            this.groupBox1.ResumeLayout(false);
            this.gbTransaksi.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button button3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnBarang;
        private System.Windows.Forms.GroupBox gbTransaksi;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
    }
}