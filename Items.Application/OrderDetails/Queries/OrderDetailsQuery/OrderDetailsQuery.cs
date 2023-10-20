using MediatR;

namespace Items.Application.OrderDetails.Queries.OrderDetailsQuery
{
    public class OrderDetailsQuery : IRequest<OrderDetailsVm>
    {
        public Guid Id { get; set; }
    }
}
