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
    public partial class FRMmusteriler : Form
    {
        public FRMmusteriler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-0V1D2BT\SQLEXPRESS;Initial Catalog=YMKotelOtomasyonu;Integrated Security=True");

        private void verilergoster()
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *  from MusteriEkle", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriID"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyeti"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Adres"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TCno"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilergoster();
        }

        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textisim.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textSoyisim.Text = listView1.SelectedItems[0].SubItems[2].Text;
            comboBoxEdit1.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textTelefon.Text = listView1.SelectedItems[0].SubItems[4].Text;
            textAdres.Text = listView1.SelectedItems[0].SubItems[5].Text;
            textMail.Text = listView1.SelectedItems[0].SubItems[6].Text;
            textTCno.Text = listView1.SelectedItems[0].SubItems[7].Text;
            comboBoxEdit2.Text = listView1.SelectedItems[0].SubItems[8].Text;
            textUcret.Text = listView1.SelectedItems[0].SubItems[9].Text;



        }


        private void FRMmusteriler_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textisim.Clear();
            textSoyisim.Clear();
            comboBoxEdit1.Text = "";
            textTelefon.Clear();
            textAdres.Clear();
            textMail.Clear();
            textTCno.Clear();
            comboBoxEdit2.Text = "";
            textUcret.Clear();
        }

        private void BTNguncelle_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("UPDATE MusteriEkle SET Adi = @Adi, Soyadi = @Soyadi, Cinsiyeti = @Cinsiyeti, Telefon = @Telefon WHERE MusteriID = @MusteriID", baglanti);

                komut.Parameters.AddWithValue("@Adi", textisim.Text);
                komut.Parameters.AddWithValue("@Soyadi", textSoyisim.Text);
                komut.Parameters.AddWithValue("@Cinsiyeti", comboBoxEdit1.Text);
                komut.Parameters.AddWithValue("@Telefon", textTelefon.Text);
                komut.Parameters.AddWithValue("@MusteriID", id);

                komut.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }

            verilergoster();
        }

        private void BTNara_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *  from MusteriEkle where Adi like '%"+textİsimArama.Text+"%'", baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["MusteriID"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyeti"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Adres"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TCno"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());

                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
//Data Source=DESKTOP-0V1D2BT\SQLEXPRESS;Initial Catalog=YMKotelOtomasyonu;Integrated Security=True