using ProductsManagement.Domain.Entities;

namespace ProductsManagement.Application.Dtos.Responses
{
    public class ProductResponse
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public int? Quantity { get; set; }
        public Guid StockId { get; set; }
        public Guid CategoryId { get; set; }

        public static implicit operator ProductResponse(Product product)
        {
            return new ProductResponse
            {
                Id = product.Id,
                Name = product.Name,
                Description = product.Description,
                Price = product.Price,
                Quantity = product.Quantity,
                StockId = product.StockId,
                CategoryId = product.CategoryId
            };
        }
    }
}
