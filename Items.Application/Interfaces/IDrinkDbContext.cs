using Items.Domain.Products.FreshItem.Drinks.MakingCoffee;
using Items.Domain.Products.FreshItem.Drinks.MakingEnergyDrink;
using Items.Domain.Products.FreshItem.Drinks.MakingFruitDrink;
using Items.Domain.Products.FreshItem.Drinks.MakingJuice;
using Items.Domain.Products.FreshItem.Drinks.MakingKissel;
using Items.Domain.Products.FreshItem.Drinks.MakingLemonade;
using Items.Domain.Products.FreshItem.Drinks.MakingSoyMilk;
using Items.Domain.Products.FreshItem.Drinks.MakingTea;
using Items.Domain.Products.FreshItem.Drinks.MakingTea.MakingDrinkingTea;
using Items.Domain.Products.FreshItem.Drinks.MakingTea.MakingDryTea;
using Items.Domain.Products.FreshItem.Drinks.MakingWater;
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
