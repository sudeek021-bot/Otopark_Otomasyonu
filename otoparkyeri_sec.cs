using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp13
{
    public partial class otoparkyeri_sec : Form
    {
        // BAĞLANTI CÜMLESİ (Veritabanı adın 'otopark' olarak güncellendi)
        private SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-TI2COR6;Initial Catalog=oto;Integrated Security=True");

        public otoparkyeri_sec()
        {
            InitializeComponent();
        }

        private void VerileriListele()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM arac_sahibi", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            catch (Exception ex) { MessageBox.Show("Liste Hatası: " + ex.Message); if (baglanti.State == ConnectionState.Open) baglanti.Close(); }
        }

        private void otoparkyeri_sec_Load(object sender, EventArgs e)
        {
            VerileriListele();
            PlakalariGetir();
        }

        private void PlakalariGetir()
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT plaka_no FROM arac_sahibi", baglanti);
                SqlDataReader dr = komut.ExecuteReader();
                cmbbox4.Items.Clear();
                while (dr.Read()) { cmbbox4.Items.Add(dr["plaka_no"].ToString()); }
                dr.Close();
                baglanti.Close();
            }
            catch { if (baglanti.State == ConnectionState.Open) baglanti.Close(); }
        }

        // OTOPARKTAN AYRIL BUTONU (btn22)
        private void btn22_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbbox4.Text) || string.IsNullOrEmpty(cmbbox5.Text))
            {
                MessageBox.Show("Lütfen önce listeden bir araç seçin!", "Uyarı");
                return;
            }

            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                // 1. ADIM: Aracı Siliyoruz (Plaka kutusundan alır)
                SqlCommand sil = new SqlCommand("DELETE FROM arac_sahibi WHERE plaka_no = @plaka", baglanti);
                sil.Parameters.AddWithValue("@plaka", cmbbox4.Text);
                sil.ExecuteNonQuery();

                // 2. ADIM: Park Yerini BOŞ Yapıyoruz (Park Yer kutusundan alır)
                SqlCommand guncelle = new SqlCommand("UPDATE arac_durumu SET durumu = 'BOŞ' WHERE park_yeri = @yer", baglanti);
                guncelle.Parameters.AddWithValue("@yer", cmbbox5.Text);
                guncelle.ExecuteNonQuery();

                baglanti.Close();
                MessageBox.Show("Araç otoparktan başarıyla ayrıldı ve yer boşaltıldı!", "Bilgi");

                VerileriListele(); // Tabloyu yeniler
                PlakalariGetir(); // ComboBox listesini yeniler

                // Kutuları temizle
                cmbbox4.Text = ""; cmbbox5.Text = "";
                txtbox7.Clear(); txtbox8.Clear(); txtbox9.Clear(); txtbox10.Clear(); txtbox11.Clear();
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                MessageBox.Show("Ayrılma Hatası: " + ex.Message);
            }
        }

        // PLAKA ARAMA (txtbox6)
        private void txtbox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM arac_sahibi WHERE plaka_no LIKE '%" + txtbox6.Text + "%'", baglanti);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                baglanti.Close();
            }
            catch { if (baglanti.State == ConnectionState.Open) baglanti.Close(); }
        }

        // TABLOYA TIKLAYINCA VERİLERİ KUTULARA DOLDURMA
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // DÜZELTİLEN KISIM: 
                // Index 4 -> plaka_no -> cmbbox4 (Plaka Ara)
                // Index 7 -> park_yeri -> cmbbox5 (Park Yer)

                cmbbox4.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                cmbbox5.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
        }

        // PLAKA SEÇİLDİĞİNDE DİĞER BİLGİLERİ GETİRME
        private void cmbbox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM arac_sahibi WHERE plaka_no=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", cmbbox4.Text);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    txtbox7.Text = dr["plaka_no"].ToString();
                    txtbox8.Text = dr["arac_marka"].ToString();
                    txtbox9.Text = dr["arac_renk"].ToString();
                    txtbox10.Text = dr["ad"].ToString();
                    txtbox11.Text = dr["soyad"].ToString();
                    cmbbox5.Text = dr["park_yeri"].ToString();
                }
                dr.Close();
                baglanti.Close();
            }
            catch { if (baglanti.State == ConnectionState.Open) baglanti.Close(); }
        }

        private void btn23_Click(object sender, EventArgs e)
        {
            otopark_otomasyonu_anasayfa anaSayfa = new otopark_otomasyonu_anasayfa();
            anaSayfa.Show();
            this.Hide();
        }

        private void btn241_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}