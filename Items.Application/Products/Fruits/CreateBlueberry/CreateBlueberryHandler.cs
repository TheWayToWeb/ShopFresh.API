using Items.Application.Interfaces;
using Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.FruitsVegetables.Fruits;
using MediatR;

namespace Items.Application.Products.Fruits.CreateBerry
{
    public class CreateBlueberryHandler : IRequestHandler<CreateBlueberry, Guid>
    {
        private readonly IFruitDbContext _dbContext;

        public CreateBlueberryHandler(IFruitDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateBlueberry request, CancellationToken cancellationToken)
        {
            var blueBerry = new Blueberry
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

            await _dbContext.Blueberries.AddAsync(blueBerry, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return blueBerry.ItemId;
        }
    }
}
