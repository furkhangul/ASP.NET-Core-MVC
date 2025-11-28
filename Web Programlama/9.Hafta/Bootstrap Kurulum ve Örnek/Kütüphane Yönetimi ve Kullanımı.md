Bootstrap ve JQuery gibi kütüphaneleri indirmek ve kullanımı

    Kütüphaneleri wwwroot uzantılı dosyaya sağ tıklayarak 
    wwwroot > Ekle > İstemci tarfı Kitaplığı 
    sekmesine basarak istediğimiz kütüphaneyi ekleme işlemini gerçekleştirebiliriz.

    Fakat ekstra oluşabilecek olan durumlarda ise ana dosyamızın yani proje dosyamızın altında libman.json adında bir dosya ekleyerek
    bu işlemleri manuel olarak gerçekleştirebilmekteyiz.
    Örnek olarak:
      {
      "version": "1.0",
      "defaultProvider": "cdnjs",
      "libraries": [
        {
          "library": "bootstrap@5.3.8",
          "destination": "wwwroot/bootstrap"
        },
        {
          "library": "jquery@3.7.1",
          "destination": "wwwroot/jquery/"
        },
        {
          "library": "jquery-validate@1.21.0",
          "destination": "wwwroot/jquery-validate/"
        },
        {
          "library": "jquery-validation-unobtrusive@4.0.0",
          "destination": "wwwroot/jquery-validation-unobtrusive/"
        }
      ]
    }

    şeklinde istediğimiz kitaplığı indirip bu kitaplığı kullanabiliriz.


UYARI

    Doğrudan kullandığımız projede bunu import edebilmemiz mümkün değildir. Yani kütüphaneleri indirdik fakat makine hala bu dosyaları bir uzantı olarak algılamaktadır.
    Bunun için en doğru yöntem program.cs 'ye giderek 

    
    app.UseStaticFiles(new StaticFileOptions()
    {
        RequestPath = "/wwwroot",
        
    });



    kodu ile wwwroot'un bir static dosya olduğunu programa anlatmamız gerekmektedir. Bu sayede artık sorun yaşamdan kütüphane yükleme işlemi gerçekleştirebiliriz.
