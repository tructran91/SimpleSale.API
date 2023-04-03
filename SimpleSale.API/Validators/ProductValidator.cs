using FluentValidation;
using SimpleSale.API.Models.Products;

namespace SimpleSale.API.Validators
{
    public class ProductValidator : AbstractValidator<ProductCriteriaViewModel>
    {
        public ProductValidator()
        {
            var supportedColumns = new List<string> { "Name" };

            RuleFor(x => x.SortColumn)
                .Must(x => supportedColumns.Contains(x)).When(x => !string.IsNullOrEmpty(x.SortColumn))
                .WithMessage("{PropertyName} doesn't support searching.");
        }
    }
}
