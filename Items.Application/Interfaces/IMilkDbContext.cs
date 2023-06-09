using Items.Domain.Products.FreshItem.Eggs;
using Items.Domain.Products.FreshItem.MilkProducts;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Interfaces
{
    public interface IMilkDbContext : IProductDbContext
    {
        DbSet<Butter> Butters { get; set; }
        DbSet<Cheese> Cheeses { get; set; }
        DbSet<Cream> Cream { get; set; }
        DbSet<Curd> Curd { get; set; }
        DbSet<DrinkMilk> Milk { get; set; }
        DbSet<GlazedCheese> GlazedCheeses { get; set; }
        DbSet<Kefir> Kefir { get; set; }
        DbSet<SourCream> SourCream { get; set; }
        DbSet<Yogurt> Yogurts { get; set; }
        DbSet<Egg> Eggs { get; set; }
    }
}
