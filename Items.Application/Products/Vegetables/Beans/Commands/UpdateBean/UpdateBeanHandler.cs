using Items.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Products.Vegetables.Beans.Commands.UpdateBean
{
    public class UpdateBeanHandler : IRequestHandler<UpdateBean, Unit>
    {
        private readonly IVegetableDbContext _dbContext;

        public UpdateBeanHandler(IVegetableDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateBean request, CancellationToken cancellationToken)
        {
            var bean = await _dbContext.Beans.FirstOrDefaultAsync(item => item.ItemId == request.ItemId, cancellationToken);

            if (bean is null || request.PersonId != bean.PersonId) {
                throw new NotImplementedException();
            }

            bean.ItemName = request.ItemName;
            bean.Price = request.Price;
            bean.ImagePath = request.ImagePath;
            bean.Maker = request.Maker;
            bean.MinTemp = request.MinTemp;
            bean.MaxTemp = request.MaxTemp;
            bean.Protein = request.Protein;
            bean.Fat = request.Fat;
            bean.Sugar = request.Sugar;
            bean.Energy = request.Energy;
            bean.CountInPackage = request.CountInPackage;
            bean.ProductExpiryDate = request.ProductExpiryDate;
            bean.Weight = request.Weight;
            bean.CoolingMode = request.CoolingMode;
            bean.IsFarmer = request.IsFarmer;
            bean.Sort = request.Sort;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
