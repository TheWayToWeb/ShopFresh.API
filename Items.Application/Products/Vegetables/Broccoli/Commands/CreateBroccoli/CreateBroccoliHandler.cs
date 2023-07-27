using Items.Application.Interfaces;
using MediatR;
using SelfBroccoli = Items.Domain.Entities.Categories.Vegetables.ConcreteBroccoli.Broccoli.Broccoli;

namespace Items.Application.Products.Vegetables.Broccoli.Commands.CreateBroccoli
{
    public class CreateBroccoliHandler : IRequestHandler<CreateBroccoli, Guid>
    {
        private readonly IVegetableDbContext _dbContext;

        public CreateBroccoliHandler(IVegetableDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateBroccoli request, CancellationToken cancellationToken)
        {
            var broccoli = new SelfBroccoli
            {
                PersonId = request.PersonId,
                ItemId = Guid.NewGuid(),
                ItemName = request.ItemName,
                Price = request.Price,
                ImagePath = request.ImagePath,
                Maker = null,
                MinTemp = request.MinTemp,
                MaxTemp = request.MaxTemp,
                Protein = request.Protein,
                Fat = request.Fat,
                Sugar = request.Sugar,
                Energy = request.Energy,
                CountInPackage = request.CountInPackage,
                ProductExpiryDate = request.ProductExpiryDate,
                Weight = request.Weight,
                CoolingMode = request.CoolingMode,
                IsFarmer = false,
                Sort = request.Sort,
                IsSlicingShape = false
            };

            await _dbContext.Broccoli.AddAsync(broccoli, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return broccoli.ItemId;
        }
    }
}
