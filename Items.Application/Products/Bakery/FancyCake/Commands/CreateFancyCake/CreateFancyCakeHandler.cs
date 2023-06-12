using Items.Application.Interfaces;
using MediatR;
using SelfFancyCake = Items.Domain.Products.FreshItem.Bakery.FancyCake;

namespace Items.Application.Products.Bakery.FancyCake.Commands.CreateFancyCake
{
    public class CreateFancyCakeHandler : IRequestHandler<CreateFancyCake, Guid>
    {
        private readonly IBakeryDbContext _dbContext;

        public CreateFancyCakeHandler(IBakeryDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateFancyCake request, CancellationToken cancellationToken)
        {
            var fancyCake = new SelfFancyCake
            {
                PersonId = Guid.NewGuid(),
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                BrandId = Guid.NewGuid(),
                Price = request.Price,
                ImagePath = request.ImagePath,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Protein = request.Protein,
                Fat = request.Fat,
                Sugar = request.Sugar,
                Energy = request.Energy,
                BeforeDate = request.BeforeDate,
                ProductBakeryKind = request.ProductBakeryKind,
                CoolingMode = request.CoolingMode,
                ProductKindItSelf = request.ProductKindItSelf,
                ProductTypeItSelf = request.ProductTypeItSelf
            };

            await _dbContext.FancyCakes.AddAsync(fancyCake, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return fancyCake.ItemId;
        }
    }
}
