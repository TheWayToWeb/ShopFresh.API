using Microsoft.EntityFrameworkCore;
using Items.Domain.Components.Entities.Categories.Common;
using Items.Domain.Components.Entities.Categories.Bakery.Cookie;
using Items.Domain.Components.Entities.Categories.Bakery.FancyCake;
using Items.Domain.Components.Entities.Categories.Bakery.GingerBread;
using Items.Domain.Components.Entities.Categories.Bakery.RollCake;

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
