using ProductsManagement.Domain.Entities;

namespace ProductsManagement.Application.Dtos.Responses
{
    public class CategoryResponse
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }

        public static implicit operator CategoryResponse(Category category)
        {
            return new CategoryResponse { Id = category.Id, Description = category.Description };
        }
    }
}
