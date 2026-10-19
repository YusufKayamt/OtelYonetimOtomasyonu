using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otelOtomasonuProje
{
    public partial class FRManaForm : Form
    {
        public FRManaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRMadminGiris fr = new FRMadminGiris();
            fr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FRMmusteriEkle fr = new FRMmusteriEkle();
            fr.Show();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FRModalar fr = new FRModalar();
           fr.Show();
        }

        private void FRManaForm_Load(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

       

        private void BTNisTakvimi_Click(object sender, EventArgs e)
        {
            IsTakvimi fr = new IsTakvimi();
            fr.Show();
        }

        private void BTNmusteriler_Click(object sender, EventArgs e)
        {
            FRMmusteriler fr = new FRMmusteriler();
            fr.Show();
        }

        private void BTNhakkımızda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("YMK OTEL, konforlu odaları ve mükemmel hizmet anlayışıyla misafirlerine unutulmaz bir deneyim sunmaktadır.");
        }
    }
}
