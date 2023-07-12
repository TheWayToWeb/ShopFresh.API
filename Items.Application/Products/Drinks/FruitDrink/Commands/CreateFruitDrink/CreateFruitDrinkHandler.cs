using Items.Application.Interfaces;
using MediatR;
using SelfFruitDrink = Items.Domain.Models.Categories.Drinks.ConcreteFruitDrink.FruitDrink.FruitDrink;

namespace Items.Application.Products.Drinks.FruitDrink.Commands.CreateFruitDrink
{
    public class CreateFruitDrinkHandler : IRequestHandler<CreateFruitDrink, Guid>
    {
        private readonly IDrinkDbContext _dbContext;

        public CreateFruitDrinkHandler(IDrinkDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateFruitDrink request, CancellationToken cancellationToken)
        {
            var fruitDrink = new SelfFruitDrink
            {
                PersonId = Guid.NewGuid(),
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                Price = request.Price,
                ImagePath = request.ImagePath,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Protein = request.Protein,
                Fat = request.Fat,
                Sugar = request.Sugar,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                BeforeDate = request.BeforeDate,
                Taste = request.Taste,
                Capacity = request.Capacity,
                IsChilled = request.IsChilled
            };

            await _dbContext.FruitDrink.AddAsync(fruitDrink, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return fruitDrink.ItemId;
        }
    }
}
