using Items.Application.Interfaces;
using MediatR;
using SelfWater = Items.Domain.Products.FreshItem.Drinks.Water;

namespace Items.Application.Products.Drinks.Water.Commands.CreateWater
{
    public class CreateWaterHandler : IRequestHandler<CreateWater, Guid>
    {
        private readonly IDrinkDbContext _dbContext;

        public CreateWaterHandler(IDrinkDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateWater request, CancellationToken cancellationToken)
        {
            var water = new SelfWater
            {
                PersonId = Guid.NewGuid(),
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                BrandId = Guid.NewGuid(),
                Price = request.Price,
                ImagePath = request.ImagePath,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Protein = request.Protein,
                Sugar = request.Sugar,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                BeforeDate = request.BeforeDate,
                Capacity = request.Capacity,
                Taste = request.Taste,
                IsChilled = request.IsChilled,
                IsSparkling = request.IsSparkling,
                Purpose = request.Purpose
            };

            await _dbContext.Water.AddAsync(water, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return water.ItemId;
        }
    }
}
