using Items.Domain.Models.Categories.Drinks.EnergyDrink;
using Items.Domain.Models.Categories.Drinks.FruitDrink;
using Items.Domain.Models.Categories.Drinks.Juice;
using Items.Domain.Models.Categories.Drinks.Kissel;
using Items.Domain.Models.Categories.Drinks.MakingCoffee;
using Items.Domain.Models.Categories.Drinks.MakingLemonade;
using Items.Domain.Models.Categories.Drinks.MakingSoyMilk;
using Items.Domain.Models.Categories.Drinks.MakingTea;
using Items.Domain.Models.Categories.Drinks.MakingTea.MakingDrinkingTea;
using Items.Domain.Models.Categories.Drinks.MakingTea.MakingPackageTea;
using Items.Domain.Models.Categories.Drinks.MakingWater;
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
        DbSet<PackageTea> DryTea { get; set; }
        DbSet<SoyMilk> SoyMilk { get; set; }
        DbSet<TeaDrink> DrinkingTea { get; set; }
        DbSet<Water> Water { get; set; }
        DbSet<FruitDrink> FruitDrink { get; set; }
        DbSet<Kissel> Kissel { get; set; }
    }
}
