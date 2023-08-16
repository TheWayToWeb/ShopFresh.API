using Items.Domain.Components.Entities.Categories.DairyProducts.BuilderButter.Butter;
using Items.Domain.Components.Entities.Categories.DairyProducts.BuilderCheese.Cheese;
using Items.Domain.Components.Entities.Categories.DairyProducts.BuilderCreamLiquid.CreamLiquid;
using Items.Domain.Components.Entities.Categories.DairyProducts.BuilderLittleCheesyProduct.CheeseProduct;
using Items.Domain.Components.Entities.Categories.DairyProducts.BuilderMilk.Milk;
using Items.Domain.Components.Entities.Categories.DairyProducts.BuilderRolledUpMilk.RolledUpMilk;
using Items.Domain.Components.Entities.Categories.DairyProducts.BuilderThickCream.ThickCream;
using Items.Domain.Components.Entities.Categories.DairyProducts.BuilderThickDairyProduct.ThickDairyProduct;
using Items.Domain.Components.Entities.Categories.DairyProducts.BuilderYogurt.Yogurt;
using Items.Domain.Components.Entities.Categories.Eggs;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Interfaces
{
    public interface IMilkDbContext : IProductDbContext
    {
        DbSet<Butter> Butters { get; set; }
        DbSet<Cheese> Cheeses { get; set; }
        DbSet<CreamLiquid> Cream { get; set; }
        DbSet<RolledUpMilk> Curd { get; set; }
        DbSet<Milk> Milk { get; set; }
        DbSet<CheesyProduct> GlazedCheeses { get; set; }
        DbSet<ThickDairyProduct> Kefir { get; set; }
        DbSet<ThickCream> SourCream { get; set; }
        DbSet<Yogurt> Yogurts { get; set; }
        DbSet<Egg> Eggs { get; set; }
    }
}
