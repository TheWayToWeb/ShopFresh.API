using FluentValidation;

namespace Items.Domain.Components.Feedback
{
    public class ReviewValidator : AbstractValidator<Review>
    {
        public ReviewValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Description).NotNull();
            RuleFor(x => x.UserId).NotNull();
            RuleFor(x => x.User).NotNull();
            RuleFor(x => x.ItemId).NotNull();
            RuleFor(x => x.Item).NotNull();
        }
    }
}
