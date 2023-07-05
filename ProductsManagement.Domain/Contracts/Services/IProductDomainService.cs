using ProductsManagement.Domain.Entities;

namespace ProductsManagement.Domain.Contracts.Services
{
    public interface IProductDomainService : IDisposable
    {
        List<Product> FindAll();
    }
}
