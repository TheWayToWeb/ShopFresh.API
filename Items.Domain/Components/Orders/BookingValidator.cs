using FluentValidation;

namespace Items.Domain.Components.Orders
{
    public class BookingValidator : AbstractValidator<Booking>
    {
        public BookingValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.Items).NotNull();
            RuleFor(x => x.AddressId).NotNull();
            RuleFor(x => x.Address).NotNull();
            RuleFor(x => x.UserId).NotNull();
            RuleFor(x => x.User).NotNull();
        }
    }
}
