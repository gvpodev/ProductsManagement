using ProductsManagement.Domain.Entities;

namespace ProductsManagement.Domain.Contracts.Services
{
    public interface ICategoryDomainService : IDisposable
    {
        List<Category> FindAll();
    }
}
