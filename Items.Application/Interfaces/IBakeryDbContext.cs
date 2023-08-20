using Microsoft.EntityFrameworkCore;
using Items.Domain.Components.Entities.Categories.Common;
using Items.Domain.Components.Entities.Bakery.Cookie;
using Items.Domain.Components.Entities.Bakery.FancyCake;
using Items.Domain.Components.Entities.Bakery.GingerBread;
using Items.Domain.Components.Entities.Bakery.RollCake;

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
