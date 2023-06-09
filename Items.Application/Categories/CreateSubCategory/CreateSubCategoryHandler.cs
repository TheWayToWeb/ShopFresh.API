using Items.Application.Interfaces;
using Items.Domain.Categories.SubCategory;
using MediatR;

namespace Items.Application.Categories.CreateSubCategory
{
    public class CreateSubCategoryHandler : IRequestHandler<CreateSubCategory, Guid>
    {
        public readonly IFruitDbContext _dbContext;

        public CreateSubCategoryHandler(IFruitDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateSubCategory request, CancellationToken cancellationToken)
        {
            var subCategory = new SubCategory
            {
                Id = Guid.NewGuid(),
                SubCategoryName = request.SubCategoryName,
                FreshGroups = request.FreshGroups
            };

            await _dbContext.SaveChangesAsync(cancellationToken);

            return subCategory.SubCategoryId;
        }
    }
}
