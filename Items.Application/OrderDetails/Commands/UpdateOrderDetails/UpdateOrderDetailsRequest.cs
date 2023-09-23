using MediatR;

namespace Items.Application.OrderDetails.Commands.UpdateOrderDetails
{
    public class UpdateOrderDetailsRequest : IRequest<Unit>
    {
        public Guid OrderId { get; set; }
        public float OrderPrice { get; set; }
        public DateTime DispatchDate { get; set; }
        public DateTime ReceivingDate { get; set; }
    }
}
