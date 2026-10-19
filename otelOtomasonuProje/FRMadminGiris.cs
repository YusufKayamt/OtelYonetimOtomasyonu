using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace otelOtomasonuProje
{
    public partial class FRMadminGiris : DevExpress.XtraEditors.XtraForm
    {
        public FRMadminGiris()
        {
            InitializeComponent();
            textSifre.PasswordChar = '*';

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textKullaniciAdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void BTNgiris_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textKullaniciAdi.Text;
            string sifre = textSifre.Text;

            if (kullaniciAdi == "admin" && sifre == "123456")
            {
                FRManaForm sayfa = new FRManaForm();
                sayfa.Show(); 
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
