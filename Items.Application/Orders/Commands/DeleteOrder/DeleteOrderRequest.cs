using MediatR;

namespace Items.Application.Orders.Commands.DeleteOrder
{
    public class DeleteOrderRequest : IRequest<Unit>
    {
        public Guid UserId { get; set; }
        public Guid OrderId { get; set; }
    }
}
