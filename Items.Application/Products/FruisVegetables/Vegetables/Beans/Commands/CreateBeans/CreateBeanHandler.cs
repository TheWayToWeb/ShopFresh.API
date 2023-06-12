using Items.Application.Interfaces;
using MediatR;
using SelfBean = Items.Domain.Products.FreshItem.FruitsVegetables.Vegetables.Bean;

namespace Items.Application.Products.FruisVegetables.Vegetables.Beans.Commands.CreateBeans
{
    public class CreateBeanHandler : IRequestHandler<CreateBean, Guid>
    {
        private readonly IVegetableDbContext _dbContext;

        public CreateBeanHandler(IVegetableDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateBean request, CancellationToken cancellationToken)
        {
            var bean = new SelfBean
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
                CoolingMode = request.CoolingMode
            };

            await _dbContext.Beans.AddAsync(bean, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return bean.ItemId;
        }
    }
}
