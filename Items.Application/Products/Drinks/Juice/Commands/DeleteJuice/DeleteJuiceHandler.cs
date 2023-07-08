using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.Drinks.Juice.Commands.DeleteJuice
{
    public class DeleteJuiceHandler : IRequestHandler<DeleteJuice, Unit>
    {
        private readonly IDrinkDbContext _dbContext;

        public DeleteJuiceHandler(IDrinkDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteJuice request, CancellationToken cancellationToken)
        {
            var juice = await _dbContext.Juices.FindAsync(new object[] { request.ItemId }, cancellationToken);

            if (juice is null || request.PersonId != juice.PersonId) {
                throw new NotImplementedException();
            }

                    _dbContext.Juices.Remove(juice);
            await   _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
