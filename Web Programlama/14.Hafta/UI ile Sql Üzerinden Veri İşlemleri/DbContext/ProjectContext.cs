using System;
using System.Collections.Generic;
using FurOfTheWeak.Models;
using Microsoft.EntityFrameworkCore;

namespace FurOfTheWeak.DbContext;

public partial class ProjectContext : Microsoft.EntityFrameworkCore.DbContext
{
    public ProjectContext()
    {
    }

    public ProjectContext(DbContextOptions<ProjectContext> options)
        : base(options)
    {
    }

    public virtual DbSet<PostDatum> PostData { get; set; }

    public virtual DbSet<UserDatum> UserData { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=Project;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PostDatum>(entity =>
        {
            entity.HasKey(e => e.PostId).HasName("PK__PostData__AA1260380BC506F3");

            entity.Property(e => e.PostId).HasColumnName("PostID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.PostDate).HasColumnName("postDate");

            entity.HasOne(d => d.IdNavigation).WithMany(p => p.PostData)
                .HasForeignKey(d => d.Id)
                .HasConstraintName("FK_PostData_UserData");
        });

        modelBuilder.Entity<UserDatum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__UserData__3214EC272988FD6E");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Pass).HasMaxLength(50);
            entity.Property(e => e.Username).HasMaxLength(25);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
