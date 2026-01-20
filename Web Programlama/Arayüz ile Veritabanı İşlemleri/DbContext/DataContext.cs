using Microsoft.EntityFrameworkCore;
using FurOfTheWeak.Models;
namespace FurOfTheWeak.DbContext
{
    public class UserDatum : Microsoft.EntityFrameworkCore.DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=FurOfTheWeak;Trusted_Connection=True; TrustServerCertificate=True");
        }

        public DbSet<Data> User { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Data>(entity =>
            {
                entity.ToTable("Users");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Username).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Name).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Surname).IsRequired().HasMaxLength(50);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Birthday).IsRequired();
                entity.Property(e => e.Password).IsRequired().HasMaxLength(100);
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
