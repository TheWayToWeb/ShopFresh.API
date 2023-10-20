using AutoMapper;
using Items.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.OrderDetails.Queries.OrderDetailsQuery
{
    public class OrderDetailsQueryHandler : IRequestHandler<OrderDetailsQuery, OrderDetailsVm>
    {
        private readonly IOrderDetailsDbContext _dbContext;
        private readonly IMapper _mapper;

        public OrderDetailsQueryHandler(IOrderDetailsDbContext dbContext,
            IMapper mapper) => (_dbContext, _mapper) = (dbContext, mapper);

        public async Task<OrderDetailsVm> Handle(OrderDetailsQuery request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.BookingDetails
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken) ?? throw new NotImplementedException();

            return _mapper.Map<OrderDetailsVm>(entity);
        }
    }
}
