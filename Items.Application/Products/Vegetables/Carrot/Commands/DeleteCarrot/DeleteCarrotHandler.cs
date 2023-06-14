using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.Vegetables.Carrot.Commands.DeleteCarrot
{
    public class DeleteCarrotHandler : IRequestHandler<DeleteCarrot, Unit>
    {
        private readonly IVegetableDbContext _dbContext;

        public DeleteCarrotHandler(IVegetableDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteCarrot request, CancellationToken cancellationToken)
        {
            var carrot = await _dbContext.Carrots.FindAsync(new object[] { request.ItemId }, cancellationToken);

            if (carrot is null || request.PersonId != carrot.PersonId)
            {
                throw new NotImplementedException();
            }

            _dbContext.Carrots.Remove(carrot);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
