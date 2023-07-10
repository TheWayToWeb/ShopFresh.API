using Items.Application.Interfaces;
using Items.Domain.Models.Categories.Bakery.RollCake;
using MediatR;

namespace Items.Application.Products.Bakery.RollCake.Commands.CreateRollCake
{
    public class CreateRollCakeHandler : IRequestHandler<CreateRollCake, Guid>
    {
        private readonly IBakeryDbContext _dbContext;
        private MakeRollCake _selfRollCake;

        public CreateRollCakeHandler(IBakeryDbContext dbContext, MakeRollCake selfRollCake) {
            _dbContext = dbContext;
            _selfRollCake = selfRollCake;
        }

        public async Task<Guid> Handle(CreateRollCake request, CancellationToken cancellationToken)
        {
            _selfRollCake = new(
                request.PersonId,
                request.ItemName,
                request.Price,
                request.ImagePath
            );

            var rollCake = _selfRollCake.CreateRollCake();

            await _dbContext.RollCakes.AddAsync(rollCake);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return rollCake.ItemId;
        }
    }
}
