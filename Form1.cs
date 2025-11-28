using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace sayi_bilmece61
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //SQL
        SqlConnection baglanti = new SqlConnection("Data Source=.;Initial Catalog=SayiTahminDB;Integrated Security=True;TrustServerCertificate=True");

        int randomSayi;
        int hak;
        string hedefSayiString = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            OyunBittiModu();
            GecmisiListele();
        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            while (true)
            {
                randomSayi = rnd.Next(1000, 10000);
                hedefSayiString = randomSayi.ToString();

                if (hedefSayiString[0] != hedefSayiString[1] &&
                    hedefSayiString[0] != hedefSayiString[2] &&
                    hedefSayiString[0] != hedefSayiString[3] &&
                    hedefSayiString[1] != hedefSayiString[2] &&
                    hedefSayiString[1] != hedefSayiString[3] &&
                    hedefSayiString[2] != hedefSayiString[3])
                {
                    break;
                }
            }

            hak = 10;
            lblKalanHak.Text = hak.ToString();
            lblDurum.Text = "Tahmininizi Girin";
            lblDurum.ForeColor = Color.Black;
            lblSonucOzet.Text = "Sonuç: +0, -0";
            lblSonucDetay.Text = "Yeni oyun baþladý! Baþarýlar...";
            lstGecmis.Items.Clear();
            txtTahmin.Clear();

            txtTahmin.Enabled = true;
            btnTahmin.Enabled = true;

            btnBaslat.Enabled = false;
            btnYenidenOyna.Enabled = true; 

            txtTahmin.Focus();
        }

        private void btnTahmin_Click(object sender, EventArgs e)
        {
            lblDurum.Text = "";
            lblDurum.ForeColor = Color.Black;

            string tahmin = txtTahmin.Text;

            if (string.IsNullOrWhiteSpace(tahmin) || tahmin.Length != 4)
            {
                lblDurum.Text = "Lütfen 4 haneli sayý girin!";
                lblDurum.ForeColor = Color.Red;
                return;
            }

            if (tahmin[0] == tahmin[1] || tahmin[0] == tahmin[2] || tahmin[0] == tahmin[3] ||
                tahmin[1] == tahmin[2] || tahmin[1] == tahmin[3] || tahmin[2] == tahmin[3])
            {
                lblDurum.Text = "Rakamlar farklý olmalý!";
                lblDurum.ForeColor = Color.Red;
                txtTahmin.Clear();
                return;
            }

            string detayliRapor = "";
            int dogruYer = 0;

            for (int i = 0; i < 4; i++)
            {
                char girilenRakam = tahmin[i];
                char hedefRakam = hedefSayiString[i];

                if (girilenRakam == hedefRakam)
                {
                    dogruYer++;
                    detayliRapor += (i + 1) + ". Sayý: DOÐRU\n";
                }
                else if (hedefSayiString.Contains(girilenRakam))
                {
                    detayliRapor += (i + 1) + ". Sayý: Rakam doðru ama YERÝ YANLIÞ\n";
                }
                else
                {
                    detayliRapor += (i + 1) + ". Sayý: YANLIÞ\n";
                }
            }

            hak--;
            lblKalanHak.Text = hak.ToString();

            lblSonucOzet.Text = "Tahmin Analizi:";
            lblSonucDetay.Text = detayliRapor;
            lstGecmis.Items.Add(tahmin + " -> (Analiz yapýldý)");

            if (dogruYer == 4)
            {
                lblSonucDetay.Text = "TEBRÝKLER! TÜM SAYILAR DOÐRU!";
                MessageBox.Show("Tebrikler Kazandýnýz! Sayý: " + hedefSayiString);
                VeritabaniKayit(hedefSayiString, "Kazandý", hak);
                OyunBittiModu();
            }
            else if (hak == 0)
            {
                MessageBox.Show("Oyun Bitti. Doðru Sayý: " + hedefSayiString);
                VeritabaniKayit(hedefSayiString, "Kaybetti", 0);
                OyunBittiModu();
            }

            txtTahmin.Clear();
            txtTahmin.Focus();
        }

        private void txtTahmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void OyunBittiModu()
        {
            txtTahmin.Enabled = false;
            btnTahmin.Enabled = false;

            btnBaslat.Enabled = true;
            btnYenidenOyna.Enabled = true;
        }

        private void VeritabaniKayit(string hedef, string durum, int kalan)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO OyunGecmisi (HedefSayi, Durum, KalanHak, Tarih) VALUES (@p1, @p2, @p3, @p4)", baglanti);
                komut.Parameters.AddWithValue("@p1", hedef);
                komut.Parameters.AddWithValue("@p2", durum);
                komut.Parameters.AddWithValue("@p3", kalan);
                komut.Parameters.AddWithValue("@p4", DateTime.Now);
                komut.ExecuteNonQuery();
                baglanti.Close();
                GecmisiListele();
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Hata Detayý: " + ex.Message); // Bize hatayý ekrana yazsýn
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }

        private void GecmisiListele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM OyunGecmisi ORDER BY Tarih DESC", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            catch
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
            }
        }
    }
}