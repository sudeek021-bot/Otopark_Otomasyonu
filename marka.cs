using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp13
{
    public partial class marka : Form
    {
        public marka()
        {
            InitializeComponent();
        }

        // Veritabanı adını scriptine göre 'otopark' olarak güncelledim
        private SqlConnection baglanti = new SqlConnection(connectionString: "Data Source=DESKTOP-TI2COR6;Initial Catalog=oto;Integrated Security=True");

        // MARKA EKLE BUTONU (Tasarımındaki butonun Click olayına bu kodu yazmalısın)
        private void btnMarkaEkle_Click(object sender, EventArgs e)
        {
            // TextBox isminin 'textBox1' olduğunu varsayıyorum (Tasarımda kontrol et)
            if (string.IsNullOrWhiteSpace(txtbox12.Text))
            {
                MessageBox.Show("Lütfen bir marka adı giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                // SQL Scriptindeki tablo: marka_bilgileri, sütun: marka
                string sorgu = "INSERT INTO marka_bilgileri (marka) VALUES (@p1)";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", txtbox12.Text.Trim()); // Baştaki/sondaki boşlukları siler

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Yeni marka başarıyla sisteme eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbox12.Clear(); // İşlem bitince kutuyu boşalt
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                // Aynı markayı eklemeye çalışırsan hata verir (Primary Key kısıtlaması)
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
        }

        // Eğer bu formdan ana sayfaya dönmek istersen bir geri butonu ekleyebilirsin
        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void marka_Load(object sender, EventArgs e)
        {

        }

        private void btn24_Click(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO marka_bilgileri (marka) VALUES (@p1)", baglanti);
                komut.Parameters.AddWithValue("@p1", txtbox12.Text); // Buradaki textBox1 ismini kontrol et
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Marka eklendi!");
                this.Close(); // Ekleme bitince bu küçük pencereyi kapat
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
        }
    }
}
