using Items.Application.Interfaces;
using Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.FruitsVegetables.Vegetables;
using MediatR;

namespace Items.Application.Products.Vegetables.CreateCabbage
{
    public class CreateCabbageHandler : IRequestHandler<CreateCabbage, Guid>
    {
        private readonly IVegetableDbContext _dbContext;

        public CreateCabbageHandler(IVegetableDbContext dbContext) {
            _dbContext = dbContext;
        }
        public async Task<Guid> Handle(CreateCabbage request, CancellationToken cancellationToken)
        {
            var cabbage = new Сabbage
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
                CoolingMode= request.CoolingMode,
                Shape = request.Shape,
                Contain = request.Contain,
                Weight = request.Weight,
                Protein = request.Protein,
                Fat = request.Fat,
                Sugar = request.Sugar,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                BeforeDate = request.BeforeDate,
                ShortName = request.ShortName,
                Description = request.Description,
                Package = request.Package,
                Grade = request.Grade
            };

            await _dbContext.Сabbages.AddAsync(cabbage, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return cabbage.ItemId;
        }
    }
}
