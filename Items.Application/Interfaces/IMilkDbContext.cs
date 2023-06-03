using Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.MilkProducts;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Interfaces
{
    public interface IMilkDbContext : IProductDbContext
    {
        DbSet<DrinkMilk> DrinkMilk { get; set; }
        DbSet<Cream> Creams { get; set; }
        DbSet<GlazedCheese> GlazedCheeses { get; set; }
        DbSet<Curd> Curds { get; set; }
        DbSet<Yogurt> Yogurts { get; set; }
    }
}
