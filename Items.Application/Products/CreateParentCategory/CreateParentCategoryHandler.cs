using MediatR;
using Items.Domain.Products;
using Items.Application.Interfaces;

namespace Items.Application.Products.CreateProduct
{
    public class CreateParentCategoryHandler : IRequestHandler<CreateParentCategory.CreateParentCategory, Guid>
    {
        public readonly IFruitDbContext _dbContext;

        public CreateParentCategoryHandler(IFruitDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateParentCategory.CreateParentCategory request, CancellationToken cancellationToken)
        {
            var parentCategory = new ParentCategory
            {
                TitleId = Guid.NewGuid(),
                Title = request.Title,
                Category = request.Category
            };

            //
            await _dbContext.SaveChangesAsync(cancellationToken);
            
            return parentCategory.TitleId;
        }
    }
}
