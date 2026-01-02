using Microsoft.EntityFrameworkCore;
using Code_First.Models;
namespace Context
{
    public class CompayContext : DbContext
    {


        //Protected = Yalnızca bu sınıftan türeyen sınıflar tarafından kullanılabiliyor anlamına geliyor.
        //Override = Override ile DbContexte bulunan OnConfiguring methodunu ezip kendimiz özelleştiriyoruz.
        //Void = geri dönüş değeri üretmez.
        //OnConfiguring = DbContext yapılandırmasını sağlayan method olup.ConnectionString gibi ayarlar buradan yapılıyor.
        //DbContextOptionsBuilder optionsBuilder = EF Core ayarlarının tutulduğu nesne. Veritabanının tüm verileri burada saklanır.
        //base : üst sınıfı yani DbContext sınıfnı temsil eder
        //base.OnConfiguring = DbContextin varsayılan yapılandırmasını sağlar. Zorunlu değildir ama pratiktir.
        //UseSqlServer = EF Core a sql kullanılacağını bildiren komut.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=CompanyDb;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}

//Ardından NuGet Package Manager ile migration komutu yazmaya başlayacaz
//"add-migration initialCreate" komutu ile dosya yönetim panelimize şu ana kadar yaptığımız tüm Migrations ismindeki klasörleri otomatik bir şekilde oluşmaktadır.

//Hemen ardından "update-database" komutu ile bu klasörlerdeki tabloları datamıza atıyoruz.

//Eğer veritabanında güncelleme yapacak olursak "add-migration {migration_Adı} update-database" komutu ile güncelleme gerçekleştirebiliyoruz.