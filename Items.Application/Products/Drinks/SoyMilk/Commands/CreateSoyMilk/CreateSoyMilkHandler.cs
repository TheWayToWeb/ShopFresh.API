using Items.Application.Interfaces;
using Items.Domain.Models.Categories.Drinks.MakingSoyMilk;
using MediatR;

namespace Items.Application.Products.Drinks.SoyMilk.Commands.CreateSoyMilk
{
    public class CreateSoyMilkHandler : IRequestHandler<CreateSoyMilk, Guid>
    {
        private readonly IDrinkDbContext _dbContext;
        private MakeSoyMilk _selfSoyMilk;

        public CreateSoyMilkHandler(IDrinkDbContext dbContext, MakeSoyMilk selfSoyMilk) {
            _dbContext = dbContext;
            _selfSoyMilk = selfSoyMilk;
        }

        public async Task<Guid> Handle(CreateSoyMilk request, CancellationToken cancellationToken)
        {
            _selfSoyMilk = new(
                request.PersonId,
                request.ItemName,
                request.Price,
                request.ImagePath
            );

            var soyMilk = _selfSoyMilk.CreateSoyMilk();
            
            await _dbContext.SoyMilk.AddAsync(soyMilk, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return soyMilk.ItemId;
        }
    }
}
