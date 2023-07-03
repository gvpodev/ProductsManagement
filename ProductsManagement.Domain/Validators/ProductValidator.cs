using FluentValidation;
using ProductsManagement.Domain.Entities;

namespace ProductsManagement.Domain.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Id)
                .NotEmpty().WithMessage("The product ID is required.");

            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("The product name is required.")
                .MaximumLength(200).WithMessage("The product name cannot exceed 200 characters.");

            RuleFor(p => p.Price)
                .NotEmpty().WithMessage("The product price is required.")
                .GreaterThan(0).WithMessage("The product price must be greater than zero.");

            RuleFor(p => p.Quantity)
                .NotEmpty().WithMessage("The product quantity is required.")
                .GreaterThan(0).WithMessage("The product quantity must be greater than zero.");

            RuleFor(p => p.StockId)
                .NotEmpty().WithMessage("The stock ID is required.");
        }
    }
}
