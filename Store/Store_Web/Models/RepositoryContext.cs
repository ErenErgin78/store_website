using Microsoft.EntityFrameworkCore;

namespace Store_Web.Models
{
    public class RepositoryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        
    }
}