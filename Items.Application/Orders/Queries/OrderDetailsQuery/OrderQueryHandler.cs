using AutoMapper;
using Items.Application.Interfaces;
using Items.Application.Orders.Queries.OrderDetailsQuery;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Orders.Queries.OrderQuery
{
    public class OrderQueryHandler : IRequestHandler<OrderQuery, OrderVm>
    {
        private readonly IOrderDbContext _dbContext;
        private readonly IMapper _mapper;

        public OrderQueryHandler(IOrderDbContext dbContext,
            IMapper mapper) => (_dbContext, _mapper) = (dbContext, mapper);

        public async Task<OrderVm> Handle(OrderQuery request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.Bookings
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken) ?? throw new NotImplementedException();

            return _mapper.Map<OrderVm>(entity);
        }
    }
}
