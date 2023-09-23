using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Orders.Commands.DeleteOrder
{
    public class DeleteOrderRequestHandler : IRequestHandler<DeleteOrderRequest, Unit>
    {
        private readonly IOrderDbContext _dbContext;

        public DeleteOrderRequestHandler(IOrderDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteOrderRequest request, CancellationToken cancellationToken)
        {
            var order = await _dbContext.Bookings.FindAsync(new object[] { request.OrderId }, cancellationToken);

            if (order is null || request.UserId != order.UserId)
            {
                throw new NotImplementedException();
            }

            _dbContext.Bookings.Remove(order);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
