using Items.Domain.Products.FreshItem.Bakery;
using Items.Domain.Products.FreshItem.Bakery.FactoryCookie;
using Items.Domain.Products.FreshItem.Bakery.FactoryFancyCookie;
using Items.Domain.Products.FreshItem.Bakery.FactoryGingerbread;
using Items.Domain.Products.FreshItem.Bakery.FactoryRollCake;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Interfaces
{
    public interface IBakeryDbContext : IProductDbContext
    {
        DbSet<Bakery> Bakery { get; set; }
        DbSet<Cookie> Cookies { get; set; }
        DbSet<Gingerbread> Gingerbreads { get; set; }
        DbSet<RollCake> RollCakes { get; set; }
        DbSet<FancyCake> FancyCakes { get; set; }
    }
}
