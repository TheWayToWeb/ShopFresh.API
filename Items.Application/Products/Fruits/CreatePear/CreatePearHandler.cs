using Items.Application.Interfaces;
using Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.FruitsVegetables.Fruits;
using MediatR;

namespace Items.Application.Products.Fruits.CreatePear
{
    public class CreatePearHandler : IRequestHandler<CreatePear, Guid>
    {
        private readonly IFruitDbContext _dbContext;

        public CreatePearHandler(IFruitDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreatePear request, CancellationToken cancellationToken)
        {
            var pear = new Pear
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

            await _dbContext.Pears.AddAsync(pear, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return pear.ItemId;
        }
    }
}
