using FluentValidation;

namespace Items.Domain.Components.Discount
{
    public class DiscountValidator : AbstractValidator<Discount>
    {
        public DiscountValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.ItemId).NotNull();
            RuleFor(x => x.Item).NotNull();
        }
    }
}
