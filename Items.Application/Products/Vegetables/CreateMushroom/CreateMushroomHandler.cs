using Items.Application.Interfaces;
using MediatR;
using SelfMushroom = Items.Domain.Products.FreshItem.FruitsVegetables.Vegetables.Mushroom;

namespace Items.Application.Products.Vegetables.CreateMushroom
{
    public class CreateMushroomHandler : IRequestHandler<CreateMushroom, Guid>
    {
        private readonly IVegetableDbContext _dbContext;

        public CreateMushroomHandler(IVegetableDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateMushroom request, CancellationToken cancellationToken)
        {
            var mushroom = new SelfMushroom
            {
                PersonId = Guid.NewGuid(),
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                Price = request.Price,
                BrandId = Guid.NewGuid(),
                ImagePath = request.ImagePath,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Weight = request.Weight,
                Protein = request.Protein,
                Fat = request.Fat,
                Sugar = request.Sugar,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                BeforeDate = request.BeforeDate,
                Kind = request.Kind,
                SaleWeights = request.SaleWeights
            };

            await _dbContext.Mushrooms.AddAsync(mushroom, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return mushroom.ItemId;
        }
    }
}
