using Items.Application.Interfaces;
using MediatR;
using SelfRollCake = Items.Domain.Products.FreshItem.Bakery.FactoryRollCake.RollCake;

namespace Items.Application.Products.Bakery.RollCake.Commands.CreateRollCake
{
    public class CreateRollCakeHandler : IRequestHandler<CreateRollCake, Guid>
    {
        private readonly IBakeryDbContext _dbContext;

        public CreateRollCakeHandler(IBakeryDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateRollCake request, CancellationToken cancellationToken)
        {
            var rollCake = new SelfRollCake
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
                Weight = null,
                CoolingMode = request.CoolingMode,
                IsFarmer = false
            };

            await _dbContext.RollCakes.AddAsync(rollCake, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return rollCake.ItemId;
        }
    }
}
