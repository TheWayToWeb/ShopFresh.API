using FluentValidation;

namespace Items.Domain.Components.Categories
{
    public class ParentCategoryValidator : AbstractValidator<ParentCategory>
    {
        public ParentCategoryValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Name).NotNull();
            RuleFor(x => x.Categories).NotNull();
        }
    }
}
