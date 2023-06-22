using Items.Application.Interfaces;
using Items.Domain.Products.FreshItem.Bakery.FactoryRollCake;
using MediatR;

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
            MakeRollCake rollCake = new(request.PersonId);

            rollCake.SetItemName(request.ItemName!);
            rollCake.SetPrice(request.Price);
            rollCake.SetImagePath(request.ImagePath!);

            var actualRollCake = rollCake.CreateRollCake();

            await _dbContext.RollCakes.AddAsync(actualRollCake, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);


            return actualRollCake.ItemId;
        }
    }
}
