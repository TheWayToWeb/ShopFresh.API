using Items.Application.Interfaces;
using Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.FruitsVegetables.Fruits;
using MediatR;

namespace Items.Application.Products.Fruits.CreateExotic
{
    public class CreateExoticHandler : IRequestHandler<CreateExotic, Guid>
    {
        private readonly IFruitDbContext _dbContext;

        public CreateExoticHandler(IFruitDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateExotic request, CancellationToken cancellationToken)
        {
            var exotic = new Exotic
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
                Grade = request.Grade
            };

            await _dbContext.Exotics.AddAsync(exotic, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return exotic.ItemId;
        }
    }
}
