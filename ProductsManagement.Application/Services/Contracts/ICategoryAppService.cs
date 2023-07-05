using ProductsManagement.Application.Dtos.Responses;

namespace ProductsManagement.Application.Services
{
    public interface ICategoryAppService
    {
        List<CategoryResponse> FindAll();
    }
}
