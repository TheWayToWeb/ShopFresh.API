using Items.Application.Interfaces;
using MediatR;
using SelfRollCake = Items.Domain.Products.FreshItem.Bakery.RollCake;

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
                CoolingMode = request.CoolingMode
            };

            await _dbContext.RollCakes.AddAsync(rollCake, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return rollCake.ItemId;
        }
    }
}
