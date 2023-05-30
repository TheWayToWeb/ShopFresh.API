using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.CreateCategory
{
    public class CreateCategoryHandler : IRequestHandler<CreateCategory, Guid>
    {
        public readonly IFruitDbContext _dbContext;

        public CreateCategoryHandler(IFruitDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateCategory request, CancellationToken cancellationToken)
        {
            var createCategory = new CreateCategory
            {
                CategoryId = Guid.NewGuid(),
                CategoryName = request.CategoryName,
                SubCategory = request.SubCategory
            };

            await _dbContext.SaveChangesAsync(cancellationToken);

            return createCategory.CategoryId;
        }
    }
}
