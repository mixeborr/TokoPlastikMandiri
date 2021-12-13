
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbTimeStamp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTotalTransaksi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbBayar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBayar = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Toko Mandiri Plastik";
            // 
            // lbTimeStamp
            // 
            this.lbTimeStamp.AutoSize = true;
            this.lbTimeStamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeStamp.Location = new System.Drawing.Point(135, 66);
            this.lbTimeStamp.Name = "lbTimeStamp";
            this.lbTimeStamp.Size = new System.Drawing.Size(137, 26);
            this.lbTimeStamp.TabIndex = 1;
            this.lbTimeStamp.Text = "lbTimestamp";
            this.lbTimeStamp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Transaksi :";
            // 
            // lbTotalTransaksi
            // 
            this.lbTotalTransaksi.AutoSize = true;
            this.lbTotalTransaksi.Location = new System.Drawing.Point(159, 129);
            this.lbTotalTransaksi.Name = "lbTotalTransaksi";
            this.lbTotalTransaksi.Size = new System.Drawing.Size(124, 20);
            this.lbTotalTransaksi.TabIndex = 3;
            this.lbTotalTransaksi.Text = "lbTotalTransaksi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bayar :";
            // 
            // tbBayar
            // 
            this.tbBayar.Location = new System.Drawing.Point(163, 173);
            this.tbBayar.Name = "tbBayar";
            this.tbBayar.Size = new System.Drawing.Size(219, 26);
            this.tbBayar.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Kembalian :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "lbKembalian";
            // 
            // btnBayar
            // 
            this.btnBayar.Location = new System.Drawing.Point(82, 284);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(108, 34);
            this.btnBayar.TabIndex = 8;
            this.btnBayar.Text = "Bayar";
            this.btnBayar.UseVisualStyleBackColor = true;
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(196, 284);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(108, 34);
            this.btnBatal.TabIndex = 9;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            // 
            // FormBayarPenjualan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 454);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbBayar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbTotalTransaksi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTimeStamp);
            this.Controls.Add(this.label1);
            this.Name = "FormBayarPenjualan";
            this.Text = "FormBayarPenjualan";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbTimeStamp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotalTransaksi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbBayar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.Button btnBatal;
    }
}