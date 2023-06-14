using Items.Application.Interfaces;
using Items.Domain.Products.FreshItem.FruitsVegetables.Fruits;
using MediatR;

namespace Items.Application.Products.Fruits.CreateBanana
{
    public class CreateBananaHandler : IRequestHandler<CreateBanana, Guid>
    {
        private readonly IFruitDbContext _dbContext;

        public CreateBananaHandler(IFruitDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateBanana request, CancellationToken cancellationToken)
        {
            var banana = new Banana
            {
                PersonId = Guid.NewGuid(),
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                BrandId = Guid.NewGuid(),
                Price = request.Price,
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
                ShortName = request.ShortName,
                Grade = request.Grade,
                SaleWeights = request.SaleWeights
            };

            await _dbContext.Bananas.AddAsync(banana, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return banana.ItemId;
        }
    }
}
