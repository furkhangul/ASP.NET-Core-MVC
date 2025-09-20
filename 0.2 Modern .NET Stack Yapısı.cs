
// Modern .NET Stack Yapısı

// 1. Çekirdek Katman
// .NET Runtime -> Kodun çalıştırıldığı ortamdır (CLR).
// .NET SDK -> Uygulama geliştirmek için kullanılan araç seti.
// BCL (Base Class Library) -> String, koleksiyonlar, dosya IO gibi temel sınıfları içerir.

// 2. Programlama Dilleri
// C# -> En çok kullanılan dil, modern özelliklere sahiptir.
// F# -> Fonksiyonel programlama odaklıdır.
// VB.NET -> Artık az kullanılır, eski projelerde bulunur.

// 3. Uygulama Katmanları
// ASP.NET Core -> Web uygulamaları ve API geliştirmek için kullanılır.
//   - MVC, Razor Pages, Blazor, Minimal API, gRPC desteği bulunur.
// .NET MAUI -> Tek kod tabanı ile Android, iOS, Windows ve macOS için uygulama geliştirilir.
// WPF ve WinForms -> Sadece Windows üzerinde çalışan klasik masaüstü uygulamalarıdır.
// Unity -> Oyun geliştirme motoru, C# dili kullanır.

// 4. Veri Erişimi
// Entity Framework Core -> ORM yapısı ile veritabanı işlemleri kolayca yapılır.
// Dapper -> Hafif ve hızlı bir mikro ORM.
// ADO.NET -> Doğrudan SQL komutları ile çalışma imkanı sağlar.

// 5. Modern Özellikler
// Cross-platform -> Windows, Linux, macOS üzerinde çalışabilir.
// Yüksek performans -> .NET 6, 7, 8 ile performans ciddi şekilde artırılmıştır.
// Asenkron programlama (async/await) -> Yüksek performanslı IO işlemleri yapılır.
// Dependency Injection -> Yerleşik olarak desteklenir.
// Middleware -> HTTP request pipeline üzerinde özelleştirme imkanı sunar.
// Configuration ve Logging -> Standart ve genişletilebilir yapıdadır.
// SignalR ve gRPC -> Gerçek zamanlı iletişim desteği sağlar.

// 6. Araçlar
// NuGet -> Paket yönetim sistemi.
// dotnet CLI -> Proje oluşturma, build, publish ve test işlemleri için komut satırı aracı.
// IDE'ler -> Visual Studio, Visual Studio Code ve JetBrains Rider kullanılabilir.
// Test Frameworkleri -> xUnit, NUnit ve MSTest sıkça tercih edilir.

// 7. Mimari Yaklaşımlar
// Clean Architecture -> Katmanlı ve bağımsız bir yapı sağlar.
// Onion Architecture -> İş kuralları merkeze alınarak tasarlanır.
// Hexagonal Architecture -> Ports & Adapters mantığı ile esnek bir yapı kurulur.
// Microservices -> Küçük ve bağımsız servisler ile ölçeklenebilir sistemler geliştirilir.
// CQRS ve Event Sourcing -> Özellikle büyük sistemlerde performans ve tutarlılık için kullanılır.
