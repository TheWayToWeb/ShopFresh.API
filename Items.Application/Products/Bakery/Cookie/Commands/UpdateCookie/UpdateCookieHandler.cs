using Items.Application.Interfaces;
using Items.Domain.Components.Entities.Bakery.Cookie;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Products.Bakery.Cookie.Commands.UpdateCookie
{
    public class UpdateCookieHandler : IRequestHandler<UpdateCookie, Unit>
    {
        private readonly IBakeryDbContext _dbContext;

        public UpdateCookieHandler(IBakeryDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateCookie request, CancellationToken cancellationToken)
        {
            var cookie = await _dbContext.Cookies.FirstOrDefaultAsync(item => item.ItemId == request.ItemId, cancellationToken);

            if (cookie is null || request.PersonId != cookie.PersonId) {
                throw new NotImplementedException();
            }

            MakeCookie updateCookie = new();


            updateCookie.SetItemName(request.ItemName);
            updateCookie.SetPrice(request.Price);
            updateCookie.SetImagePath(request.ImagePath!);
            updateCookie.SetMaker(request.Maker);
            updateCookie.SetMinTemp(request.MinTemp);
            updateCookie.SetMaxTemp(request.Maxtemp);
            updateCookie.SetProtein(request.Protein);
            updateCookie.SetFat(request.Fat);
            updateCookie.SetSugar(request.Sugar);
            updateCookie.SetEnergy(request.Energy);
            updateCookie.SetCountInPackage(request.CountInPackage);
            updateCookie.SetProductExpiryDate(request.ProductExpiryDate);
            updateCookie.SetWeight(request.Weight);
            updateCookie.SetCoolingMode(request.CoolingMode!);
            updateCookie.SetProductBakeryKind(request.ProductBakeryKind!);
            updateCookie.SetAddition(request.Addition!);
            updateCookie.SetProductKindItSelf(request.ProductKindItSelf!);

            cookie.ItemName = updateCookie.GetItemName();
            cookie.Price = updateCookie.GetPrice();
            cookie.ImagePath = updateCookie.GetImagePath();
            cookie.Maker = updateCookie.GetMaker();
            cookie.MinTemp = updateCookie.GetMinTemp();
            cookie.MaxTemp = updateCookie.GetMaxTemp();
            cookie.Protein = updateCookie.GetProtein();
            cookie.Fat = updateCookie.GetFat();
            cookie.Sugar = updateCookie.GetSugar();
            cookie.Energy = updateCookie.GetEnergy();
            cookie.CountInPackage = updateCookie.GetCountInPackage();
            cookie.ProductExpiryDate = updateCookie.GetProductExpiryDate();
            cookie.Weight = updateCookie.GetWeight();
            cookie.CoolingMode = updateCookie.GetCoolingMode();
            cookie.ProductBakeryKind = updateCookie.GetProductBakeryKind();
            cookie.Addition = updateCookie.GetAddition();
            cookie.ProductKindItSelf = updateCookie.GetProductKindItSelf();


            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
