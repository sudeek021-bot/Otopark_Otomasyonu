using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp13
{
    public partial class arac_otopark_yerleri : Form
    {
        // Bağlantı cümlesini senin SQL scriptine göre 'otopark' yaptım
        private SqlConnection baglanti = new SqlConnection(connectionString: "Data Source=DESKTOP-TI2COR6;Initial Catalog=oto;Integrated Security=True");

        public arac_otopark_yerleri()
        {
            InitializeComponent();
            // Tüm park yeri butonlarını bu olayla ilişkilendiriyoruz
            BaglaButonOlaylari();
        }

        // Formdaki tüm Parkyeri butonlarını tek tek kodlamak yerine hepsini bu metoda bağlıyoruz
        private void BaglaButonOlaylari()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button && ctrl.Text.StartsWith("Parkyeri"))
                {
                    ctrl.Click += new EventHandler(ParkYeri_Click);
                }
            }
        }

        // Herhangi bir park yerine tıklandığında çalışacak ortak kod
        private void ParkYeri_Click(object sender, EventArgs e)
        {
            Button tiklananButon = (Button)sender;

            if (tiklananButon.BackColor == Color.Red)
            {
                MessageBox.Show("Bu park yeri şu an DOLU!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Seçilen yerin adını Kayıt Formuna gönderiyoruz
                otopark_kaydi kayitFormu = new otopark_kaydi();
                kayitFormu.secilen_yer = tiklananButon.Text;
                kayitFormu.Show();
                this.Hide();
            }
        }

        private void ParkYerleriniRenklendir()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                // Scriptindeki tablo ismine (arac_durumu) göre çekiyoruz
                SqlCommand komut = new SqlCommand("SELECT * FROM arac_durumu", baglanti);
                SqlDataReader dr = komut.ExecuteReader();

                while (dr.Read())
                {
                    string peronAdi = dr["park_yeri"].ToString();
                    string durum = dr["durumu"].ToString();

                    foreach (Control ctrl in this.Controls)
                    {
                        // Butonun üzerindeki yazı (Parkyeri-1 gibi) veritabanıyla eşleşiyorsa
                        if (ctrl is Button && ctrl.Text == peronAdi)
                        {
                            ctrl.BackColor = (durum == "DOLU") ? Color.Red : Color.Green;
                            ctrl.ForeColor = Color.White; // Yazı rengi beyaz olsun ki okunsun
                        }
                    }
                }
                dr.Close();
                baglanti.Close();
            }
            catch (Exception ex) { MessageBox.Show("Hata: " + ex.Message); }
        }

        private void arac_otopark_yerleri_Load(object sender, EventArgs e)
        {
            ParkYerleriniRenklendir();
        }

        private void button11_Click(object sender, EventArgs e) // GERİ BUTONU
        {
            // Ana sayfanın ismi neyse onu açmalısın
            otopark_otomasyonu_anasayfa ana = new otopark_otomasyonu_anasayfa();
            ana.Show();
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e) // ÇIKIŞ BUTONU
        {
            Application.Exit();
        }

        private void btn14_Click(object sender, EventArgs e)
        {
            otopark_otomasyonu_anasayfa ana = new otopark_otomasyonu_anasayfa();
            ana.Show();
            this.Close(); // Mevcut formu kapatır
        }

        private void btn15_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}