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

        public void CreateProduct(Product product)
        {
            _manager.ProductRepository.Create(product);
            _manager.Save();
        }

        public void DeleteProduct(int id)
        {
            var product = GetProductById(id, false);
            if (product is not null)
            {
                _manager.ProductRepository.DeleteProduct(product);
                _manager.Save();
            }
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

        public void UpdateProduct(Product product)
        {
            var entity = _manager.ProductRepository.GetProductById(product.Product_Id, true);
            entity.Product_Name = product.Product_Name;
            entity.Product_Price = product.Product_Price;
            _manager.Save();
        }
    }
}