using Microsoft.EntityFrameworkCore;
using Entities.Models;

namespace Repositories
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Eğer veri varsa çalışmaz. Veri yoksa bu ürünleri ekler
            //Migration -> Up methodunun içinde insert oluşturdu
            modelBuilder.Entity<Product>().HasData(
                new Product() { Product_Id = 1, Product_Name = "Computer", Product_Price = 28_000 },
                new Product() { Product_Id = 2, Product_Name = "Monitor", Product_Price = 8_000 },
                new Product() { Product_Id = 3, Product_Name = "Mouse", Product_Price = 3_000 },
                new Product() { Product_Id = 4, Product_Name = "Keyboard", Product_Price = 4_000 },
                new Product() { Product_Id = 5, Product_Name = "MousePad", Product_Price = 200 }
                );
        }
    }
}

