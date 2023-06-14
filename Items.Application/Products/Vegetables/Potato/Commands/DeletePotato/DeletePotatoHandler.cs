using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.Vegetables.Potato.Commands.DeletePotato
{
    public class DeletePotatoHandler : IRequestHandler<DeletePotato, Unit>
    {
        private readonly IVegetableDbContext _dbContext;

        public DeletePotatoHandler(IVegetableDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeletePotato request, CancellationToken cancellationToken)
        {
            var potato = await _dbContext.Potatos.FindAsync(new object[] { request.ItemId }, cancellationToken);

            if (potato is null || request.PersonId != potato.PersonId)
            {
                throw new NotImplementedException();
            }

            _dbContext.Potatos.Remove(potato);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
