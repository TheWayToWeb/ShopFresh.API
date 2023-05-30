using Items.Application.Interfaces;
using Items.Domain.Products.Category.SubCategory;
using MediatR;

namespace Items.Application.Products.CreateSubCategory
{
    public class CreateSubCategoryHandler : IRequestHandler<CreateSubCategory, Guid>
    {
        public readonly IFruitDbContext _dbContext;

        public CreateSubCategoryHandler(IFruitDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateSubCategory request, CancellationToken cancellationToken)
        {
            var subCategory = new SubCategory
            {
                SubCategoryId = Guid.NewGuid(),
                SubCategoryName = request.SubCategoryName,
                FreshGroup = request.FreshGroup
            };

            await _dbContext.SaveChangesAsync(cancellationToken);

            return subCategory.SubCategoryId;
        }
    }
}
