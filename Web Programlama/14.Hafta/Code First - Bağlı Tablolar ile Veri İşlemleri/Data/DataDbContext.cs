
using Code_First.Models;
using Microsoft.EntityFrameworkCore;
namespace Code_First.Data
{
    public class DataDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=CodeFirstDb;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
