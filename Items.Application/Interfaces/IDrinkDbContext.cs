using Items.Domain.Products.FreshItem.Drinks;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Interfaces
{
    public interface IDrinkDbContext : IProductDbContext
    {
        DbSet<Coffee> Coffee { get; set; }
        DbSet<EnergyDrink> EnergyDrinks { get; set; }
        DbSet<Juice> Juices { get; set; }
        DbSet<Lemonade> Lemonades { get; set; }
        DbSet<Tea> Tea { get; set; }
        DbSet<PackageTea> PackageTea { get; set; }
        DbSet<SoyMilk> SoyMilk { get; set; }
        DbSet<TeaDrink> TeaDrinks { get; set; }
        DbSet<Water> Water { get; set; }
    }
}
