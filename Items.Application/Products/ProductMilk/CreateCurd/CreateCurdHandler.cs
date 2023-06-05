using Items.Application.Interfaces;
using Items.Domain.Products.FreshItem.MilkProducts;
using MediatR;

namespace Items.Application.Products.ProductMilk.CreateCurd
{
    public class CreateCurdHandler : IRequestHandler<CreateCurd, Guid>
    {
        private readonly IMilkDbContext _dbContext;

        public CreateCurdHandler(IMilkDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateCurd request, CancellationToken cancellationToken)
        {
            var curd = new Curd
            {
                PersonId = Guid.NewGuid(),
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                BrandId = Guid.NewGuid(),
                Price = request.Price,
                ImagePath = request.ImagePath,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Weight = request.Weight,
                Protein = request.Protein,
                Fat = request.Fat,
                Sugar = request.Sugar,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                BeforeDate = request.BeforeDate,
                IsLactoseFree = request.IslactoseFree,
                IsFarmer = request.IsFarmer,
                IsBestseller = request.IsBestseller,
                IsVegan = request.IsVegan,
                Taste = request.Taste,
                KindCurd = request.KindCurd,
                FatContent = request.FatContent
            };

            await _dbContext.Curds.AddAsync(curd, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return curd.ItemId;
        }
    }
}
