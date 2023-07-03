using FluentValidation;
using ProductsManagement.Domain.Entities;

namespace ProductsManagement.Domain.Validators
{
    public class StockValidator : AbstractValidator<Stock>
    {
        public StockValidator()
        {
            RuleFor(s => s.Id)
                .NotEmpty().WithMessage("The stock ID is required.");

            RuleFor(s => s.Name)
                .NotEmpty().WithMessage("The stock name is required.")
                .MinimumLength(3).WithMessage("The stock name cannot be less than 3 characters.")
                .MaximumLength(256).WithMessage("The stock creation date cannot be in the future.");

            RuleFor(s => s.CreationDate)
                .NotEmpty().WithMessage("The stock creation date is required.")
                .LessThanOrEqualTo(DateTime.UtcNow).WithMessage("The stock creation date cannot be in the future.");
        }
    }
}
