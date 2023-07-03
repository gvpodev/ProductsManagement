using ProductsManagement.Domain.Core;

namespace ProductsManagement.Domain.Contracts.Repositories;

public interface IBaseRepository<TEntity, TKey> : IDisposable
    where TEntity : class
{
    Task<List<TEntity>> FindAllAsync();
}