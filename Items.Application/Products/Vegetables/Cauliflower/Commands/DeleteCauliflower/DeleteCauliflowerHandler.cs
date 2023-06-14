using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.Vegetables.Cauliflower.Commands.DeleteCauliflower
{
    public class DeleteCauliflowerHandler : IRequestHandler<DeleteCauliflower, Unit>
    {
        private readonly IVegetableDbContext _dbContext;

        public DeleteCauliflowerHandler(IVegetableDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteCauliflower request, CancellationToken cancellationToken)
        {
            var cauliflower = await _dbContext.Cauliflowers.FindAsync(new object[] { request.ItemId }, cancellationToken);

            if (cauliflower is null || request.PersonId != cauliflower.PersonId)
            {
                throw new NotImplementedException();
            }

            _dbContext.Cauliflowers.Remove(cauliflower);

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
