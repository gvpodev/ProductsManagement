namespace ProductsManagement.Domain.Contracts.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository CategoryRepository { get; }
        IStockRepository StockRepository { get; }
        IProductRepository ProductRepository { get; }

        void SaveChanges();
    }
}
