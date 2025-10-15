TempData Nedir ?

    ViewBag ve ViewData gibi küçük bilgiler taşır ama onlardan farklı olarak sayfalar arasında veri taşımak için kullanılır.
    Yani sadece aynı View içinde değil, başka bir Action’a veya başka bir sayfaya yönlendirme yapıldığında da veri saklayabilir.
    TempData da anahtar-değer mantığıyla çalışır ve veriye yine köşeli parantez ile erişilir.
    Mesela TempData["mesaj"] = "Başarıyla kaydedildi" gibi bir kullanım yapılır.
    Bu veri bir sonraki istek (request) boyunca saklanır, sonra silinir.
    Çerezler ile saklanır !

Model, ViewBag, ViewData ve TempData:

    Model, verilerin saklandığı oyuncak kutusu gibi düşünülebilir.
    Büyük ve gerçek veriler bu kutunun içinde saklanır. Genelde veritabanı verileri bu modelde tutulur ve düzenli bir yapıdadır.
    
    ViewBag ise post-it gibi düşünülür. Küçük bir bilgi yazılır, geçici olarak görünür.
    Mesela kullanıcıya bir selam mesajı veya başlık göstermek için kullanılır.
    Sadece ilgili View için geçerlidir, başka sayfaya geçilirse silinir.

    ViewData da küçük bir defter gibidir.
    İçine notlar key-value şeklinde yazılır. ViewBag gibi geçici bilgi taşır ama erişim yöntemi farklıdır.
    Genelde basit veriler için tercih edilir.

    TempData ise bir sonraki odaya geçerken eline tutuşturulan bir not kağıdı gibi düşünülebilir.
    Yani bir Action’dan başka bir Action’a ya da başka bir View’a geçerken bilgi taşımak gerektiğinde kullanılır.
    Tek seferlik veri taşımada işe yarar. Eğer veri korunmak isteniyorsa ayrıca saklanması gerekir.


| **Özellik**                     | **MODEL**                              | **VIEWBAG**                             | **VIEWDATA**                                      | **TEMPDATA**                                                        |
| :------------------------------ | :------------------------------------- | :-------------------------------------- | :------------------------------------------------ | :------------------------------------------------------------------ |
| **Amacı**                       | Gerçek verileri taşımak ve saklamak    | Geçici, hızlı bilgi taşımak             | Geçici, hızlı bilgi taşımak                       | Sayfalar arası geçici bilgi taşımak                                 |
| **Yapısı**                      | Sınıf (class) yapısındadır             | Dinamik yapıdadır                       | Sözlük (Dictionary) yapısındadır                  | Sözlük (Dictionary) yapısındadır                                    |
| **Kullanım Alanı**              | Veritabanı verileri                    | Mesaj, başlık gibi küçük bilgiler       | Mesaj, başlık gibi küçük bilgiler                 | Bildirim, uyarı gibi bilgilerin başka sayfada gösterilmesi          |
| **Tekrar Kullanılabilir mi?**   | Evet, birçok yerde kullanılabilir      | Hayır, sadece ilgili View’da kullanılır | Hayır, sadece ilgili View’da kullanılır           | Hayır, sadece bir sonraki istek (request) için geçerlidir           |
| **Tip Güvenliği (type safety)** | Evet, derleme sırasında kontrol edilir | Hayır, run-time’da hata verebilir       | Hayır, run-time’da hata verebilir ve cast gerekir | Hayır, run-time’da hata verebilir ve cast gerekir                   |
| **Veri Miktarı**                | Büyük veriler için uygundur            | Küçük ve basit veriler için uygundur    | Küçük ve basit veriler için uygundur              | Küçük ve basit veriler için uygundur                                |
| **Kontrol Kolaylığı**           | Kolay, çünkü yapısı nettir             | Esnek ama kontrolsüz                    | Tip dönüşümü gerekebilir                          | Tip dönüşümü gerekebilir                                            |
| **Veriye Erişim Şekli**         | model.Özellik                          | ViewBag.Özellik                         | ViewData["anahtar"]                               | TempData["anahtar"]                                                 |
| **Örnek Kullanım**              | Ürün listesi, kullanıcı bilgileri      | “Hoş geldin” mesajı                     | “Sayfa başlığı”, “hata mesajı”                    | “Kaydınız başarıyla tamamlandı” mesajı başka sayfada gösterilecekse |
