using Items.Application.Interfaces;
using Items.Domain.Products.FreshItem.Drinks.MakingTea.MakingDryTea;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Products.Drinks.PackageTea.Commands.UpdatePackageTea
{
    public class UpdatePackageTeaHandler : IRequestHandler<UpdatePackageTea, Unit>
    {
        private readonly IDrinkDbContext _dbContext;
        private readonly MakePackageTea _selfPackageTea;

        public UpdatePackageTeaHandler(IDrinkDbContext dbContext) {
            _dbContext = dbContext;
            _selfPackageTea = new();
        }
        public async Task<Unit> Handle(UpdatePackageTea request, CancellationToken cancellationToken)
        {
            var packageTea = await _dbContext.DryTea.FirstOrDefaultAsync(item => item.ItemId == request.ItemId, cancellationToken);

            if (packageTea is null || request.PersonId != packageTea.PersonId) {
                throw new NotImplementedException();
            }

            _selfPackageTea.ItemName(request.ItemName);
            _selfPackageTea.Price(request.Price);
            _selfPackageTea.ImagePath(request.ImagePath);
            _selfPackageTea.Maker(request.Maker);
            _selfPackageTea.MinTemp(request.MinTemp);
            _selfPackageTea.MaxTemp(request.MaxTemp);
            _selfPackageTea.Protein(request.Protein);
            _selfPackageTea.Fat(request.Fat);
            _selfPackageTea.Sugar(request.Sugar);
            _selfPackageTea.Energy(request.Energy);
            _selfPackageTea.CountInPackage(request.CountInPackage);
            _selfPackageTea.CreatedDate(request.CreatedDate);
            _selfPackageTea.Taste(request.Tastes);
            _selfPackageTea.Capacity(request.Capacities);
            _selfPackageTea.IsChilled(request.IsChilled);
            _selfPackageTea.Grade(request.Grade);
            _selfPackageTea.KindOfTea(request.KindOfTea);
            _selfPackageTea.SashetCount(request.SashetCount);

            packageTea.ItemName =   _selfPackageTea.itemName;
            packageTea.Price =      _selfPackageTea.price;
            packageTea.ImagePath =  _selfPackageTea.imagePath;
            packageTea.Maker =      _selfPackageTea.maker;
            packageTea.MinTemp =    _selfPackageTea.minTemp;
            packageTea.MaxTemp =    _selfPackageTea.maxTemp;
            packageTea.Protein =    _selfPackageTea.protein;
            packageTea.Fat =        _selfPackageTea.fat;
            packageTea.Sugar =      _selfPackageTea.sugar;
            packageTea.Energy =     _selfPackageTea.energy;
            packageTea.CountInPackage = _selfPackageTea.countInPackage;
            packageTea.CreatedDate = _selfPackageTea.createdDate;
            packageTea.Tastes =     _selfPackageTea.tastes;
            packageTea.Capacities = _selfPackageTea.capacities;
            packageTea.IsChilled =  _selfPackageTea.isChilled;
            packageTea.Grade =      _selfPackageTea.grade;
            packageTea.KindOfTea =  _selfPackageTea.kindOfTea;
            packageTea.SachetCount = _selfPackageTea.sashetCount;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
