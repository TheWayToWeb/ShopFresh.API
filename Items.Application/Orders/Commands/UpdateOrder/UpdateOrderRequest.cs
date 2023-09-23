using Items.Domain.Components.Items;
using MediatR;

namespace Items.Application.Orders.Commands.UpdateOrder
{
    public class UpdateOrderRequest : IRequest<Unit>
    {
        public Guid UserId { get; set; }
        public Guid OrderId { get; set; }
        public List<Item>? Items { get; set; }
    }
}
