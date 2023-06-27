using Items.Application.Interfaces;
using MediatR;
using SelfFancyCake = Items.Domain.Products.FreshItem.Bakery.FactoryFancyCookie.FancyCake;

namespace Items.Application.Products.Bakery.FancyCake.Commands.CreateFancyCake
{
    public class CreateFancyCakeHandler : CreateFancyCake, IRequestHandler<CreateFancyCake, Guid>
    {
        private readonly IBakeryDbContext _dbContext;

        public CreateFancyCakeHandler(IBakeryDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateFancyCake request, CancellationToken cancellationToken)
        {
            var fancyCake = new SelfFancyCake
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
                Sugar = request.Sugar,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                ProductExpiryDate = request.ProductExpiryDate,
                ProductBakeryKind = request.ProductBakeryKind,
                Weight = request.Weight,
                CoolingMode = request.CoolingMode,
                IsFarmer = false,
                ProductKindItSelf = request.ProductKindItSelf,
                ProductTypeItSelf = request.ProductTypeItSelf
            };

            await _dbContext.FancyCakes.AddAsync(fancyCake, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return fancyCake.ItemId;
        }
    }
}
