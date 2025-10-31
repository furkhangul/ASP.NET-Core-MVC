MVC'de Controller kullanıcıdan gelen isteklere yanıt verir. Her Action ise bir HTTP yanıtı oluşturur.
Bu yanıt bir HTML sayfası, bir json sunucusu, yönlendirme, dosya, ya da hata kodu olabilir.

IActionResult bu parametrelerden biridir. IActionResult tüm dönüş tiplerinin atasıdır.
Yani IActionResult, bir HTTP isteği geldiğinde “Sonucu çalıştırmak” için bir mekanizmadır.

Bir action metodundan farklı tipte sonuçlar döndürdüğümüzde (örneğin View, JSON, Redirect), hepsi bu arayüzü uygular.
Framework ise arka planda hangi sınıfın döndüğüne bakmadan sonucu işler.
