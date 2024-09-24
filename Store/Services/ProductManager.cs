using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;

namespace Services
{
    public class ProductManager : IProductService
    {
        private readonly IRepositoryManager _manager;

        public ProductManager(IRepositoryManager manager)
        {
            _manager = manager;
        }
        public IEnumerable<Product> GetAllProducts(bool trackChanges)
        {
            return _manager.ProductRepository.GetAllProducts(trackChanges);
        }

        public Product? GetProductById(int Id, bool trackChanges)
        {
            var product = _manager.ProductRepository.GetProductById(Id, trackChanges);

            if (product == null) throw new Exception("Product Not Found");

            return product;
        }
    }
}