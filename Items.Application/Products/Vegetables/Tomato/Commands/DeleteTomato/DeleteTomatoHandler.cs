using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.Vegetables.Tomato.Commands.DeleteTomato
{
    public class DeleteTomatoHandler : IRequestHandler<DeleteTomato, Unit>
    {
        private readonly IVegetableDbContext _dbContext;

        public DeleteTomatoHandler(IVegetableDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteTomato request, CancellationToken cancellationToken)
        {
            var tomato = await _dbContext.Tomatoes.FindAsync(new object[] { request.ItemId }, cancellationToken);

            if (tomato is null || request.PersonId != tomato.PersonId)
            {
                throw new NotImplementedException();
            }

            _dbContext.Tomatoes.Remove(tomato);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
