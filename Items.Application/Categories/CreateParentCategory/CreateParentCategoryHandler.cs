using MediatR;
using Items.Application.Interfaces;
using Items.Domain.Categories.ParentCategory;

namespace Items.Application.Categories.CreateParentCategory
{
    public class CreateParentCategoryHandler : IRequestHandler<CreateParentCategory, Guid>
    {
        private readonly ICategoryDbContext _dbContext;

        public CreateParentCategoryHandler(ICategoryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateParentCategory request, CancellationToken cancellationToken)
        {
            var parentCategory = new ParentCategory
            {
                TitleId = Guid.NewGuid(),
                Title = request.Title,
                Category = request.Category
            };

            await _dbContext.ParentCategories.AddAsync(parentCategory, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return parentCategory.TitleId;
        }
    }
}
