using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.Bakery.RollCake.Commands.DeleteRollCake
{
    public class DeleteRollCakeHandler : IRequestHandler<DeleteRollCake, Unit>
    {
        private readonly IBakeryDbContext _dbContext;

        public DeleteRollCakeHandler(IBakeryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteRollCake request, CancellationToken cancellationToken)
        {
            var rollCake = await _dbContext.RollCakes.FindAsync(new object[] { request.ItemId }, cancellationToken);

            if (rollCake is null || request.PersonId != rollCake.PersonId) 
            {
                throw new NotImplementedException();
            }

                    _dbContext.RollCakes.Remove(rollCake);
            await   _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
