using Items.Application.Interfaces;
using SelfBaguette = Items.Domain.Models.Categories.Bread.Baguette.Baguette;
using MediatR;

namespace Items.Application.Products.Bread.Baguette.CreateBaguette
{
    public class CreateBaguetteHandler : IRequestHandler<CreateBaguette, Guid>
    {
        private IBreadDbContext _dbContext;

        public CreateBaguetteHandler(IBreadDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateBaguette request, CancellationToken cancellationToken)
        {
            var baguette = new SelfBaguette
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
                CoolingMode = null,
                IsFarmer = false
            };
        }
    }
}
