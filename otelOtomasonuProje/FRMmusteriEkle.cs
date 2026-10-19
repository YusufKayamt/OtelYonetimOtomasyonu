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

namespace otelOtomasonuProje
{
    public partial class FRMmusteriEkle : Form
    {
        public FRMmusteriEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = Veritabani.BaglantiOlustur();
        private void oda101_Click(object sender, EventArgs e)
        {
            comboBoxEdit2.Text = "101";
        }

        private void BTNoda102_Click(object sender, EventArgs e)
        {
            comboBoxEdit2.Text = "102";

        }

        private void BTNoda103_Click(object sender, EventArgs e)
        {
            comboBoxEdit2.Text = "103";

        }

        private void BTNoda104_Click(object sender, EventArgs e)
        {
            comboBoxEdit2.Text = "104";

        }

        private void BTNoda105_Click(object sender, EventArgs e)
        {
            comboBoxEdit2.Text = "105";

        }

        private void BTNoda201_Click(object sender, EventArgs e)
        {
            comboBoxEdit2.Text = "201";

        }

        private void BTNoda202_Click(object sender, EventArgs e)
        {
            comboBoxEdit2.Text = "202";

        }

        private void BTNoda203_Click(object sender, EventArgs e)
        {
            comboBoxEdit2.Text = "203";

        }

        private void BTNoda204_Click(object sender, EventArgs e)
        {
            comboBoxEdit2.Text = "204";

        }

        private void BTNoda205_Click(object sender, EventArgs e)
        {
            comboBoxEdit2.Text = "205";

        }



        private void BTNoda505_Click(object sender, EventArgs e)
        {
            textOdaNo1.Text = "505";

        }

        private void BTNdolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kırmızı renkli odalar doludur!");
        }

        private void BTNbos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Yeşil renkli odalar boştur!");

        }

        private void maskedTextCikTar_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            int Ucret;
            DateTime GirisTarih = Convert.ToDateTime(maskedTextGirTar.Text);
            DateTime CikisTarih = Convert.ToDateTime(maskedTextCikTar.Text);

            TimeSpan Sonuc;
            Sonuc = CikisTarih - GirisTarih;
            label13.Text = Sonuc.TotalDays.ToString();


            Ucret = Convert.ToInt32(label13.Text) * 1000;
            textUcret.Text = Ucret.ToString();


        }

        private void maskedTextGirTar_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {
        }


        private void BTNkaydet_Click(object sender, EventArgs e)
        {
            string odaNo = comboBoxEdit2.Text;

            baglanti.Open();

            SqlCommand komutKontrol = new SqlCommand("SELECT COUNT(*) FROM MusteriEkle WHERE OdaNo = @OdaNo", baglanti);
            komutKontrol.Parameters.AddWithValue("@OdaNo", odaNo);

            int odaDolu = Convert.ToInt32(komutKontrol.ExecuteScalar());

            if (odaDolu > 0)
            {
                MessageBox.Show("Bu oda zaten dolu, lütfen başka bir oda seçin.", "Oda Dolu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlCommand komut = new SqlCommand("INSERT INTO MusteriEkle (Adi, Soyadi, Cinsiyeti, Telefon, Adres, Mail, TCno, OdaNo, Ucret) " +
                                                  "VALUES (@Adi, @Soyadi, @Cinsiyeti, @Telefon, @Adres, @Mail, @TCno, @OdaNo, @Ucret)", baglanti);

                komut.Parameters.AddWithValue("@Adi", textisim.Text);
                komut.Parameters.AddWithValue("@Soyadi", textSoyisim.Text);
                komut.Parameters.AddWithValue("@Cinsiyeti", comboBoxEdit1.Text);
                komut.Parameters.AddWithValue("@Telefon", textTelefon.Text);
                komut.Parameters.AddWithValue("@Adres", textAdres.Text);
                komut.Parameters.AddWithValue("@Mail", textMail.Text);
                komut.Parameters.AddWithValue("@TCno", textTCno.Text);
                komut.Parameters.AddWithValue("@OdaNo", odaNo);
                komut.Parameters.AddWithValue("@Ucret", textUcret.Text);

                komut.ExecuteNonQuery();
                MessageBox.Show("Müşteri Kaydı Yapıldı");

            }

            baglanti.Close();
        }

        private void OdaRengiGuncelle()
        {
            baglanti.Open();

            var odaButonlari = new Dictionary<string, Button>
    {
        { "101", BTNoda101 },
        { "102", BTNoda102 },
        { "103", BTNoda103 },
        { "104", BTNoda104 },
        { "105", BTNoda105 },
        { "201", BTNoda201 },
        { "202", BTNoda202 },
        { "203", BTNoda203 },
        { "204", BTNoda204 },
        { "205", BTNoda205 },
        
    };

            foreach (var oda in odaButonlari)
            {
                string odaNumarasi = oda.Key;

                SqlCommand komutKontrol = new SqlCommand("SELECT COUNT(*) FROM MusteriEkle WHERE OdaNo = @OdaNo", baglanti);
                komutKontrol.Parameters.AddWithValue("@OdaNo", odaNumarasi);

                int odaDolu = Convert.ToInt32(komutKontrol.ExecuteScalar());

                if (odaDolu > 0) 
                {
                    oda.Value.BackColor = Color.Red;  
                    oda.Value.Enabled = false;         
                }
                else 
                {
                    oda.Value.BackColor = Color.Green; 
                    oda.Value.Enabled = true;           
                }
            }

            baglanti.Close();
        }

        private void label13_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxEdit2_EditValueChanged(object sender, EventArgs e)
        {
            string odaNumarasi = comboBoxEdit2.EditValue?.ToString(); 


            var butonlar = new Dictionary<string, Button>
    {
        { "101", BTNoda101 },
        { "102", BTNoda102 },
        { "103", BTNoda103 },
        { "104", BTNoda104 },
        { "105", BTNoda105 },
        { "201", BTNoda201 },
        { "202", BTNoda202 },
        { "203", BTNoda203 },
        { "204", BTNoda204 },
        { "205", BTNoda205 }
    };

            foreach (var button in butonlar.Values)
            {
                button.BackColor = Color.Green; 
            }

            if (!string.IsNullOrEmpty(odaNumarasi) && butonlar.ContainsKey(odaNumarasi))
            {
                butonlar[odaNumarasi].BackColor = Color.Red; 
            }
        }

        private void textUcret_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FRMmusteriEkle_Load(object sender, EventArgs e)
        {

        }
    }
}
//Data Source=DESKTOP-0V1D2BT\SQLEXPRESS;Initial Catalog=YMKotelOtomasyonu;Integrated Security=True
