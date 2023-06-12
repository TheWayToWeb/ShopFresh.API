using Items.Application.Interfaces;
using MediatR;
using SelfGingerBread = Items.Domain.Products.FreshItem.Bakery.Gingerbread;

namespace Items.Application.Products.Bakery.Gingerbread.Commands.CreateGingerbread
{
    public class CreateGingerBreadHandler : IRequestHandler<CreateGingerBread, Guid>
    {
        private readonly IBakeryDbContext _dbContext;

        public CreateGingerBreadHandler(IBakeryDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateGingerBread request, CancellationToken cancellationToken)
        {
            var gingerBread = new SelfGingerBread
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
                BeforeDate = request.BeforeDate,
                ProductBakeryKind = request.ProductBakeryKind,
                ProductKindItSelf = request.ProductKindItSelf
            };

            await _dbContext.Gingerbreads.AddAsync(gingerBread, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return gingerBread.ItemId;
        }
    }
}
