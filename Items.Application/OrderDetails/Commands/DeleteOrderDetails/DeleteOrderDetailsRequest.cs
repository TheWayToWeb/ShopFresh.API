using MediatR;

namespace Items.Application.OrderDetails.Commands.DeleteOrderDetails
{
    public class DeleteOrderDetailsRequest : IRequest<Unit>
    {
        public Guid OrderId { get; set; }
    }
}
