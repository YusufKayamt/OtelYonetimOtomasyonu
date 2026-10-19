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
    public partial class FRModalar : Form
    {
        public FRModalar()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = Veritabani.BaglantiOlustur();

        private void BTNoda101_Click(object sender, EventArgs e)
        {
            oda101 fr = new oda101();
            fr.Show();
            this.Hide();
        }

        private void BTNoda102_Click(object sender, EventArgs e)
        {
            oda102 fr = new oda102();
            fr.Show();
            this.Hide();
        }

        private void BTNoda103_Click(object sender, EventArgs e)
        {
            oda103 fr = new oda103();
            fr.Show();
            this.Hide();
        }

        private void BTNoda104_Click(object sender, EventArgs e)
        {
            oda104 fr = new oda104();
            fr.Show();
            this.Hide();
        }

        private void BTNoda105_Click(object sender, EventArgs e)
        {
            oda105 fr = new oda105();
            fr.Show();
            this.Hide();
        }

        private void BTNoda201_Click(object sender, EventArgs e)
        {
            oda201 fr = new oda201();
            fr.Show();
            this.Hide();
        }

        private void BTNoda202_Click(object sender, EventArgs e)
        {
            oda202 fr = new oda202();
            fr.Show();
            this.Hide();
        }

        private void BTNoda203_Click(object sender, EventArgs e)
        {
            oda203 fr = new oda203();
            fr.Show();
            this.Hide();
        }

        private void BTNoda204_Click(object sender, EventArgs e)
        {
            oda204 fr = new oda204();
            fr.Show();
            this.Hide();
        }

        private void BTNoda205_Click(object sender, EventArgs e)
        {
            oda205 fr = new oda205();
            fr.Show();
            this.Hide();
        }

        private void FRModalar_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut1 = new SqlCommand("select * from Oda101", baglanti);
            SqlDataReader oku1 = komut1.ExecuteReader();

            if (oku1.Read())
            {
                BTNoda101.Text = oku1["AdiSoyadi"].ToString();
                if (!string.IsNullOrEmpty(BTNoda101.Text)) // Eğer butonun metni doluysa
                {
                    BTNoda101.BackColor = Color.Red; // Butonun arka plan rengini kırmızı yap
                }
            }
            oku1.Close();

            SqlCommand komut3 = new SqlCommand("select * from Oda103", baglanti);
            SqlDataReader oku3 = komut3.ExecuteReader();

            if (oku3.Read())
            {
                BTNoda103.Text = oku3["AdiSoyadi"].ToString();
                if (!string.IsNullOrEmpty(BTNoda103.Text)) // Eğer butonun metni doluysa
                {
                    BTNoda103.BackColor = Color.Red; // Butonun arka plan rengini kırmızı yap
                }
            }
            oku3.Close();

            SqlCommand komut4 = new SqlCommand("select * from Oda104", baglanti);
            SqlDataReader oku4 = komut4.ExecuteReader();

            if (oku4.Read())
            {
                BTNoda104.Text = oku4["AdiSoyadi"].ToString();
                if (!string.IsNullOrEmpty(BTNoda104.Text)) // Eğer butonun metni doluysa
                {
                    BTNoda104.BackColor = Color.Red; // Butonun arka plan rengini kırmızı yap
                }
            }
            oku3.Close();

            baglanti.Close();
        }

    }
}
//ÇALIŞIYOR************************************************************