using Items.Application.Interfaces;
using MediatR;
using SelfSaladMix = Items.Domain.Products.FreshItem.FruitsVegetables.Vegetables.SaladMix;

namespace Items.Application.Products.Vegetables.SaladMix.Commands.CreateSaladMix
{
    public class CreateSaladMixHandler : IRequestHandler<CreateSaladMix, Guid>
    {
        private readonly IVegetableDbContext _dbContext;

        public CreateSaladMixHandler(IVegetableDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateSaladMix request, CancellationToken cancellationToken)
        {
            var saladMix = new SelfSaladMix
            {
                PersonId = Guid.NewGuid(),
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                Price = request.Price,
                ImagePath = request.ImagePath,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Protein = request.Protein,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                ProductExpiryDate = request.ProductExpiryDate,
                Weight = request.Weight,
                GreeneryKinds = request.GreeneryKinds
            };

            await _dbContext.SaladMixes.AddAsync(saladMix, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return saladMix.ItemId;
        }
    }
}
