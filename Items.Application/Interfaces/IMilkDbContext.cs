using Items.Domain.Products.FreshItem.Eggs;
using Items.Domain.Products.FreshItem.MilkProducts;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Interfaces
{
    public interface IMilkDbContext : IProductDbContext
    {
        DbSet<LacticProduct> LacticProducts { get; set; }
        DbSet<Butter> Butters { get; set; }
        DbSet<Cheese> Cheeses { get; set; }
        DbSet<Cream> Creams { get; set; }
        DbSet<Curd> Curds { get; set; }
        DbSet<DrinkMilk> DrinkMilk { get; set; }
        DbSet<GlazedCheese> GlazedCheeses { get; set; }
        DbSet<SourCream> SourCreams { get; set; }
        DbSet<Yogurt> Yogurts { get; set; }
        DbSet<Egg> Eggs { get; set; }
    }
}
