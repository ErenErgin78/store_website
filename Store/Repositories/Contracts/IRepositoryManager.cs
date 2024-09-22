namespace Repositories.Contracts
{
    public interface IRepositoryManager
    {
        IProductRepository ProductRepository { get; }
        ICategoryRepository categoryRepository{ get; }
        void Save();
    }
}