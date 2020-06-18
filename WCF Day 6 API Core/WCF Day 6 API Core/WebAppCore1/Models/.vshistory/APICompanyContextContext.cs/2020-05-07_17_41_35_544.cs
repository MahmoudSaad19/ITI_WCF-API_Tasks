using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebAppCore1.Models
{
    public partial class APICompanyContextContext : DbContext
    {
        public APICompanyContextContext()
        {
        }

        public APICompanyContextContext(DbContextOptions<APICompanyContextContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Employees> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=.;Database=APICompanyContext;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departments>(entity =>
            {
                entity.HasKey(e => e.DeptId)
                    .HasName("PK_dbo.Departments");
            });

            modelBuilder.Entity<Employees>(entity =>
            {
                entity.HasIndex(e => e.DeptId)
                    .HasName("IX_DeptID");

                entity.Property(e => e.DeptId).HasColumnName("DeptID");

                entity.Property(e => e.Salary).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Dept)
                    .WithMany(p => p.Employees)
                    .HasForeignKey(d => d.DeptId)
                    .HasConstraintName("FK_dbo.Employees_dbo.Departments_DeptID");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
