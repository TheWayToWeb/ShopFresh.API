using Items.Application.Interfaces;
using Items.Domain.Components.Items;
using MediatR;

namespace Items.Application.Items.Commands.CreateItem
{
    public class CreateItemFoodRequestHandler : IRequestHandler<CreateItemFoodRequest, Guid>
    {
        private readonly IItemFoodDbContext _dbContext;

        public CreateItemFoodRequestHandler(IItemFoodDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateItemFoodRequest request, CancellationToken cancellationToken)
        {
            var itemFood = new ItemFood
            {
                Id = request.ItemId,
                BrandId = request.BrandId,
                Price = request.Price,
                ImagePath = request.ImagePath,
                Maker = request.Maker,
                CountInPackage = request.CountInPackage,
                Weight = request.Weight,
                Description = request.Description
            };

            await _dbContext.ItemFoods.AddAsync(itemFood, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return itemFood.Id;
        }
    }
}
