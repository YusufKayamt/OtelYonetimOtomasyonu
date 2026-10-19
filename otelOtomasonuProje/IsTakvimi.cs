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
    public partial class IsTakvimi : Form
    {
        public IsTakvimi()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = Veritabani.BaglantiOlustur();


   
        private void verilergoster()
        {
            listView1.Items.Clear(); 
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM IsTakvimi", baglanti);
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.SubItems.Add(oku["YapılacakIs"].ToString());
                    ekle.SubItems.Add(oku["GorevliIsim"].ToString());
                    ekle.SubItems.Add(oku["BaslangicTarih"].ToString());
                    ekle.SubItems.Add(oku["TeslimTarih"].ToString());

                    listView1.Items.Add(ekle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void IsTakvimi_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("ID", 50); 
            listView1.Columns.Add("Yapılacak İş", 150);
            listView1.Columns.Add("Görevli İsim", 150);
            listView1.Columns.Add("Başlangıç Tarihi", 120);
            listView1.Columns.Add("Teslim Tarihi", 120);

            verilergoster();
        }


        private void textIsArama_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear(); 
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("SELECT * FROM IsTakvimi WHERE YapılacakIs LIKE @Arama", baglanti);
                komut.Parameters.AddWithValue("@Arama", "%" + textIsArama.Text + "%");
                SqlDataReader oku = komut.ExecuteReader();

                while (oku.Read())
                {
                    ListViewItem ekle = new ListViewItem();
                    ekle.SubItems.Add(oku["YapılacakIs"].ToString());
                    ekle.SubItems.Add(oku["GorevliIsim"].ToString());
                    ekle.SubItems.Add(oku["BaslangicTarih"].ToString());
                    ekle.SubItems.Add(oku["TeslimTarih"].ToString());

                    listView1.Items.Add(ekle);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            verilergoster();

        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                id = int.Parse(selectedItem.SubItems[0].Text); 
                textYapilacakIs.Text = selectedItem.SubItems[1].Text; 
                textGorevliKisi.Text = selectedItem.SubItems[2].Text; 
                maskedTextBaslangicTar.Text = selectedItem.SubItems[3].Text; 
                maskedTextTeslimTar.Text = selectedItem.SubItems[4].Text; 
            }
            else
            {
                MessageBox.Show("Lütfen bir satır seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }




        private void button3_Click(object sender, EventArgs e)
        {
            textYapilacakIs.Clear();
            textGorevliKisi.Clear();
            maskedTextBaslangicTar.Clear();
            maskedTextTeslimTar.Clear();
        }


        private void BTNisKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textYapilacakIs.Text) || string.IsNullOrEmpty(textGorevliKisi.Text) ||
                string.IsNullOrEmpty(maskedTextBaslangicTar.Text) || string.IsNullOrEmpty(maskedTextTeslimTar.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            try
            {
                if (!DateTime.TryParse(maskedTextBaslangicTar.Text, out DateTime baslangicTarih))
                {
                    MessageBox.Show("Başlangıç tarihi geçerli değil. Lütfen 'Gün.Ay.Yıl' formatında giriniz.");
                    return;
                }

                if (!DateTime.TryParse(maskedTextTeslimTar.Text, out DateTime teslimTarih))
                {
                    MessageBox.Show("Teslim tarihi geçerli değil. Lütfen 'Gün.Ay.Yıl' formatında giriniz.");
                    return;
                }

                baglanti.Open();
                SqlCommand komut = new SqlCommand("INSERT INTO IsTakvimi (YapılacakIs, GorevliIsim, BaslangicTarih, TeslimTarih) " +
                    "VALUES (@YapılacakIs, @GorevliIsim, @BaslangicTarih, @TeslimTarih)", baglanti);

                komut.Parameters.AddWithValue("@YapılacakIs", textYapilacakIs.Text);
                komut.Parameters.AddWithValue("@GorevliIsim", textGorevliKisi.Text);
                komut.Parameters.AddWithValue("@BaslangicTarih", baslangicTarih);
                komut.Parameters.AddWithValue("@TeslimTarih", teslimTarih);

                komut.ExecuteNonQuery();
                MessageBox.Show("Veri başarıyla kaydedildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
                verilergoster(); 
            }
        }

        private void BTNisGuncelle_Click(object sender, EventArgs e)
        {
            if (id == 0) 
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz kaydı seçin.");
                return;
            }

            if (string.IsNullOrEmpty(textYapilacakIs.Text) || string.IsNullOrEmpty(textGorevliKisi.Text) ||
                string.IsNullOrEmpty(maskedTextBaslangicTar.Text) || string.IsNullOrEmpty(maskedTextTeslimTar.Text))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.");
                return;
            }

            try
            {
                if (!DateTime.TryParse(maskedTextBaslangicTar.Text, out DateTime baslangicTarih))
                {
                    MessageBox.Show("Başlangıç tarihi geçerli değil. Lütfen 'Gün.Ay.Yıl' formatında giriniz.");
                    return;
                }

                if (!DateTime.TryParse(maskedTextTeslimTar.Text, out DateTime teslimTarih))
                {
                    MessageBox.Show("Teslim tarihi geçerli değil. Lütfen 'Gün.Ay.Yıl' formatında giriniz.");
                    return;
                }

                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE IsTakvimi SET YapılacakIs = @YapilacakIs, GorevliIsim = @GorevliIsim, " +
                                                  "BaslangicTarih = @BaslangicTarih, TeslimTarih = @TeslimTarih WHERE ID = @ID", baglanti);

                komut.Parameters.AddWithValue("@YapilacakIs", textYapilacakIs.Text);
                komut.Parameters.AddWithValue("@GorevliIsim", textGorevliKisi.Text);
                komut.Parameters.AddWithValue("@BaslangicTarih", baslangicTarih);
                komut.Parameters.AddWithValue("@TeslimTarih", teslimTarih);
                komut.Parameters.AddWithValue("@ID", id);

                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt başarıyla güncellendi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
                verilergoster(); 
                id = 0; 
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
