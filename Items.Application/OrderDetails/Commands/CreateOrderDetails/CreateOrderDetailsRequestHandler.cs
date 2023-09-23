using Items.Application.Interfaces;
using Items.Domain.Components.Orders;
using MediatR;

namespace Items.Application.OrderDetails.Commands.CreateOrderDetails
{
    public class CreateOrderDetailsRequestHandler : IRequestHandler<CreateOrderDetailsRequest, Guid>
    {
        private readonly IBookingrDetailsDbContext _dbContext;

        public CreateOrderDetailsRequestHandler(IBookingrDetailsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateOrderDetailsRequest request, CancellationToken cancellationToken)
        {
            var orderDetails = new BookingDetails
            {
                OrderId = request.OderId,
                OrderPrice = request.OrderPrice,
                DispatchDate = request.DispatchDate,
                ReceivingDate = request.ReceivingDate
            };

            await _dbContext.BookingDetails.AddAsync(orderDetails, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return orderDetails.OrderId;
        }
    }
}
