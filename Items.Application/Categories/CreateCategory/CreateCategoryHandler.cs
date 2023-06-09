using Items.Application.Interfaces;
using Items.Domain.Categories.Category;
using MediatR;

namespace Items.Application.Categories.CreateCategory
{
    public class CreateCategoryHandler : IRequestHandler<CreateCategory, Guid>
    {
        private readonly ICategoryDbContext _dbContext;

        public CreateCategoryHandler(ICategoryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateCategory request, CancellationToken cancellationToken)
        {
            var category = new Category
            {
                Id = Guid.NewGuid(),
                CategoryName = request.CategoryName,
                SubCategories = request.SubCategories
            };

            await _dbContext.Categories.AddAsync(category, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return category.Id;
        }
    }
}
