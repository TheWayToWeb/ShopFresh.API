using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.Drinks.PackageTea.Commands.DryTea.Commands.DeleteDryTea
{
    public class DeleteDryTeaHandler : IRequestHandler<DeleteDryTea, Unit>
    {
        private readonly IDrinkDbContext _dbContext;

        public DeleteDryTeaHandler(IDrinkDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteDryTea request, CancellationToken cancellationToken)
        {
            var dryTea = await _dbContext.DryTea.FindAsync(new object[] { request.ItemId }, cancellationToken);

            if (dryTea is null || request.PersonId != dryTea.PersonId) {
                throw new NotImplementedException();
            }

            _dbContext.DryTea.Remove(dryTea);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
