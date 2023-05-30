using Items.Application.Interfaces;
using Items.Domain.Products.Category.SubCategory.FreshGroup;
using MediatR;

namespace Items.Application.Products.CreateFreshGroup
{
    public class CreateFreshGroupHandler : IRequestHandler<CreateFreshGroup, Guid>
    {
        private readonly IFruitDbContext _dbContext;

        public CreateFreshGroupHandler(IFruitDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateFreshGroup request, CancellationToken cancellationToken)
        {
            var freshGroup = new FreshGroup
            {
                FreshGroupId = Guid.NewGuid(),
                FreshGroupName = request.FreshGroupName,
                FreshItem = request.FreshItem
            };

            await _dbContext.SaveChangesAsync(cancellationToken);

            return freshGroup.FreshGroupId;
        }
    }
}
