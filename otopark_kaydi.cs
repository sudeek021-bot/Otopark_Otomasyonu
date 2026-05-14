using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class otopark_kaydi : Form
    {
        public string secilen_yer;

        // Bağlantı dizesini senin bilgisayarına göre güncelledim
        private SqlConnection baglanti = new SqlConnection(connectionString: "Data Source=DESKTOP-TI2COR6;Initial Catalog=oto;Integrated Security=True");

        public otopark_kaydi()
        {
            InitializeComponent();
        }

        // KAYIT BUTONU (btn1)
        private void btn18_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                string sorgu = "INSERT INTO arac_sahibi (tc_kimlik, ad, soyad, cep_telefonu, plaka_no, arac_marka, arac_renk, park_yeri) " +
                               "VALUES (@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8)";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", txtbox1.Text); // TC
                komut.Parameters.AddWithValue("@p2", txtbox2.Text); // Ad
                komut.Parameters.AddWithValue("@p3", txtbox3.Text); // Soyad
                komut.Parameters.AddWithValue("@p4", txtbox4.Text); // Telefon
                komut.Parameters.AddWithValue("@p5", txtbox5.Text); // Plaka
                komut.Parameters.AddWithValue("@p6", cmbbox1.Text); // Marka
                komut.Parameters.AddWithValue("@p7", cmbbox2.Text); // Renk
                komut.Parameters.AddWithValue("@p8", cmbbox3.Text); // Park Yeri

                komut.ExecuteNonQuery();

                // Park yerini DOLU yapıyoruz
                SqlCommand guncelle = new SqlCommand("UPDATE arac_durumu SET durumu='DOLU' WHERE park_yeri=@p_yer", baglanti);
                guncelle.Parameters.AddWithValue("@p_yer", cmbbox3.Text);
                guncelle.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Araç ve Sahibi Başarıyla Kaydedildi!", "Bilgi");
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Kayıt Hatası: " + ex.Message);
            }
        }

        private void otopark_kaydi_Load(object sender, EventArgs e)
        {
            VerileriGetir();
        }

        // Veritabanından Marka, Renk ve Boş Yerleri Çeker
        private void VerileriGetir()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                // Markaları çek (Scriptindeki 'marka_bilgileri' tablosu)
                cmbbox1.Items.Clear();
                SqlCommand k1 = new SqlCommand("SELECT marka FROM marka_bilgileri", baglanti);
                SqlDataReader oku1 = k1.ExecuteReader();
                while (oku1.Read()) { cmbbox1.Items.Add(oku1["marka"].ToString()); }
                oku1.Close();

                // Renkleri çek (Scriptindeki 'renk_bilgileri' tablosu)
                cmbbox2.Items.Clear();
                SqlCommand k2 = new SqlCommand("SELECT renk FROM renk_bilgileri", baglanti);
                SqlDataReader oku2 = k2.ExecuteReader();
                while (oku2.Read()) { cmbbox2.Items.Add(oku2["renk"].ToString()); }
                oku2.Close();

                // Boş Park Yerlerini çek (Scriptindeki 'arac_durumu' tablosu)
                cmbbox3.Items.Clear();
                SqlCommand k3 = new SqlCommand("SELECT park_yeri FROM arac_durumu WHERE durumu='BOŞ'", baglanti);
                SqlDataReader oku3 = k3.ExecuteReader();
                while (oku3.Read()) { cmbbox3.Items.Add(oku3["park_yeri"].ToString()); }
                oku3.Close();

                baglanti.Close();
            }
            catch (Exception ex) { if (baglanti.State == ConnectionState.Open) baglanti.Close(); MessageBox.Show("Veri çekme hatası: " + ex.Message); }
        }

        private void Temizle()
        {
            txtbox1.Clear(); txtbox2.Clear(); txtbox3.Clear(); txtbox4.Clear(); txtbox5.Clear();
            cmbbox1.Text = ""; cmbbox2.Text = ""; cmbbox3.Text = "";
        }

        // GÜNCELLEME BUTONU (btn19)
        
        private void btn3_Click(object sender, EventArgs e)
        {
            // Ana sayfa ismi sendekiyle aynı olmalı (Form adı neyse o)
            otopark_otomasyonu_anasayfa ana = new otopark_otomasyonu_anasayfa();
            ana.Show();
            this.Hide();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn19_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                string sorgu = "UPDATE arac_sahibi SET ad=@p2, soyad=@p3, cep_telefonu=@p4, plaka_no=@p5, arac_marka=@p6, arac_renk=@p7, park_yeri=@p8 WHERE tc_kimlik=@p1";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", txtbox1.Text);
                komut.Parameters.AddWithValue("@p2", txtbox2.Text);
                komut.Parameters.AddWithValue("@p3", txtbox3.Text);
                komut.Parameters.AddWithValue("@p4", txtbox4.Text);
                komut.Parameters.AddWithValue("@p5", txtbox5.Text);
                komut.Parameters.AddWithValue("@p6", cmbbox1.Text);
                komut.Parameters.AddWithValue("@p7", cmbbox2.Text);
                komut.Parameters.AddWithValue("@p8", cmbbox3.Text);

                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Bilgiler Güncellendi!", "Bilgi");
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Güncelleme Hatası: " + ex.Message);
            }
        }

        private void btn20_Click(object sender, EventArgs e)
        {
            otopark_otomasyonu_anasayfa anaSayfa = new otopark_otomasyonu_anasayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void btn21_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VerileriListele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                // Markaları SQL'den çekip ComboBox'a (cmbbox1) doldurur
                cmbbox1.Items.Clear();
                SqlCommand k1 = new SqlCommand("SELECT marka FROM marka_bilgileri", baglanti);
                SqlDataReader dr1 = k1.ExecuteReader();
                while (dr1.Read())
                {
                    cmbbox1.Items.Add(dr1["marka"].ToString());
                }
                dr1.Close();

                // Renkleri SQL'den çekip ComboBox'a (cmbbox2) doldurur
                cmbbox2.Items.Clear();
                SqlCommand k2 = new SqlCommand("SELECT renk FROM renk_bilgileri", baglanti);
                SqlDataReader dr2 = k2.ExecuteReader();
                while (dr2.Read())
                {
                    cmbbox2.Items.Add(dr2["renk"].ToString());
                }
                dr2.Close();

                baglanti.Close();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Liste hatası: " + ex.Message);
            }
        }

        private void btn16_Click(object sender, EventArgs e)
        {
            marka markaFormu = new marka();
            markaFormu.ShowDialog();
        }

        private void btn17_Click(object sender, EventArgs e)
        {
            renk renkFormu = new renk();
            renkFormu.ShowDialog();
        }
    }
}

