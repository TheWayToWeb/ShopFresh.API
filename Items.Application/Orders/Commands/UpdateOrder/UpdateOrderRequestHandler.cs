using Items.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Orders.Commands.UpdateOrder
{
    public class UpdateOrderRequestHandler : IRequestHandler<UpdateOrderRequest, Unit>
    {
        private readonly IOrderDbContext _dbContext;

        public UpdateOrderRequestHandler(IOrderDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateOrderRequest request, CancellationToken cancellationToken)
        {
            var order = await _dbContext.Bookings.FirstOrDefaultAsync(item => item.Id == request.OrderId, cancellationToken);

            if (order is null || request.UserId != order.UserId)
            {
                throw new NotImplementedException();
            }

            order.UserId = request.UserId;
            order.Id = request.OrderId;
            order.Items = request.Items;

            return Unit.Value;
        }
    }
}
