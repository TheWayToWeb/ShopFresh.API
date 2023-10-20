using FluentValidation;

namespace Items.Domain.Components.Orders
{
    public class BookingDetailsValidator : AbstractValidator<BookingDetails>
    {
        public BookingDetailsValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.AddressId).NotNull();
            RuleFor(x => x.Address).NotNull();
            RuleFor(x => x.OrderId).NotNull();
            RuleFor(x => x.Order).NotNull();
        }
    }
}
