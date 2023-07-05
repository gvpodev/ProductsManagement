using ProductsManagement.Domain.Contracts.Repositories;
using ProductsManagement.Domain.Contracts.Services;
using ProductsManagement.Domain.Entities;

namespace ProductsManagement.Domain.Services
{
    public class ProductDomainService : IProductDomainService
    {
        private readonly IUnitOfWork? _unitOfWork;

        public ProductDomainService(IUnitOfWork? unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Product> FindAll() => _unitOfWork?.ProductRepository.FindAll();

        public void Dispose() => _unitOfWork?.Dispose();
    }
}
