using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Pansiyon_Uygulaması
{
    public partial class frmYeniMusteri : Form
    {
        public frmYeniMusteri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=ACER-LAPTOP;Initial Catalog=Pansiyon;Integrated Security=True");

        private void btnOda101_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "Oda 101";
        }

        private void btnOda102_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "Oda 102";
        }

        private void btnOda103_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "Oda 103";
        }

        private void btnOda104_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "Oda 104";
        }

        private void btnOda105_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "Oda 105";
        }

        private void btnOda106_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "Oda 106";
        }

        private void btnOda107_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "Oda 107";
        }

        private void btnOda108_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "Oda 108";
        }

        private void btnOda109_Click(object sender, EventArgs e)
        {
            txtOdano.Text = "Oda 109";
        }

        private void btnBosoda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil Butonlar Boş Odaları Gösterir");
        }

        private void btnDoluoda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı Butonlar Dolu Odaları Gösterir");
        }

        private void dtpCikis_ValueChanged(object sender, EventArgs e)
        {
            int Ucret;
            DateTime KucukTarih = Convert.ToDateTime(dtpGiris.Text);
            DateTime BuyukTarih = Convert.ToDateTime(dtpCikis.Text);
            TimeSpan Sonuc = BuyukTarih - KucukTarih;
            Ucret = Convert.ToInt32( Sonuc.TotalDays.ToString()) * 50;
            txtUcret.Text = Ucret.ToString();
        }

        private void frmYeniMusteri_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Insert Into MusteriEkle (Adi, Soyadi, TC, Telefon, Eposta, Odano, Ucret) Values ('" + txtAd.Text + "','" + txtSoyad.Text + "','" + txtTC.Text + "','" + mskTelefon.Text + "','" + txtposta.Text + "','" + txtOdano.Text + "','" + txtUcret.Text + "')", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Müşteri Kaydı Yapıldı");
        }
    }
}
//,'" + dtpGiris.Text + "','" + dtpCikis.Text + "'