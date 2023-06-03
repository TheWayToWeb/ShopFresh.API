using Items.Application.Interfaces;
using Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.FruitsVegetables.Fruits;
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
                Brand = request.Brand,
                Price = request.Price,
                ImagePath = request.ImagePath,
                Maker = request.Maker,
                Storage = request.Storage,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                CoolingMode = request.CoolingMode,
                Shape = request.Shape,
                Contain = request.Contain,
                Weight = request.Weight,
                Capacities = null,
                Protein = request.Protein,
                Fat = request.Fat,
                Sugar = request.Sugar,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                BeforeDate = request.BeforeDate,
                ShortName = request.ShortName,
                Description = request.Description,
                Composition = request.Composition,
                Package = request.Package,
                Grade = request.Grade,
                SaleWeights = request.SaleWeights
            };

            await _dbContext.Bananas.AddAsync(banana, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return banana.ItemId;
        }
    }
}
