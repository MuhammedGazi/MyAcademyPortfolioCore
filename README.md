# MyAcademyPortfolioCore
MyAcademyPortfolioCore - ASP.NET Core Dinamik Portfolyo Projesi
Bu proje, ASP.NET Core MVC kullanılarak geliştirilmiş, N-Katmanlı mimariye sahip dinamik bir kişisel portfolyo web sitesidir. Kullanıcılar, admin paneli üzerinden web sitesindeki tüm içerikleri (hakkımda, deneyimler, eğitimler, projeler vb.) kolayca yönetebilirler.

🚀 Öne Çıkan Özellikler
Dinamik İçerik Yönetimi: Sitedeki tüm metinler, resimler ve bilgiler veritabanından gelir ve yönetilebilir.

Modern Tasarım: Temiz ve responsive bir arayüze sahiptir.

Entity Framework Core: Veritabanı işlemleri için ORM (Object-Relational Mapping) aracı olarak Entity Framework Core kullanılmıştır.

🛠️ Yönetilebilen Modüller
Admin paneli üzerinden aşağıdaki bölümler kolayca yönetilebilir:

Banner: Ana sayfadaki karşılama alanı.

Hakkımda: Kişisel bilgiler, fotoğraf ve özet.

Yetenekler: Sahip olunan yeteneklerin listesi.

Özgeçmiş: Eğitim ve deneyim bilgileri.

Hizmetler: Sunulan hizmetlerin listesi.

Projeler: Yapılan projelerin detayları.

Referanslar: Müşteri veya iş arkadaşı yorumları.

Sosyal Medya: Sosyal medya hesap linkleri.

İletişim: İletişim formu üzerinden gelen mesajları görüntüleme.

💻 Teknolojiler ve Mimari
Backend: ASP.NET Core MVC (.NET 9)

Veritabanı Erişimi: Entity Framework Core

Mimari: Tek Katman

Frontend: HTML5, CSS3, JavaScript, Bootstrap

⚙️ Kurulum ve Çalıştırma
Projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları izleyebilirsiniz:

Projeyi Klonlayın:

git clone [https://github.com/MuhammedGazi/MyAcademyPortfolioCore.git](https://github.com/MuhammedGazi/MyAcademyPortfolioCore.git)

Visual Studio ile Açın:

Proje klasöründeki .sln uzantılı dosyayı Visual Studio ile açın.

Veritabanı Bağlantısını Yapılandırın:

Portfolio.Web projesi içindeki appsettings.json dosyasını açın.

ConnectionStrings bölümündeki bağlantı bilgisini kendi SQL Server bilgilerinize göre güncelleyin.

"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=MyPortfolioDb;Trusted_Connection=True;TrustServerCertificate=True;"
}

Veritabanını Oluşturun (Migrations):

Visual Studio'da Tools > NuGet Package Manager > Package Manager Console'u açın.

Açılan konsolda Default project olarak Portfolio.DataAccess projesini seçin.

Aşağıdaki komutu çalıştırarak veritabanını oluşturun ve tabloları ekleyin:

Update-Database

Projeyi Başlatın:

Portfolio.Web projesini başlangıç projesi olarak ayarlayın (Set as Startup Project).

Projeyi çalıştırmak için F5 tuşuna basın veya Start butonuna tıklayın.

📄 Lisans
Bu proje MIT Lisansı ile lisanslanmıştır. Detaylar için LICENSE dosyasına göz atabilirsiniz.
