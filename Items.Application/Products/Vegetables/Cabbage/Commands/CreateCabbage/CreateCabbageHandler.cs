using Items.Application.Interfaces;
using Items.Domain.Products.FreshItem.FruitsVegetables.Vegetables;
using MediatR;

namespace Items.Application.Products.Vegetables.Cabbage.Commands.CreateCabbage
{
    public class CreateCabbageHandler : IRequestHandler<CreateCabbage, Guid>
    {
        private readonly IVegetableDbContext _dbContext;

        public CreateCabbageHandler(IVegetableDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Guid> Handle(CreateCabbage request, CancellationToken cancellationToken)
        {
            var cabbage = new Сabbage
            {
                PersonId = Guid.NewGuid(),
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                BrandId = Guid.NewGuid(),
                ImagePath = request.ImagePath,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Protein = request.Protein,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                ProductExpiryDate = request.ProductExpiryDate,
                Weight = request.Weight,
                Sort = request.Sort

            };

            await _dbContext.Сabbage.AddAsync(cabbage, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return cabbage.ItemId;
        }
    }
}
