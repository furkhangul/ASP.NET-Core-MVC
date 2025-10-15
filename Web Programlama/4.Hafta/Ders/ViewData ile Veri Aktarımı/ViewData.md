*ViewData:

    ViewData, küçük ve geçici verileri taşımak için kullanılan bir yapıdır.
    ViewBag’e çok benzer; ikisi de Controller’dan View’a veri göndermek için kullanılır.
    Ancak ViewData, veri taşırken anahtar-değer (key-value) mantığıyla çalışır.
    Yani içerisine veri şöyle eklenir: ViewData["Mesaj"] = "Hoş geldin";
    Daha sonra View tarafında bu veriye köşeli parantez ile erişilir: @ViewData["Mesaj"]
    ViewData ile gönderilen veriler geçicidir, sadece ilgili View’da kullanılabilir.
    Ayrıca ViewData kullanırken bazen veriyi doğru türde kullanmak için tip dönüşümü (cast) yapılması gerekir.
    Bu yüzden dikkatli kullanılması gerekir. Küçük, hızlı ve basit bilgileri taşımak için uygundur.

*Model, ViewBag ve ViewData:

    Model, asıl verilerin tutulduğu yer yani oyuncak kutusu olarak düşünebiliriz.
    Bütün veriler bu oyuncak kutusunun içinde bilgileriyle birlikte saklanır.
    Model genellikle veritabanından gelen büyük ve anlamlı verileri taşımak için kullanılır.
    Veriler belirli bir yapıda (class) tutulur ve düzenlidir.
    
    ViewBag ise küçük notların tutulduğu post-it gibi düşünülebilir.
    Bazen hızlıca bir bilgi göstermek isteriz ama koca kutuyu yani modeli taşımak gerekmez.
    Mesela bir mesaj göstermek ya da başlığı değiştirmek gibi küçük işler için ViewBag kullanılır.
    Dinamik bir yapısı vardır, veriye “.” ile erişilir ve geçici olarak veri taşır.
    
    ViewData da yine küçük, geçici ve hızlı veri taşımak için kullanılır.
    ViewBag’e benzer ama yapısı farklıdır. İçine veriler anahtar-değer şeklinde yazılır.
    Veriye köşeli parantez ile erişilir ve genellikle tip dönüşümü gerekebilir.
    Karmaşık veri işlemleri için uygun değildir, basit veri aktarımı için tercih edilir.

| **Özellik**                     | **MODEL**                                 | **VIEWBAG**                                        | **VIEWDATA**                                                 |
| :------------------------------ | :---------------------------------------- | :------------------------------------------------- | :----------------------------------------------------------- |
| **Amacı**                       | Gerçek verileri saklamak ve taşımak       | Geçici, hızlı bilgi taşımak                        | Geçici, hızlı bilgi taşımak                                  |
| **Yapısı**                      | Sınıf (class) yapısındadır                | Dinamik yapıdadır                                  | Sözlük (Dictionary) yapısındadır (key-value)                 |
| **Kullanım Alanı**              | Veritabanından gelen verileri tutmak için | Başlık, mesaj gibi küçük bilgiler için             | Başlık, mesaj gibi küçük bilgiler için                       |
| **Tekrar Kullanılabilir mi?**   | Evet, birçok yerde kullanılabilir         | Hayır, genelde sadece bir defalık görüntüleme için | Hayır, genelde sadece bir defalık görüntüleme için           |
| **Tip Güvenliği (type safety)** | Evet, derleme sırasında kontrol edilir    | Hayır, run-time’da hata verebilir                  | Hayır, run-time’da hata verebilir ve cast işlemi gerekebilir |
| **Veri Miktarı**                | Çok veri taşıyabilir (liste, nesne vs.)   | Az ve basit veri taşımak uygundur                  | Az ve basit veri taşımak uygundur                            |
| **Kontrol Kolaylığı**           | Kolay, çünkü yapısı bellidir              | Daha esnek ama kontrolsüzdür                       | Daha az okunabilir ve dikkat ister                           |
| **Veriye Erişim Şekli**         | model.Özellik                             | ViewBag.Özellik                                    | ViewData["Anahtar"]                                          |
| **Örnek Kullanım**              | Ürün listesi, kullanıcı bilgileri         | “Hoş geldin” mesajı, sayfa başlığı                 | “Hoş geldin” mesajı, uyarı metni                             |
