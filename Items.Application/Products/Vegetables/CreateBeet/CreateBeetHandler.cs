using Items.Application.Interfaces;
using MediatR;

namespace Items.Application.Products.Vegetables.CreateBeet
{
    public class CreateBeetHandler : IRequestHandler<CreateBeet, Guid>
    {
        private readonly IVegetableDbContext _dbContext;

        public CreateBeetHandler(IVegetableDbContext dbContext) {
            _dbContext = dbContext;
        }

        public Task<Guid> Handle(CreateBeet request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
