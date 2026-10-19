using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace otelOtomasonuProje
{
    public partial class oda102 : Form
    {
        public oda102()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = Veritabani.BaglantiOlustur();

        private void oda102_Load(object sender, EventArgs e)
        {
        }



        private void VerileriGoster()
        {
            try
            {
                baglanti.Open();

                string sorgu = "SELECT * FROM Oda103";

                SqlCommand komut = new SqlCommand(sorgu, baglanti);

                SqlDataReader reader = komut.ExecuteReader();

                while (reader.Read())
                {
                    textOda101İsim.Text = reader["AdiSoyadi"].ToString();
                    checkedBoxTemizlik101.EditValue = reader["TemizlikDurumu"].ToString();
                    checkedBoxMüsaitlik101.EditValue = reader["MusaitlikDurumu"].ToString();
                    checkedBoxSiparis101.EditValue = reader["SiparisDurumu"].ToString();
                    checkedBoxIhtiyac101.EditValue = reader["IhtiyacDurumu"].ToString();
                    checkedBoxOdeme101.EditValue = reader["OdemeBilgisi"].ToString();
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

        private void BTNOda103Kaydet_Click_1(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();

                string AdiSoyadi = textOda101İsim.Text;

                string TemizlikDurumu = checkedBoxTemizlik101.EditValue != null && checkedBoxTemizlik101.EditValue.ToString() == "TEMİZ" ? "TEMİZ" : "KİRLİ";

                string MusaitlikDurumu = checkedBoxMüsaitlik101.EditValue != null && checkedBoxMüsaitlik101.EditValue.ToString() == "BOŞ" ? "BOŞ" : "DOLU";

                string SiparisDurumu = checkedBoxSiparis101.EditValue != null && checkedBoxSiparis101.EditValue.ToString() == "SİPARİŞ VERİLDİ" ? "SİPARİŞ VERİLDİ" : "SİPARİŞ YOK";

                string IhtiyacDurumu = checkedBoxIhtiyac101.EditValue != null && checkedBoxIhtiyac101.EditValue.ToString() == "HAVLULAR YENİLENECEK" ? "HAVLULAR YENİLENECEK" : "ÇARŞAFLAR DEĞİŞİLECEK";

                string OdemeBilgisi = checkedBoxOdeme101.EditValue != null && checkedBoxOdeme101.EditValue.ToString() == "PEŞİN ÖDENDİ" ? "PEŞİN ÖDENDİ" : "TAKSİTLE ÖDENİYOR";

                string komut = "INSERT INTO Oda102 (AdiSoyadi, TemizlikDurumu, MusaitlikDurumu, SiparisDurumu, IhtiyacDurumu, OdemeBilgisi) " +
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

        private void BTNoda101Gor_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = Veritabani.BaglantiOlustur();

            try
            {
                baglanti.Open();

                string komut = "SELECT TOP 1 AdiSoyadi, TemizlikDurumu, MusaitlikDurumu, SiparisDurumu, IhtiyacDurumu, OdemeBilgisi FROM Oda102";
                SqlCommand cmd = new SqlCommand(komut, baglanti);
                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    textOda101İsim.Text = dr["AdiSoyadi"].ToString();

                    checkedBoxTemizlik101.EditValue = dr["TemizlikDurumu"].ToString();
                    checkedBoxMüsaitlik101.EditValue = dr["MusaitlikDurumu"].ToString();
                    checkedBoxSiparis101.EditValue = dr["SiparisDurumu"].ToString();
                    checkedBoxIhtiyac101.EditValue = dr["IhtiyacDurumu"].ToString();
                    checkedBoxOdeme101.EditValue = dr["OdemeBilgisi"].ToString();
                }
                else
                {
                    MessageBox.Show("Oda102 için veri bulunamadı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
