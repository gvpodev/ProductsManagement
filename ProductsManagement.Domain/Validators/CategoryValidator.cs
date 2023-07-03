using FluentValidation;
using ProductsManagement.Domain.Entities;

namespace ProductsManagement.Domain.Validators
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.Id)
                .NotEmpty()
                .WithMessage("The category ID is required.");

            RuleFor(c => c.Description)
                .NotEmpty()
                .WithMessage("The category description is required.")
                .MinimumLength(3)
                .WithMessage("The category description cannot be less than 3 characters.")
                .MaximumLength(256)
                .WithMessage("The category description cannot exceed 200 characters.");
        }
    }
}
