using Items.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Products.Bakery.RollCake.Commands.UpdateRollCake
{
    public class UpdateRollCakeHandler : IRequestHandler<UpdateRollCake, Unit>
    {
        private readonly IBakeryDbContext _dbContext;

        public UpdateRollCakeHandler(IBakeryDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateRollCake request, CancellationToken cancellationToken)
        {
            var rollCake = await _dbContext.RollCakes.FirstOrDefaultAsync(item => item.ItemId == request.ItemId, cancellationToken);

            if (rollCake is null || request.PersonId != rollCake.PersonId)
            {
                throw new NotImplementedException();
            }

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
