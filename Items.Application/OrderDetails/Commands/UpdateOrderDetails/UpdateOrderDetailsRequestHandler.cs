using Items.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.OrderDetails.Commands.UpdateOrderDetails
{
    public class UpdateOrderDetailsRequestHandler : IRequestHandler<UpdateOrderDetailsRequest, Unit>
    {
        private readonly IBookingrDetailsDbContext _dbContext;

        public UpdateOrderDetailsRequestHandler(IBookingrDetailsDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateOrderDetailsRequest request, CancellationToken cancellationToken)
        {
            var bookingDetails = await _dbContext.BookingDetails.FirstOrDefaultAsync(item => item.Id == request.OrderId, cancellationToken) ?? throw new NotImplementedException();

            bookingDetails.OrderPrice = request.OrderPrice;
            bookingDetails.DispatchDate = request.DispatchDate;
            bookingDetails.ReceivingDate = request.ReceivingDate;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
