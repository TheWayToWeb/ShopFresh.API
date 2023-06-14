using Items.Application.Interfaces;
using Items.Domain.Products.FreshItem.Eggs;
using MediatR;

namespace Items.Application.Products.Eggs.Commands.CreateEggs
{
    public class CreateEggHandler : IRequestHandler<CreateEgg, Guid>
    {
        private readonly IMilkDbContext _dbContext;

        public CreateEggHandler(IMilkDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateEgg request, CancellationToken cancellationToken)
        {
            var egg = new Egg
            {
                PersonId = request.PersonId,
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                BrandId = Guid.NewGuid(),
                Price = request.Price,
                ImagePath = request.ImagePath,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Protein = request.Protein,
                Fat = request.Fat,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                ProductExpiryDate = request.ProductExpiryDate,
                Weight = request.Weight,
                CoolingMode = request.CoolingMode,
                Kind = request.Kind,
                IsFarmer = request.IsFarmer
            };

            await _dbContext.Eggs.AddAsync(egg, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return egg.ItemId;
        }
    }
}
