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
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Weight = request.Weight,
                Capacities = null,
                Protein = request.Protein,
                Fat = request.Fat,
                Sugar = request.Sugar,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                BeforeDate = request.BeforeDate,
                ShortName = request.ShortName,
                Grade = request.Grade
            };

            await _dbContext.Сabbages.AddAsync(cabbage, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return cabbage.ItemId;
        }
    }
}
