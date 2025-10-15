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
