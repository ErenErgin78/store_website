using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(p => p.Category_Name).IsRequired();
            
            builder.HasData(
                new Category() { Category_Id = 1, Category_Name = "Electronic" },
                new Category() { Category_Id = 2, Category_Name = "Cosmetic" }
            );
        }
    }
}