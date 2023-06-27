using Items.Application.Interfaces;
using MediatR;
using SelfDryTea = Items.Domain.Products.FreshItem.Drinks.MakingTea.MakingDryTea.DryTea;

namespace Items.Application.Products.Drinks.PackageTea.Commands.DryTea.Commands.CreateDryTea
{
    public class CreateDryTeaHandler : IRequestHandler<CreateDryTea, Guid>
    {
        private readonly IDrinkDbContext _dbContext;

        public CreateDryTeaHandler(IDrinkDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateDryTea request, CancellationToken cancellationToken)
        {
            var dryTea = new SelfDryTea
            {
                PersonId = Guid.NewGuid(),
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                BrandId = Guid.NewGuid(),
                Price = request.Price,
                ImagePath = request.ImagePath,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Protein = request.Protein,
                Fat = request.Fat,
                Sugar = request.Sugar,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                BeforeDate = request.BeforeDate,
                Sort = request.Sort,
                KindOfTea = request.KindOfTea,
                SachetCount = request.SachetCount
            };

            await _dbContext.DryTea.AddAsync(dryTea, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return dryTea.ItemId;
        }
    }
}
