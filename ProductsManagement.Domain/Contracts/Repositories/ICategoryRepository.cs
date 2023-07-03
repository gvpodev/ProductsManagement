using ProductsManagement.Domain.Entities;

namespace ProductsManagement.Domain.Contracts.Repositories
{
    public interface ICategoryRepository : IBaseRepository<Category, Guid>
    {
    }
}
