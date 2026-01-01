using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.DbContext;

public partial class FurOfTheWeakContext : Microsoft.EntityFrameworkCore.DbContext
{
    public FurOfTheWeakContext()
    {
    }

    public FurOfTheWeakContext(DbContextOptions<FurOfTheWeakContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Departman> Departmen { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=FurOfTheWeak;Trusted_Connection=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Departman>(entity =>
        {
            entity.HasKey(e => e.DeptId).HasName("PK__Departma__0148818E4651DF56");

            entity.ToTable("Departman");

            entity.Property(e => e.DeptId).HasColumnName("DeptID");
            entity.Property(e => e.DeptName).HasMaxLength(100);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC27451250CD");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DeptId).HasColumnName("DeptID");
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.Username).HasMaxLength(50);

            entity.HasOne(d => d.Dept).WithMany(p => p.Users)
                .HasForeignKey(d => d.DeptId)
                .HasConstraintName("FK_USERS_DEPARTMAN");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
