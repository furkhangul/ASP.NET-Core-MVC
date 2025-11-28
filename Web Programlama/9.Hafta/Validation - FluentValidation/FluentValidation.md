Fluent Validation

    Fluent Validation hazır bir kütüphanedir. Validasyon işlemlerini daha amaçlarına uygun çalışmasını sağlamaya yardımcı olur.
    Metadata işlemleri gibi nedenlerden ortaya çıkmışlardır. Data Annotationlarının validation çalışmalarınında kullanılmasını daha açık ve
    okunabilir kılması adına kullanılır ( Solid Prensipleri ).

    Metadata'dan daha kolay ve anlaşılırdır. Bir çok buna benzer kütüphane mevcuttur. Fakat en popülerlerinden biri bu kütüphanedir.

    Kütüphaneyi yüklemek için projeye sağ tıklayıp "NuGet Paket Yönetimi" seçeneğine basıyoruz. 
    Ardından arama kısmına "FluentValidation" şeklinde yazdığımızda  "FluentValidation Asp.Net Core" şeklinde çıkan kütüphaneyi seçtikten sonra gerekli kütüphaneyi        yükleme işlemini gerçekleştiriyoruz.



Uyarı 

        
        FluentValidation işlemini indirdikten sonra FluentValidation’ın çalışması için Program.cs
        içine bu kodları yazmamızın temel nedeni, doğrulama (validation) kurallarının otomatik olarak bulunması,
        kaydedilmesi ve uygulamaya entegre edilmesidir.
        
        
        //Bu kod sınıf istenilen sınıf içindeki ve alt sınıflardaki tüm doğrulayıcıları (validator) otomatik olarak bulur ve kaydeder.
        builder.Services.AddValidatorsFromAssemblyContaining<DataValidator>();
        //Bu kod , FluentValidation’ın ASP.NET Core ile entegrasyonunu sağlar ve doğrulama işlemlerinin otomatik olarak gerçekleştirilmesini mümkün kılar.
        builder.Services.AddFluentValidationClientsideAdapters();
        //Bu kod eski MVC pipeline içindi, minimal API’de gerekli değil.
        builder.Services.AddFluentValidationAutoValidation();
