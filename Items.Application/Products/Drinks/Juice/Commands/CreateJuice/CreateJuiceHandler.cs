using Items.Application.Interfaces;
using Items.Domain.Products.FreshItem.Drinks.MakingJuice;
using MediatR;

namespace Items.Application.Products.Drinks.Juice.Commands.CreateJuice
{
    public class CreateJuiceHandler : IRequestHandler<CreateJuice, Guid>
    {
        private readonly IDrinkDbContext _dbContext;
        private MakeJuice _selfJuice;

        public CreateJuiceHandler(IDrinkDbContext dbContext, MakeJuice selfJuice) {
            _dbContext = dbContext;
            _selfJuice = selfJuice;
        }

        public async Task<Guid> Handle(CreateJuice request, CancellationToken cancellationToken)
        {
            _selfJuice = new(
                request.PersonId,
                request.ItemName,
                request.Price,
                request.ImagePath
            );

            var juice = _selfJuice.CreateJuice();

            await _dbContext.Juices.AddAsync(juice, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return juice.ItemId;
        }
    }
}
