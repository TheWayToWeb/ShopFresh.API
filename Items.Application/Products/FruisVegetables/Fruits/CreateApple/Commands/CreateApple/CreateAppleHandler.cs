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
                Weight = request.Weight,
                Protein = request.Protein,
                Fat = request.Fat,
                Sugar = request.Sugar,
                CountInPackage = request.CountInPackage,
                BeforeDate = request.BeforeDate,
                ShortName = request.ShortName,
                CoolingMode = request.CoolingMode,
                Grade = request.Grade,
                SaleWeights = request.SaleWeights
            };

            await _dbContext.Apples.AddAsync(apple, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return apple.ItemId;
        }
    }
}
