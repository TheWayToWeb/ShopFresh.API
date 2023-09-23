using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.Vegetables.Beans.Commands.DeleteBeans
{
    public class DeleteBeanHandler : IRequestHandler<DeleteBean, Unit>
    {
        private readonly IVegetableDbContext _dbContext;

        public DeleteBeanHandler(IVegetableDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(DeleteBean request, CancellationToken cancellationToken)
        {
            var bean = await _dbContext.Beans.FindAsync(new object[] { request.Itemid }, cancellationToken);

            if (bean is null || request.PersonId != bean.PersonId)
            {
                throw new NotImplementedException();
            };

            _dbContext.Beans.Remove(bean);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
