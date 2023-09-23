using Items.Domain.Components.Items;
using Items.Domain.Components.Orders.Common;
using Items.Domain.Components.Orders;
using MediatR;

namespace Items.Application.OrderDetails.Commands.CreateOrderDetails
{
    public class CreateOrderDetailsRequest : IRequest<Guid>
    {
        public Guid OderId { get; set; }
        public float OrderPrice { get; set; }
        public DateTime DispatchDate { get; set; }
        public DateTime ReceivingDate { get; set; }
    }
}
