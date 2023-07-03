using ProductsManagement.Domain.Entities;

namespace ProductsManagement.Domain.Contracts.Services
{
    public interface ICategoryService
    {
        Task<List<Category>> FindAllAsync();
    }
}
