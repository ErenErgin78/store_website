using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            //Eğer veri varsa çalışmaz. Veri yoksa bu ürünleri ekler
            //Migration -> Up methodunun içinde insert oluşturdu
            builder.Property(p => p.Product_Name).IsRequired();
            builder.Property(p => p.Product_Price).IsRequired();

            builder.HasData(
                new Product() { Product_Id = 1, Product_ImageUrl = "/images/1.jpg", Product_Name = "Computer", CategoryId = 1, Product_Price = 28_000 },
                new Product() { Product_Id = 2, Product_ImageUrl = "/images/2.jpeg", Product_Name = "Monitor", CategoryId = 1, Product_Price = 8_000 },
                new Product() { Product_Id = 3, Product_ImageUrl = "/images/3.jpg", Product_Name = "Mouse", CategoryId = 1, Product_Price = 3_000 },
                new Product() { Product_Id = 4, Product_ImageUrl = "/images/4.png", Product_Name = "Keyboard", CategoryId = 1, Product_Price = 4_000 },
                new Product() { Product_Id = 5, Product_ImageUrl = "/images/5.jpeg", Product_Name = "Sci-fi Book", CategoryId = 2, Product_Price = 300 },
                new Product() { Product_Id = 6, Product_ImageUrl = "/images/6.jpg", Product_Name = "History Book", CategoryId = 2, Product_Price = 400 }
            );
        }
    }
}