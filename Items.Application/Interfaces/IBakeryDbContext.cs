using Microsoft.EntityFrameworkCore;
using Items.Domain.Models.Categories.Bakery.Cookie;
using Items.Domain.Models.Categories.Bakery.FancyCake;
using Items.Domain.Models.Categories.Bakery.GingerBread;
using Items.Domain.Models.Categories.Bakery.RollCake;
using Items.Domain.Models.Categories.Common;

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
