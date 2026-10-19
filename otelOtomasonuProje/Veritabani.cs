using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace otelOtomasonuProje
{
    /// <summary>
    /// Veritabanı bağlantısı ve yönetici doğrulaması için ortak yardımcı sınıf.
    /// Bağlantı cümlesi ve yönetici bilgileri App.config dosyasından okunur.
    /// </summary>
    public static class Veritabani
    {
        public static SqlConnection BaglantiOlustur()
        {
            var ayar = ConfigurationManager.ConnectionStrings["OtelDb"];
            if (ayar == null)
                throw new InvalidOperationException("App.config içinde 'OtelDb' bağlantı cümlesi bulunamadı.");
            return new SqlConnection(ayar.ConnectionString);
        }

        public static bool YoneticiDogrula(string kullaniciAdi, string sifre)
        {
            string beklenenKullanici = ConfigurationManager.AppSettings["YoneticiKullaniciAdi"];
            string beklenenHash = ConfigurationManager.AppSettings["YoneticiSifreHash"];
            if (string.IsNullOrEmpty(beklenenKullanici) || string.IsNullOrEmpty(beklenenHash))
                return false;

            return kullaniciAdi == beklenenKullanici
                && string.Equals(Sha256(sifre), beklenenHash, StringComparison.OrdinalIgnoreCase);
        }

        private static string Sha256(string metin)
        {
            using (var sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(metin ?? ""));
                var sb = new StringBuilder();
                foreach (byte b in bytes) sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }
    }
}
