using Items.Application.Interfaces;
using Items.Domain.Categories.FreshGroup;
using MediatR;

namespace Items.Application.Categories.CreateFreshGroup
{
    public class CreateFreshGroupHandler : IRequestHandler<CreateFreshGroup, Guid>
    {
        private readonly IFruitDbContext _dbContext;

        public CreateFreshGroupHandler(IFruitDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateFreshGroup request, CancellationToken cancellationToken)
        {
            var freshGroup = new FreshGroup
            {
                FreshGroupId = Guid.NewGuid(),
                FreshGroupName = request.FreshGroupName,
                FreshItems = request.FreshItems
            };

            await _dbContext.SaveChangesAsync(cancellationToken);

            return freshGroup.FreshGroupId;
        }
    }
}
