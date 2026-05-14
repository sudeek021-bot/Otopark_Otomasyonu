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
    public partial class renk : Form
    {
        private Label lbl17;
        private Button btn26;
        private TextBox txtbox13;

        public renk()
        {
            InitializeComponent();
        }

        // Veritabanı adını paylaştığın SQL scriptine göre 'otopark' olarak güncelledim
        private SqlConnection baglanti = new SqlConnection(connectionString: "Data Source=DESKTOP-TI2COR6;Initial Catalog=oto;Integrated Security=True");

        private void btn26_Click(object sender, EventArgs e)
        {
            // Kutunun boş olup olmadığını kontrol ediyoruz
            if (string.IsNullOrWhiteSpace(txtbox13.Text))
            {
                MessageBox.Show("Lütfen bir renk adı giriniz!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Bağlantıyı açıyoruz
                if (baglanti.State == ConnectionState.Closed) baglanti.Open();

                // SQL Scriptindeki tablo: renk_bilgileri, sütun: renk
                string sorgu = "INSERT INTO renk_bilgileri (renk) VALUES (@p1)";
                SqlCommand komut = new SqlCommand(sorgu, baglanti);
                komut.Parameters.AddWithValue("@p1", txtbox13.Text.Trim());

                komut.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Yeni renk başarıyla sisteme eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtbox13.Clear(); // Kayıt sonrası kutuyu temizle
            }
            catch (Exception ex)
            {
                if (baglanti.State == ConnectionState.Open) baglanti.Close();
                // Aynı renk zaten varsa Primary Key hatası verir, catch bunu yakalar
                MessageBox.Show("Hata: " + ex.Message);
            }
        }

        private void renk_Load(object sender, EventArgs e)
        {
            // Form yüklenirken yapılacak işlem varsa buraya yazılabilir
        }

        // DESIGNER KODLARI (Bu kısma dokunma, formun görünümü için gereklidir)
        private void InitializeComponent()
        {
            this.lbl17 = new System.Windows.Forms.Label();
            this.txtbox13 = new System.Windows.Forms.TextBox();
            this.btn26 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // lbl17
            this.lbl17.AutoSize = true;
            this.lbl17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl17.Location = new System.Drawing.Point(80, 104);
            this.lbl17.Name = "lbl17";
            this.lbl17.Size = new System.Drawing.Size(51, 20);
            this.lbl17.TabIndex = 0;
            this.lbl17.Text = "Renk";
            // txtbox13
            this.txtbox13.Location = new System.Drawing.Point(201, 102);
            this.txtbox13.Name = "txtbox13";
            this.txtbox13.Size = new System.Drawing.Size(177, 22);
            this.txtbox13.TabIndex = 1;
            // btn26
            this.btn26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn26.Location = new System.Drawing.Point(129, 195);
            this.btn26.Name = "btn26";
            this.btn26.Size = new System.Drawing.Size(162, 29);
            this.btn26.TabIndex = 2;
            this.btn26.Text = "Renk Ekle";
            this.btn26.UseVisualStyleBackColor = true;
            this.btn26.Click += new System.EventHandler(this.btn26_Click);
            // renk
            this.ClientSize = new System.Drawing.Size(452, 326);
            this.Controls.Add(this.btn26);
            this.Controls.Add(this.txtbox13);
            this.Controls.Add(this.lbl17);
            this.Name = "renk";
            this.Load += new System.EventHandler(this.renk_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}