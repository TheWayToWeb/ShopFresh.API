using Items.Domain.Components.Entities.Categories.Drinks.ConcreteCoffee.Coffee;
using Items.Domain.Components.Entities.Categories.Drinks.ConcreteFruitDrink.FruitDrink;
using Items.Domain.Components.Entities.Categories.Drinks.ConcreteJuice.Juice;
using Items.Domain.Components.Entities.Categories.Drinks.ConcreteKissel.Kissel;
using Items.Domain.Components.Entities.Categories.Drinks.ConcreteSoyMilk.SoyMilk;
using Items.Domain.Components.Entities.Categories.Drinks.MakingTea;
using Items.Domain.Components.Entities.Categories.Drinks.MakingTea.MakingDrinkingTea;
using Items.Domain.Components.Entities.Categories.Drinks.MakingTea.MakingPackageTea;
using Items.Domain.Models;
using Items.Domain.Models.Categories.Drinks.ConcreteEnergyDrink.EnergyDrink;
using Items.Domain.Models.Categories.Drinks.MakingCoffee;
using Items.Domain.Models.Categories.Drinks.MakingLemonade.Lemonade;
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
