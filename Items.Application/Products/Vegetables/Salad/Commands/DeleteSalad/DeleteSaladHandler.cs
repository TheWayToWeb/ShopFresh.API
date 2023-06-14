using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.Vegetables.Salad.Commands.DeleteSalad
{
    public class DeleteSaladHandler : IRequestHandler<DeleteSalad, Unit>
    {
        private readonly IVegetableDbContext _dbContext;

        public DeleteSaladHandler(IVegetableDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteSalad request, CancellationToken cancellationToken)
        {
            var salad = await _dbContext.Salads.FindAsync(new object[] { request.ItemId }, cancellationToken);

            if (salad is null || request.PersonId != salad.PersonId)
            {
                throw new NotImplementedException();
            }

            _dbContext.Salads.Remove(salad);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
