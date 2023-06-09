using Items.Application.Interfaces;
using Items.Domain.Brands;
using MediatR;

namespace Items.Application.Brands
{
    public class CreateBrandHandler : IRequestHandler<CreateBrand, Guid>
    {
        private readonly IProductDbContext _dbContext;

        public CreateBrandHandler(IProductDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateBrand request, CancellationToken cancellationToken)
        {
            var brand = new Brand
            {
                Id = Guid.NewGuid(),
                BrandName = request.BrandName
            };

            await _dbContext.Brands.AddAsync(brand, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return brand.Id;
        }
    }
}
