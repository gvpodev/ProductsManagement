using ProductsManagement.Application.Dtos.Responses;
using ProductsManagement.Domain.Contracts.Services;
using ProductsManagement.Domain.Entities;

namespace ProductsManagement.Application.Services
{
    public class CategoryAppService : ICategoryAppService
    {
        private readonly ICategoryDomainService _categoryDomainService;

        public CategoryAppService(ICategoryDomainService categoryDomainService)
        {
            _categoryDomainService = categoryDomainService;
        }

        public List<CategoryResponse> FindAll() => _categoryDomainService.FindAll()
            .Select<Category, CategoryResponse>(x => x).ToList();
    }
}
