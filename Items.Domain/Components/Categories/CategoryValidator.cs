using FluentValidation;

namespace Items.Domain.Components.Categories
{
    public class CategoryValidator :AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.CategoryName).NotNull();
        }
    }
}
