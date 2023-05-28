using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DatabaseFirst.Models;

public partial class DevDbContext : DbContext
{
    public DevDbContext()
    {
    }

    public DevDbContext(DbContextOptions<DevDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<TCoreUser> TCoreUsers { get; set; }

    public virtual DbSet<TRevaultoTestingTable> TRevaultoTestingTables { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=AXBLR-751\\SQLEXPRESS;Initial Catalog=DevDB;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<TCoreUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("t_Core_User");

            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        modelBuilder.Entity<TRevaultoTestingTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("t_Revaulto_Testing_Table");

            entity.Property(e => e.CIsDeleted)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("cIsDeleted");
            entity.Property(e => e.DtCreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("dtCreatedOn");
            entity.Property(e => e.DtModifiedOn)
                .HasColumnType("datetime")
                .HasColumnName("dtModifiedOn");
            entity.Property(e => e.UTestingId).HasColumnName("uTestingId");
            entity.Property(e => e.VParameters).HasColumnName("vParameters");
            entity.Property(e => e.VTestNumber).HasColumnName("vTestNumber");
            entity.Property(e => e.VTestingName)
                .HasMaxLength(250)
                .HasColumnName("vTestingName");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Address)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
