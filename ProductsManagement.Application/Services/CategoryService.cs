using ProductsManagement.Domain.Contracts.Repositories;
using ProductsManagement.Domain.Contracts.Services;
using ProductsManagement.Domain.Entities;

namespace ProductsManagement.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public async Task<List<Category>> FindAllAsync()
        {
            return await _categoryRepository.FindAllAsync();
        }
    }
}
