using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace StoreApp.Models
{
    //Artık burası veri tabanı gibi oldu.
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Producuts { get; set; }
    }
}
