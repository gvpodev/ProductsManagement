using ProductsManagement.Domain.Contracts.Repositories;
using ProductsManagement.Domain.Contracts.Services;
using ProductsManagement.Domain.Entities;

namespace ProductsManagement.Domain.Services
{
    public class CategoryDomainService : ICategoryDomainService
    {
        private readonly IUnitOfWork? _unitOfWork;

        public CategoryDomainService(IUnitOfWork? unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public List<Category> FindAll() => _unitOfWork?.CategoryRepository.FindAll();

        public void Dispose() => _unitOfWork?.Dispose();
    }
}
