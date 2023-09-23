using Items.Application.Interfaces;
using Items.Domain.Components.Orders;
using MediatR;

namespace Items.Application.Orders.Commands.CreateOrder
{
    public class CreateOrderRequestHandler : IRequestHandler<CreateOrderRequest, Guid>
    {
        private readonly IOrderDbContext _dbContext;

        public CreateOrderRequestHandler(IOrderDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateOrderRequest request, CancellationToken cancellationToken)
        {
            var order = new Booking
            {
                UserId = request.UserId,
                Id = request.OrderId,
                Items = request.Items
            };

            await _dbContext.Bookings.AddAsync(order, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return order.Id;
        }
    }
}
