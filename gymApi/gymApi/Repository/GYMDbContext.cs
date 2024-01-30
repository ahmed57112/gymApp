using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using gymApi.Models.Domain;

namespace gymApi.Repository;

public partial class GYMDbContext : DbContext
{
    public GYMDbContext()
    {
    }

    public GYMDbContext(DbContextOptions<GYMDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<MEMBER> MEMBERs { get; set; }

    public virtual DbSet<MEMBER_TYPES_LK> MEMBER_TYPES_LKs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source=DESKTOP-GFUAK89;initial catalog=GYM;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<MEMBER>(entity =>
        {
            entity.HasOne(d => d.MEMBER_TYPENavigation).WithMany(p => p.MEMBERs).HasConstraintName("FK_MEMBER_MEMBER_TYPES_LK");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
