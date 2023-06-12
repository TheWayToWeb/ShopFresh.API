using Items.Domain.Products.FreshItem.Bakery;
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
