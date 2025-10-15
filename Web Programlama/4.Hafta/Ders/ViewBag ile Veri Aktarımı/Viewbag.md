 **Model ile ViewBag :


    Model asıl verilerin tutulduğu yer yani oyuncak kutusu olarak düşünebiliriz. 
    Bütün veriler bu oyuncak kutusunun içinde bilgileri ile tutumaktadır.
    Viewbag ise küçük notların tutulduğu post-it gibi düşünebiliriz bunu. Bazen hızlıca bir şey söylemek isteriz
    ama koca kutuyu yani modeli taşımak gerekmez iken kullanırız.
    Mesela bir veriyi görmek değilde sadece saklamak için çekmek istediğimizde tüm verilere ihtiyacımız yokken kullanabiliriz.
    Yani ViewBag küçük , geçici ve hızlı verileri taşımak için kullanılır.

| Özellik                            | **MODEL**                                             | **VIEWBAG**                                                          |
| ---------------------------------- | ----------------------------------------------------- | -------------------------------------------------------------------- |
|  **Amacı**                       | Gerçek verileri saklamak ve taşımak                   | Geçici, hızlı bilgi taşımak                                          |
|  **Yapısı**                     | Sınıf (class) olarak tanımlanır, düzgün ve düzenlidir | Dinamik yapılı, geçici bir veri taşıyıcısıdır                        |
|  **Kullanım Alanı**              | Veritabanından gelen verileri tutmak için             | Küçük mesajlar, başlıklar, uyarılar vs. için                         |
|  **Tekrar Kullanılabilir mi?**   | Evet, birçok yerde kullanılabilir                     | Hayır, genelde sadece bir defalık görüntüleme için                   |
|  **Tip Güvenliği (type safety)** | Evet, derleme sırasında kontrol edilir                | Hayır, derleme sırasında hata yakalanmaz (hatalar run-time’da çıkar) |
|  **Veri Miktarı**                | Çok veri taşıyabilir (liste, nesne vs.)               | Az ve basit veri taşımak uygundur                                    |
|  **Kontrol Kolaylığı**           | Kolay, çünkü yapısı bellidir                          | Daha zor, çünkü ne geleceği belli değildir                           |
|  **Örnek Kullanım**              | Ürün listesi, kullanıcı bilgileri                     | “Hoş geldin” mesajı, sayfa başlığı                                   |
