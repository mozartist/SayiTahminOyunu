namespace sayi_bilmece61
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblKalanHakEtiket = new System.Windows.Forms.Label();
            this.lblKalanHak = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblSonucOzet = new System.Windows.Forms.Label();
            this.lblSonucDetay = new System.Windows.Forms.Label();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.btnTahmin = new System.Windows.Forms.Button();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.btnYenidenOyna = new System.Windows.Forms.Button();
            this.lstGecmis = new System.Windows.Forms.ListBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKalanHakEtiket
            // 
            this.lblKalanHakEtiket.AutoSize = true;
            this.lblKalanHakEtiket.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKalanHakEtiket.Location = new System.Drawing.Point(40, 25);
            this.lblKalanHakEtiket.Name = "lblKalanHakEtiket";
            this.lblKalanHakEtiket.Size = new System.Drawing.Size(90, 23);
            this.lblKalanHakEtiket.TabIndex = 0;
            this.lblKalanHakEtiket.Text = "Kalan Hak:";
            // 
            // lblKalanHak
            // 
            this.lblKalanHak.AutoSize = true;
            this.lblKalanHak.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblKalanHak.Location = new System.Drawing.Point(136, 25);
            this.lblKalanHak.Name = "lblKalanHak";
            this.lblKalanHak.Size = new System.Drawing.Size(30, 23);
            this.lblKalanHak.TabIndex = 1;
            this.lblKalanHak.Text = "10";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(40, 60);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(125, 20);
            this.lblDurum.TabIndex = 2;
            this.lblDurum.Text = "Tahmininizi Girin:";
            // 
            // lblSonucOzet
            // 
            this.lblSonucOzet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSonucOzet.Location = new System.Drawing.Point(40, 85);
            this.lblSonucOzet.Name = "lblSonucOzet";
            this.lblSonucOzet.Size = new System.Drawing.Size(300, 30);
            this.lblSonucOzet.TabIndex = 3;
            this.lblSonucOzet.Text = "Sonuç: +0, -0";
            this.lblSonucOzet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSonucDetay
            // 
            this.lblSonucDetay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSonucDetay.Location = new System.Drawing.Point(40, 125);
            this.lblSonucDetay.Name = "lblSonucDetay";
            this.lblSonucDetay.Size = new System.Drawing.Size(300, 110);
            this.lblSonucDetay.TabIndex = 4;
            this.lblSonucDetay.Text = "Detaylar burada görünecek...";
            this.lblSonucDetay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtTahmin
            // 
            this.txtTahmin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTahmin.Location = new System.Drawing.Point(40, 250);
            this.txtTahmin.MaxLength = 4;
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(160, 34);
            this.txtTahmin.TabIndex = 5;
            this.txtTahmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTahmin_KeyPress);
            // 
            // btnTahmin
            // 
            this.btnTahmin.Location = new System.Drawing.Point(220, 248);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(120, 40);
            this.btnTahmin.TabIndex = 6;
            this.btnTahmin.Text = "Tahmin Et";
            this.btnTahmin.UseVisualStyleBackColor = true;
            this.btnTahmin.Click += new System.EventHandler(this.btnTahmin_Click);
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(40, 300); // Sola kaydırdım
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(140, 40);
            this.btnBaslat.TabIndex = 7;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // btnYenidenOyna
            // 
            this.btnYenidenOyna.BackColor = System.Drawing.Color.IndianRed;
            this.btnYenidenOyna.ForeColor = System.Drawing.Color.White;
            this.btnYenidenOyna.Location = new System.Drawing.Point(200, 300);
            this.btnYenidenOyna.Name = "btnYenidenOyna";
            this.btnYenidenOyna.Size = new System.Drawing.Size(140, 40);
            this.btnYenidenOyna.TabIndex = 10;
            this.btnYenidenOyna.Text = "Yeniden Oyna";
            this.btnYenidenOyna.UseVisualStyleBackColor = false;
            this.btnYenidenOyna.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // lstGecmis
            // 
            this.lstGecmis.FormattingEnabled = true;
            this.lstGecmis.ItemHeight = 20;
            this.lstGecmis.Location = new System.Drawing.Point(40, 360);
            this.lstGecmis.Name = "lstGecmis";
            this.lstGecmis.Size = new System.Drawing.Size(300, 144);
            this.lstGecmis.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(380, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(400, 480);
            this.dataGridView1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 530);
            this.Controls.Add(this.btnYenidenOyna); 
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lstGecmis);
            this.Controls.Add(this.btnBaslat);
            this.Controls.Add(this.btnTahmin);
            this.Controls.Add(this.txtTahmin);
            this.Controls.Add(this.lblSonucDetay);
            this.Controls.Add(this.lblSonucOzet);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblKalanHak);
            this.Controls.Add(this.lblKalanHakEtiket);
            this.Name = "Form1";
            this.Text = "Sayı Tahmin Etme";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKalanHakEtiket;
        private System.Windows.Forms.Label lblKalanHak;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblSonucOzet;
        private System.Windows.Forms.Label lblSonucDetay;
        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.Button btnTahmin;
        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.Button btnYenidenOyna;
        private System.Windows.Forms.ListBox lstGecmis;
        private System.Windows.Forms.DataGridView dataGridView1;
    }

}
