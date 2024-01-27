using FluentValidation;
using FluentValidation.Internal;

namespace ExampleCore2.Models.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.id).NotEmpty().WithMessage("Boş Geçmeeee1234");
        }
    }
}
