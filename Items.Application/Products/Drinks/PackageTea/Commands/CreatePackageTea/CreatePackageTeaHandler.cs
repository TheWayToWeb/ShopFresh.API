using Items.Application.Interfaces;
using Items.Domain.Products.FreshItem.Drinks.MakingTea.MakingDryTea;
using MediatR;

namespace Items.Application.Products.Drinks.PackageTea.Commands.DryTea.Commands.CreateDryTea
{
    public class CreatePackageTeaHandler : IRequestHandler<CreatePackageTea, Guid>
    {
        private readonly IDrinkDbContext _dbContext;
        private MakePackageTea _selfPackageTea;

        public CreatePackageTeaHandler(IDrinkDbContext dbContext, MakePackageTea selfPackageTea)
        {
            _dbContext = dbContext;
            _selfPackageTea = selfPackageTea;
        }

        public async Task<Guid> Handle(CreatePackageTea request, CancellationToken cancellationToken)
        {
            _selfPackageTea = new(
                request.PersonId,
                request.ItemName,
                request.Price,
                request.ImagePath
            );

            var packageTea = _selfPackageTea.CreateDryTea();

            await _dbContext.DryTea.AddAsync(packageTea, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return packageTea.ItemId;
        }
    }
}
