using AutoMapper;
using Items.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.ItemsFood.Queries.ItemFoodDetails
{
    public class ItemFoodDetailsQueryHandler : IRequestHandler<ItemFoodDetailsQuery, ItemFoodDetailsVm>
    {
        private readonly IItemFoodDbContext _dbContext;
        private readonly IMapper _mapper;

        public ItemFoodDetailsQueryHandler(IItemFoodDbContext dbContext,
            IMapper mapper) => (_dbContext, _mapper) = (dbContext, mapper);
        
        public async Task<ItemFoodDetailsVm> Handle(ItemFoodDetailsQuery request, CancellationToken cancellationToken)
        {
            var entity = await _dbContext.ItemFoods
                .FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken) ?? throw new NotImplementedException();

            return _mapper.Map<ItemFoodDetailsVm>(entity);
        }
    }
}
