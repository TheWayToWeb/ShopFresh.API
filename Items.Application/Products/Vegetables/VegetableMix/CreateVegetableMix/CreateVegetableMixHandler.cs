using Items.Application.Interfaces;
using MediatR;
using SelfVegetableMix = Items.Domain.Products.FreshItem.FruitsVegetables.Vegetables.VegetableMix;

namespace Items.Application.Products.Vegetables.VegetableMix.CreateVegetableMix
{
    public class CreateVegetableMixHandler : IRequestHandler<CreateVegetableMix, Guid>
    {
        private readonly IVegetableDbContext _dbContext;

        public CreateVegetableMixHandler(IVegetableDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateVegetableMix request, CancellationToken cancellationToken)
        {
            var vegetableMix = new SelfVegetableMix
            {
                PersonId = request.PersonId,
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                Price = request.Price,
                ImagePath = request.ImagePath,
                Maker = null,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Protein = request.Protein,
                Fat = request.Fat,
                Sugar = 0,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                ProductExpiryDate = request.ProductExpiryDate,
                Weight = request.Weight,
                CoolingMode = request.CoolingMode,
                IsFarmer = false,
                Vegetables = request.Vegetables
            };

            await _dbContext.VegetableMixes.AddAsync(vegetableMix, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return vegetableMix.ItemId;
        }
    }
}
