using Entities.Models;

namespace Services.Contracts
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts(bool trackChanges);
        Product? GetProductById(int Id, bool trackChanges);
        void CreateProduct(Product product);
    }
}