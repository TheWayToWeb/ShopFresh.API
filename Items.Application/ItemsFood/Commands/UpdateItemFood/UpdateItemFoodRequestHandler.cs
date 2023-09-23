using Items.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.ItemsFood.Commands.UpdateItemFood
{
    public class UpdateItemFoodRequestHandler : IRequestHandler<UpdateItemFoodRequest, Unit>
    {
        private readonly IItemFoodDbContext _dbContext;

        public UpdateItemFoodRequestHandler(IItemFoodDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateItemFoodRequest request, CancellationToken cancellationToken)
        {
            var itemFood = await _dbContext.ItemFoods.FirstOrDefaultAsync(item => item.Id == request.ItemId, cancellationToken) ?? throw new NotImplementedException();

            itemFood.BrandId = request.BrandId;
            itemFood.Price = request.Price;
            itemFood.ImagePath = request.ImagePath;
            itemFood.Maker = request.Maker;
            itemFood.CountInPackage = request.CountInPackage;
            itemFood.Weight = request.Weight;
            itemFood.Description = request.Description;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
