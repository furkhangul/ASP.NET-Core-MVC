//"dotnet build" komutu ile derlenir.
//"dotnet run" komutu ile çalıştırılır.
//"localhost:5000" adresinden erişilir. Ve burada gösterilir.
//Uygulama yapısında ise "Controllers" klasöründe "NotlarController.cs" dosyası bulunur.
//MVC de kullanılan Model-View-Controller yapısına göre "Notlar" modeli için controller dosyasıdır.
//"code ." ile VS Code açılır.
//Basic klasörü en üstteki klasördür.
//Homecontroller.cs dosyası da "Controllers" klasöründe bulunur ve ana sayfa ile ilgili işlemleri yönetir.
//"Views" klasöründe ise "Notlar" ve "Home" için ayrı klasörler bulunur.
//"Notlar" klasöründe "Index.cshtml" dosyası bulunur ve

//Coding By Covention
//Mağaza
//  -Controllers
//      -HomeController.cs
//      -PrdouctController.cs
//  -Models
//      -Product.cs
//  -Views
//      -Home
//          -Index.cshtml
//          -About.cshtml
//      -Product
//          -List.cshtml
//          -Detail.cshtml
//   -wwwroot
//      -css
//           -custom.css
//      -js
//           -custom.js
//      -images
//      -lib
//           -bootstrap
//           -jquery
//   -Startup.cs
