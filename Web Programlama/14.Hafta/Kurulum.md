Paket Yükleme:

      Öncelikle NuGet paket yükleme ekranına girip
        -Microsoft.Entity.FrameworkCore.SqlServer
        -Microsoft.Entity.FrameworkCore.SqlServer.Design ( İsteğe Bağlı )
        -Microsoft.Entity.FrameworkCore.Tools
      Bu 3 paketi indirmemiz gerekmektedir.

      Kurulumlar sağlandıktan hemen sonra yukarıdaki menüden "Package MAanger Console" yani paket yönetim 
      konsolunu açıp gerekli kodları girmemiz gerekiyyor.

Scaffold-DbContext "Server=.\SQLEXPRESS;Database=FurOfTheWeak;Trusted_Connection=True;TrustServerCertificate=True" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -ContextDir DbContext -Force

 


      Server = {} -> kısmı Microsoft SQL Server'daki yolu temsil ediyor. Yani hangi server üzerine işlem yapılacağını
      Database = {} -> ifadesi ise server içindeki hangi data üzerinden işlem göreceğini ifade ediyor.
      Trusted_Connection=True;TrustServerCertificate=True" -> Bu ifadeler ise sertifika izinleri gibi boş beleş şeyler.
      Microsoft.EntityFrameworkCore.SqlServer -> Bu ifade Entity frameworkün kullanılacağını ifade ediyor.
      -OutputDir Models -> ifadesi tablolardaki gelen özelliklerin projedeki hangi dosyaya karşılık geldiğini ifade ediyor.
      ContextDir DbContext -> İfadesi dosyada DbContext adında bir dbContext açıyor. 
      -Force -> terimi ise eğer zaten böyle bir dosyalar varsa projede güç kullanarak üzerine yazılmasını emrediyor.
