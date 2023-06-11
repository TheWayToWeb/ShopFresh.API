using Items.Application.Interfaces;
using Items.Domain.Products.FreshItem.FruitsVegetables.Fruits;
using MediatR;

namespace Items.Application.Products.FruisVegetables.Fruits.CreateApple.Commands.CreateApple
{
    public class CreateAppleHandler : IRequestHandler<CreateApple, Guid>
    {
        private readonly IFruitDbContext _dbContext;

        public CreateAppleHandler(IFruitDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateApple request, CancellationToken cancellationToken)
        {

            var apple = new Apple
            {
                PersonId = Guid.NewGuid(),
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                Price = request.Price,
                BrandId = Guid.NewGuid(),
                ImagePath = request.ImagePath,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Protein = request.Protein,
                Fat = request.Fat,
                Sugar = request.Sugar,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                BeforeDate = request.BeforeDate,
                Weight = request.Weight,
                CoolingMode = request.CoolingMode,
                IsFarmer = request.IsFarmer,
                ShortName = request.ShortName,
                Shape = request.Shape,
                SaleWeights = request.SaleWeights
            };

            await _dbContext.Apples.AddAsync(apple, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return apple.ItemId;
        }
    }
}
