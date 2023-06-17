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
                PersonId = request.PersonId,
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                BrandId = Guid.NewGuid(),
                ImagePath = request.ImagePath,
                Maker = null,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Protein = request.Protein,
                Fat = 0,
                Sugar = 0,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                ProductExpiryDate = request.ProductExpiryDate,
                Weight = request.Weight,
                CoolingMode = null,
                IsFarmer = false,
                Sort = request.Sort,
                IsSlicingShape = false
            };

            await _dbContext.Сabbage.AddAsync(cabbage, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return cabbage.ItemId;
        }
    }
}
