Url.Action, bir controller içindeki action’a (yani bir metoda) giden URL adresini oluşturmak için kullanılır.
Url.Action() = Controller’daki bir metoda giden linki oluşturur.

Önce Action yazılır ardınanda Controller yazılır:
@Url.Action("ActionAdı", "ControllerAdı")


Örnek olacak olursa:
<a href="@Url.Action("About", "Home")">Hakkında</a>
Şeklinde olması gerekmektedir.

MVC yapısı gereği url oluştururken önce Controller daha sonra Action vermektedir. Yani Home/Index şeklinde vermektedir fakat biz bunu program.cs kodu üzerinde 
ayarlayabilmekteyiz. 

Program.cs dosyasında bulunan:
app.MapControllerRoute("main", "{controller=Home}/{action=Index}/{id?}");

ifadesinde görüldüğü üzere önce Controller ardından Action kullanılmış fakat biz Action ifadesini önce kullanmak istersek:
app.MapControllerRoute("main", "{action=Index}/{controller=Home}/{id?}");
şeklinde yazmamız gerekmektedir. Artık url olarak Index/Home şeklinde olacaktır. Bunun ile birlikte eskiden MVC yapısında bulunan sona gelen Index ifadesi gözükmez iken
artık Index/Home şeklinde olacağından Index ifadesi de url üzerine eklenmiş oldu.

