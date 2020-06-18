using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace DB_CRUD_Service
{
    public partial class ProductContext : DbContext
    {
        public ProductContext()
            : base("name=ProductContext")
        {
        }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .Property(e => e.ProductName)
                .IsUnicode(false);
        }
    }
}
