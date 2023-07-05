using ProductsManagement.Application.Dtos.Responses;

namespace ProductsManagement.Application.Services.Contracts
{
    public interface IProductAppService
    {
        List<ProductResponse> FindAll();
    }
}
