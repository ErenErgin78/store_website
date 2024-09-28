using Entities.Models;
using Repositories.Contracts;

namespace Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(RepositoryContext context) : base(context)
        {
        }

        public void CreateProduct(Product product) => Create(product);

        public void DeleteProduct(Product product) => Remove(product);

        public IQueryable<Product> GetAllProducts(bool trackChanges) => FindAll(trackChanges);

        public Product? GetProductById(int id, bool trackChanges)
        {
            return FindByCondition(p => p.Product_Id.Equals(id), trackChanges);
        }

        public void UpdateProduct(Product entity) => Update(entity);
    }
}