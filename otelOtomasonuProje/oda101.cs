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
    public partial class oda101 : Form
    {
        public oda101()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-0V1D2BT\SQLEXPRESS;Initial Catalog=YMKotelOtomasyonu;Integrated Security=True");


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void oda101_Load(object sender, EventArgs e)
        {

        }

        private void textOda101İsim_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkedBoxTemizlik101_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void checkedBoxMüsaitlik101_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void checkedBoxSiparis101_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void checkedBoxIhtiyac101_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void checkedBoxOdeme101_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void textOda101İsim_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void BTNOda101Kaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-0V1D2BT\SQLEXPRESS;Initial Catalog=YMKotelOtomasyonu;Integrated Security=True");

            try
            {
                baglanti.Open();

                string AdiSoyadi = textOda101İsim.Text;

                string TemizlikDurumu = checkedBoxTemizlik101.EditValue != null && checkedBoxTemizlik101.EditValue.ToString() == "TEMİZ" ? "TEMİZ" : "KİRLİ";

                string MusaitlikDurumu = checkedBoxMüsaitlik101.EditValue != null && checkedBoxMüsaitlik101.EditValue.ToString() == "BOŞ" ? "BOŞ" : "DOLU";

                string SiparisDurumu = checkedBoxSiparis101.EditValue != null && checkedBoxSiparis101.EditValue.ToString() == "SİPARİŞ VERİLDİ" ? "SİPARİŞ VERİLDİ" : "SİPARİŞ YOK";

                string IhtiyacDurumu = checkedBoxIhtiyac101.EditValue != null && checkedBoxIhtiyac101.EditValue.ToString() == "HAVLULAR YENİLENECEK" ? "HAVLULAR YENİLENECEK" : "ÇARŞAFLAR DEĞİŞİLECEK";

                string OdemeBilgisi = checkedBoxOdeme101.EditValue != null && checkedBoxOdeme101.EditValue.ToString() == "PEŞİN ÖDENDİ" ? "PEŞİN ÖDENDİ" : "TAKSİTLE ÖDENİYOR";


                string komut = "INSERT INTO Oda101 (AdiSoyadi, TemizlikDurumu, MusaitlikDurumu, SiparisDurumu, IhtiyacDurumu, OdemeBilgisi) " +
                               "VALUES (@AdiSoyadi, @TemizlikDurumu, @MusaitlikDurumu, @SiparisDurumu, @IhtiyacDurumu, @OdemeBilgisi)";

                SqlCommand cmd = new SqlCommand(komut, baglanti);
                cmd.Parameters.AddWithValue("@AdiSoyadi", AdiSoyadi);
                cmd.Parameters.AddWithValue("@TemizlikDurumu", TemizlikDurumu);
                cmd.Parameters.AddWithValue("@MusaitlikDurumu", MusaitlikDurumu);
                cmd.Parameters.AddWithValue("@SiparisDurumu", SiparisDurumu);
                cmd.Parameters.AddWithValue("@IhtiyacDurumu", IhtiyacDurumu);
                cmd.Parameters.AddWithValue("@OdemeBilgisi", OdemeBilgisi);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Veri başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }


        private void textOda101İsim_TextChanged_2(object sender, EventArgs e)
        {

        }

        private void BTNoda101Gor_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-0V1D2BT\SQLEXPRESS;Initial Catalog=YMKotelOtomasyonu;Integrated Security=True");

            try
            {
                baglanti.Open();

                string komut = "SELECT TOP 1 AdiSoyadi, TemizlikDurumu, MusaitlikDurumu, SiparisDurumu, IhtiyacDurumu, OdemeBilgisi FROM Oda101";
                SqlCommand cmd = new SqlCommand(komut, baglanti);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    // Verileri TextBox ve CheckBox'lara yazdır
                    textOda101İsim.Text = dr["AdiSoyadi"].ToString();

                    checkedBoxTemizlik101.EditValue = dr["TemizlikDurumu"].ToString();
                    checkedBoxMüsaitlik101.EditValue = dr["MusaitlikDurumu"].ToString();
                    checkedBoxSiparis101.EditValue = dr["SiparisDurumu"].ToString();
                    checkedBoxIhtiyac101.EditValue = dr["IhtiyacDurumu"].ToString();
                    checkedBoxOdeme101.EditValue = dr["OdemeBilgisi"].ToString();
                }
                else
                {
                    MessageBox.Show("Oda101 için veri bulunamadı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                baglanti.Close();
            }
        }

    }
}
