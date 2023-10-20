using FluentValidation;

namespace Items.Domain.Components.Items
{
    public class ItemFoodValidator : AbstractValidator<ItemFood>
    {
        public ItemFoodValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Brand).NotNull();
            RuleFor(x => x.ImagePath).NotNull();
            RuleFor(x => x.Maker).NotNull();
            RuleFor(x => x.Maker).Length(0, 25);
            RuleFor(x => x.Description).NotNull();
        }
    }
}
