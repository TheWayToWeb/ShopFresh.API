using Items.Domain.Components.Items;
using MediatR;

namespace Items.Application.Orders.Commands.CreateOrder
{
    public class CreateOrderRequest : IRequest<Guid>
    {
        public Guid UserId { get; set; }
        public Guid OrderId { get; set; }
        public IEnumerable<Item> Items { get; set; }
    }
}
