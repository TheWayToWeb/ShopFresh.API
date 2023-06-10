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
        DbSet<DryTea> DryTea { get; set; }
        DbSet<SoyMilk> SoyMilk { get; set; }
        DbSet<DrinkingTea> DrinkingTea { get; set; }
        DbSet<Water> Water { get; set; }
        DbSet<FruitDrink> FruitDrink { get; set; }
        DbSet<Kissel> Kissel { get; set; }
    }
}
