using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.Bakery.FancyCake.Commands.DeleteFancyCake
{
    public class DeleteFancyCakeHandler : IRequestHandler<DeleteFancyCake, Unit>
    {
        private readonly IBakeryDbContext _dbContext;

        public DeleteFancyCakeHandler(IBakeryDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteFancyCake request, CancellationToken cancellationToken)
        {
            var fancyCake = await _dbContext.FancyCakes.FindAsync(new object[] {  request.ItemId }, cancellationToken);

            if (fancyCake is null || request.PersonId != fancyCake.PersonId)
            {
                throw new NotImplementedException();
            }

            _dbContext.FancyCakes.Remove(fancyCake);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
