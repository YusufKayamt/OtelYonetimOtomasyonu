# Otel Yönetim Otomasyonu

Küçük ölçekli bir otelin oda, müşteri ve personel işlerini tek bir masaüstü uygulamasından yönetmek için geliştirilmiş C# / Windows Forms otomasyonu. İlk C# projemdir; arayüz, iş mantığı ve veritabanı katmanını tek başıma geliştirdim.

<!-- Ekran görüntüleri: docs/ klasörüne ekleyip aşağıdaki satırları açın -->
<!-- ![Ana ekran](docs/anaekran.png) -->
<!-- ![Odalar](docs/odalar.png) -->

## Özellikler

- **Yönetici girişi:** Kullanıcı adı ve SHA-256 ile özetlenmiş şifre `App.config` üzerinden doğrulanır.
- **Müşteri yönetimi:** Yeni müşteri kaydı, oda ataması, listeleme ve güncelleme. Dolu bir odaya ikinci kayıt engellenir.
- **Oda durum takibi:** Temizlik, müsaitlik, sipariş, ihtiyaç ve ödeme durumlarının kaydı (101–104 numaralı odalar aktif).
- **Personel iş takvimi:** Görev, görevli, başlangıç ve teslim tarihi ile iş ekleme, güncelleme ve arama.

## Teknolojiler

| Katman | Teknoloji |
| --- | --- |
| Arayüz | C#, Windows Forms, DevExpress 18.1 |
| Veri erişimi | ADO.NET (`SqlConnection`, `SqlCommand`), parametreli sorgular |
| Veritabanı | Microsoft SQL Server (Express) |
| Platform | .NET Framework 4.6.1, Visual Studio |

## Kurulum

1. Depoyu klonlayın ve `otelOtomasonuProje.sln` dosyasını Visual Studio ile açın.
2. DevExpress 18.1 WinForms bileşenlerinin kurulu olduğundan emin olun.
3. `database/schema.sql` dosyasını SQL Server Management Studio'da çalıştırarak veritabanını oluşturun.
4. Gerekirse `otelOtomasonuProje/App.config` içindeki `OtelDb` bağlantı cümlesini kendi SQL Server örneğinize göre düzenleyin.
5. Projeyi derleyip çalıştırın. Varsayılan yönetici girişi `admin` / `123456`'dır; şifreyi değiştirmek için `YoneticiSifreHash` değerini yeni şifrenin SHA-256 özetiyle değiştirin.

## Proje Yapısı

```
├── database/schema.sql          # Veritabanı şeması
├── otelOtomasonuProje.sln
└── otelOtomasonuProje/
    ├── App.config               # Bağlantı cümlesi ve yönetici ayarları
    ├── Veritabani.cs            # Ortak bağlantı ve doğrulama sınıfı
    ├── FRMadminGiris.cs         # Yönetici girişi
    ├── FRManaForm.cs            # Ana panel ve menü
    ├── FRModalar.cs             # Oda seçimi
    ├── odaXXX.cs                # Oda durum formları
    ├── FRMmusteriEkle.cs        # Yeni müşteri kaydı
    ├── FRMmusteriler.cs         # Müşteri listesi ve güncelleme
    └── IsTakvimi.cs             # Personel iş takvimi
```

## Geliştirme Notları

İlk projem olduğu için bilinçli olarak sade tuttuğum, bugün farklı yapacağım noktalar:

- Her oda için ayrı form ve ayrı tablo kullanılıyor. Tek bir `Odalar` tablosu ve parametre alan tek bir oda formu ile yapı sadeleştirilebilir; 105 ve 201–205 numaralı odalar da bu şekilde etkinleştirilebilir.
- Veri erişimi formların içinde. Ayrı bir veri erişim katmanı (repository) ile test edilebilirlik artırılabilir.
- Tarih ve ücret alanları metin olarak saklanıyor; `DATE` ve `DECIMAL` tiplerine geçilebilir.

## Geliştirici

**Yusuf Mete Kaya** · [LinkedIn](https://www.linkedin.com/in/yusufmetekaya) · [GitHub](https://github.com/YusufKayamt)
