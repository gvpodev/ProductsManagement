using ProductsManagement.Domain.Entities;

namespace ProductsManagement.Domain.Contracts.Repositories
{
    public interface IProductRepository : IBaseRepository<Product, Guid>
    {
    }
}
