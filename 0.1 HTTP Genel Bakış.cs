//HTTP Protokolü
//İnternetteki sayısız kaynak arasında gezinmemizi sağlayan protokoldür.
//Kaynaklara erişirken taraycımıza bir web adresi yazarız.dns yani
//Alan adı ile ilişkili bir ip adresi vardır.
//Tarayıcı bu alan adını dns sunucusuna gönderir.
//Dns sunucusu bu alan adını ip adresine çevirir.
//Tarayıcı bu ip adresine http isteği gönderir.
//Buna request denir.
//ENDPOINT: İstek yapılan kaynak

//HTTP NASIL ÇALIŞIR 
//1-Tarayıcı adres çubuğuna bir web adresi yazarız.
//2-Dns sunucusuna bu alan adını gönderir.
//3-Dns sunucusu bu alan adını ip adresine çevirir.
//4-Tarayıcı bu ip adresine http isteği gönderir.
//5-Sunucu bu isteği alır ve işler.
//6-Sunucu bu isteğe bir cevap döner buna response denir.
//7-Tarayıcı bu cevabı alır ve ekranda gösterir.
//HTTP İSTEK YÖNTEMLERİ
//GET: Sunucudan veri almak için kullanılır.
//POST: Sunucuya veri göndermek için kullanılır.
//PUT: Sunucuda var olan bir veriyi güncellemek için kullanılır.
//DELETE: Sunucudan bir veriyi silmek için kullanılır.
//HEAD: Sunucudan sadece başlık bilgilerini almak için kullanılır.
//OPTIONS: Sunucunun desteklediği HTTP yöntemlerini öğrenmek için kullanılır.
//PATCH: Sunucuda var olan bir verinin bir kısmını güncellemek için kullanılır.
//TRACE: Sunucuya gönderilen isteğin aynısını geri döner.
//CONNECT: İki nokta arasında tünel oluşturmak için kullanılır.
//HTTP DURUM KODLARI
//1xx: Bilgi kodları
//2xx: Başarılı kodlar
//3xx: Yönlendirme kodları
//4xx: İstemci hatası kodları
//5xx: Sunucu hatası kodları
//Örnek HTTP Durum Kodları
//200: OK (Başarılı)
//201: Created (Oluşturuldu)
//204: No Content (İçerik Yok)
//301: Moved Permanently (Kalıcı Olarak Taşındı)
//302: Found (Bulundu)
//400: Bad Request (Kötü İstek)
//401: Unauthorized (Yetkisiz)
//403: Forbidden (Yasaklandı)
//404: Not Found (Bulunamadı)
//500: Internal Server Error (Dahili Sunucu Hatası)
//501: Not Implemented (Uygulanmadı)
//502: Bad Gateway (Kötü Ağ Geçidi)
//503: Service Unavailable (Hizmet Kullanılamıyor)
//HTTP BAŞLIKLARI
//HTTP başlıkları, istemci ve sunucu arasında iletilen ek bilgileri taşır.
//Bazı yaygın HTTP başlıkları şunlardır:
//Content-Type: İçeriğin türünü belirtir.
//Content-Length: İçeriğin uzunluğunu belirtir.
//User-Agent: İstemcinin türünü belirtir.
//Accept: İstemcinin kabul ettiği içerik türlerini belirtir
//Host: İstek yapılan sunucunun adını belirtir.
//Authorization: İstek için kimlik doğrulama bilgilerini taşır.
//Cache-Control: Önbellekleme politikalarını belirtir.

