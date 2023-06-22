using Items.Application.Interfaces;
using Items.Domain.Products.FreshItem.Bakery.FactoryRollCake;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Products.Bakery.RollCake.Commands.UpdateRollCake
{
    public class UpdateRollCakeHandler : IRequestHandler<UpdateRollCake, Unit>
    {
        private readonly IBakeryDbContext _dbContext;

        public UpdateRollCakeHandler(IBakeryDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateRollCake request, CancellationToken cancellationToken)
        {
            var rollCake = await _dbContext.RollCakes.FirstOrDefaultAsync(item => item.ItemId == request.ItemId, cancellationToken);

            if (rollCake is null || request.PersonId != rollCake.PersonId)
            {
                throw new NotImplementedException();
            }

            MakeRollCake updateRollCake = new MakeRollCake();

            updateRollCake.SetItemName(request.ItemName!);
            updateRollCake.SetPrice(request.Price);
            updateRollCake.SetImagePath(request.ImagePath!);
            updateRollCake.SetMaker(request.Maker!);
            updateRollCake.SetMinTemp(request.MinTemp);
            updateRollCake.SetMaxTemp(request.MaxTemp);
            updateRollCake.SetProtein(request.Protein);
            updateRollCake.SetFat(request.Fat);
            updateRollCake.SetSugar(request.Sugar);
            updateRollCake.SetEnergy(request.Energy);
            updateRollCake.SetCountInPackage(request.CountInPackage);
            updateRollCake.SetProductExpiryDate(request.ProductExpiryDate);
            updateRollCake.SetWeight(request.Weight);
            updateRollCake.SetCoolingMode(request.CoolingMode!);

            rollCake.ItemName = updateRollCake.GatItemName();
            rollCake.Price = updateRollCake.GetPrice();
            rollCake.ImagePath = updateRollCake.GetImagePath();
            rollCake.Maker = updateRollCake.GetMaker();
            rollCake.MinTemp = updateRollCake.GetMinTemp();
            rollCake.MaxTemp = updateRollCake.GetMaxTemp();
            rollCake.Protein = updateRollCake.GetProtein();
            rollCake.Fat = updateRollCake.GetFat();
            rollCake.Sugar = updateRollCake.GetSugar();
            rollCake.Energy = updateRollCake.GetEnergy();
            rollCake.CountInPackage = updateRollCake.GetCountInPackage();
            rollCake.ProductExpiryDate = updateRollCake.GetProductExpiryDate();
            rollCake.Weight = updateRollCake.GetWeight();
            rollCake.CoolingMode = updateRollCake.GetCoolingMode();


            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
