using Entities.Dtos;
using Entities.Models;

namespace Services.Contracts
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllProducts(bool trackChanges);
        Product? GetProductById(int Id, bool trackChanges);
        void CreateProduct(ProductDtoForInsertion productDto);
        void UpdateProduct(ProductDtoForUpdate productDto);
        void DeleteProduct(int id);
        ProductDtoForUpdate GetProductForUpdate(int id, bool trackChanges);
    }
}