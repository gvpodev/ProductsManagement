using ProductsManagement.Application.Dtos.Responses;
using ProductsManagement.Application.Services.Contracts;
using ProductsManagement.Domain.Contracts.Services;
using ProductsManagement.Domain.Entities;

namespace ProductsManagement.Application.Services
{
    public class ProductAppService : IProductAppService
    {
        private readonly IProductDomainService? _productDomainService;

        public ProductAppService(IProductDomainService? productDomainService)
        {
            _productDomainService = productDomainService;
        }

        public List<ProductResponse> FindAll() => _productDomainService?.FindAll()
            .Select<Product, ProductResponse>(x => x).ToList();
    }
}
