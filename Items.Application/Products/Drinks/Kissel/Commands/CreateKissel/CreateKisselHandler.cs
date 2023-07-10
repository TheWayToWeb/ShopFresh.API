using Items.Application.Interfaces;
using Items.Domain.Models.Categories.Drinks.MakingKissel;
using MediatR;

namespace Items.Application.Products.Drinks.Kissel.Commands.CreateKissel
{
    public class CreateKisselHandler : IRequestHandler<CreateKissel, Guid>
    {
        private readonly IDrinkDbContext _dbContext;
        private MakeKissel _selfKissel;

        public CreateKisselHandler(IDrinkDbContext dbContext, MakeKissel selfKissel) {
            _dbContext = dbContext;
            _selfKissel = selfKissel;
        }

        public async Task<Guid> Handle(CreateKissel request, CancellationToken cancellationToken)
        {

            _selfKissel = new(
                request.PersonId,
                request.ItemName,
                request.Price,
                request.ImagePath
            );

            var kissel = _selfKissel.CreateKissel();

            await _dbContext.Kissel.AddAsync(kissel, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return kissel.ItemId;
        }
    }
}
