
namespace TokoPlastikMandiri.Transaksi
{
    partial class FormBayarPenjualan
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lbTimeStamp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTotalTransaksi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBayar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbKembalian = new System.Windows.Forms.Label();
            this.btnBayar = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toko Mandiri Plastik";
            // 
            // lbTimeStamp
            // 
            this.lbTimeStamp.AutoSize = true;
            this.lbTimeStamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeStamp.Location = new System.Drawing.Point(90, 43);
            this.lbTimeStamp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTimeStamp.Name = "lbTimeStamp";
            this.lbTimeStamp.Size = new System.Drawing.Size(93, 18);
            this.lbTimeStamp.TabIndex = 1;
            this.lbTimeStamp.Text = "lbTimestamp";
            this.lbTimeStamp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 84);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Transaksi :";
            // 
            // lbTotalTransaksi
            // 
            this.lbTotalTransaksi.AutoSize = true;
            this.lbTotalTransaksi.Location = new System.Drawing.Point(106, 84);
            this.lbTotalTransaksi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalTransaksi.Name = "lbTotalTransaksi";
            this.lbTotalTransaksi.Size = new System.Drawing.Size(85, 13);
            this.lbTotalTransaksi.TabIndex = 3;
            this.lbTotalTransaksi.Text = "lbTotalTransaksi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bayar :";
            // 
            // tbBayar
            // 
            this.tbBayar.Location = new System.Drawing.Point(109, 112);
            this.tbBayar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbBayar.Name = "tbBayar";
            this.tbBayar.Size = new System.Drawing.Size(147, 20);
            this.tbBayar.TabIndex = 5;
            this.tbBayar.TextChanged += new System.EventHandler(this.tbBayar_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kembalian :";
            // 
            // lbKembalian
            // 
            this.lbKembalian.AutoSize = true;
            this.lbKembalian.Location = new System.Drawing.Point(109, 149);
            this.lbKembalian.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbKembalian.Name = "lbKembalian";
            this.lbKembalian.Size = new System.Drawing.Size(64, 13);
            this.lbKembalian.TabIndex = 7;
            this.lbKembalian.Text = "lbKembalian";
            // 
            // btnBayar
            // 
            this.btnBayar.Location = new System.Drawing.Point(55, 185);
            this.btnBayar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(72, 22);
            this.btnBayar.TabIndex = 8;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.UseVisualStyleBackColor = true;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(131, 185);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(72, 22);
            this.btnBatal.TabIndex = 9;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormBayarPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 295);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.lbKembalian);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbBayar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTotalTransaksi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTimeStamp);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormBayarPenjualan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBayarPenjualan";
            this.Load += new System.EventHandler(this.FormBayarPenjualan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTimeStamp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBayar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbKembalian;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label lbTotalTransaksi;
    }
}