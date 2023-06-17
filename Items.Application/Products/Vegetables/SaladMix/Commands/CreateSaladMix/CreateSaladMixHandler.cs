using Items.Application.Interfaces;
using SelfSaladMix = Items.Domain.Products.FreshItem.FruitsVegetables.Vegetables.SaladMix;
using MediatR;

namespace Items.Application.Products.SaladMix.Commands.CreateSaladMix
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
                PersonId = request.PersonId,
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                Price = request.Price,
                ImagePath = request.ImagePath,
                Maker = null,
                MinTemp = request.MinTemp,
                MaxTemp = request.Maxtemp,
                Protein = request.Protein,
                Fat = 0,
                Sugar = 0,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                ProductExpiryDate = request.ProductExpiryDate,
                Weight = null,
                CoolingMode = request.CoolingMode,
                IsFarmer = false,
                Sort = null,
                IsSlicingShape = request.IsSlicingShape,
                GreeneryKinds = request.GreeneryKinds
            };

            await _dbContext.SaladMixes.AddAsync(saladMix, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return saladMix.ItemId;
        }
    }
}
