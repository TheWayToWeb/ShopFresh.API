using Items.Application.Orders.Queries.OrderDetailsQuery;
using MediatR;

namespace Items.Application.Orders.Queries.OrderQuery
{
    public class OrderQuery : IRequest<OrderVm>
    {
        public Guid Id { get; set; }
    }
}
