using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.OrderDetails.Commands.DeleteOrderDetails
{
    public class DeleteOrderDetailsRequestHandler : IRequestHandler<DeleteOrderDetailsRequest, Unit>
    {
        private readonly IBookingrDetailsDbContext _dbContext;

        public DeleteOrderDetailsRequestHandler(IBookingrDetailsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteOrderDetailsRequest request, CancellationToken cancellationToken)
        {
            var orderDetails = await _dbContext.BookingDetails.FindAsync(new object[] { request.OrderId }, cancellationToken) ?? throw new NotImplementedException();

            _dbContext.BookingDetails.Remove(orderDetails);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
