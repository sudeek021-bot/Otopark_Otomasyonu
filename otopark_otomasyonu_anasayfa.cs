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
using WindowsFormsApp13;

namespace WindowsFormsApp13
{
    public partial class otopark_otomasyonu_anasayfa : Form
    {
        public otopark_otomasyonu_anasayfa()
        {
            InitializeComponent();
        }
        private SqlConnection baglanti = new SqlConnection(connectionString: "Data Source=DESKTOP-TI2COR6;Initial Catalog=oto;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtbox1_Click(object sender, EventArgs e)
        {
            otopark_kaydi kayitFormu = new otopark_kaydi();
            kayitFormu.Show();
            this.Hide();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            otoparkyeri_sec cikisFormu = new otoparkyeri_sec();
            cikisFormu.Show();
            this.Hide();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            arac_otopark_yerleri durumFormu = new arac_otopark_yerleri();
            durumFormu.Show();
            this.Hide();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void otopark_otomasyonu_anasayfa_Load(object sender, EventArgs e)
        {

        }
    }
}
