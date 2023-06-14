using Items.Domain.Products.FreshItem.FruitsVegetables.Vegetables;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Interfaces
{
    public interface IVegetableDbContext : IProductDbContext
    {
        DbSet<Vegetable> Vegetables { get; set; }
        DbSet<Beet> Beets { get; set; }
        DbSet<Сabbage> Сabbage { get; set; }
        DbSet<Carrot> Carrots { get; set; }
        DbSet<Cauliflower> Cauliflowers { get; set; }
        DbSet<Squash> Squashes { get; set; }
        DbSet<Potato> Potatos { get; set; }
        DbSet<Redis> Redises { get; set; }
        DbSet<Salad> Salads { get; set; }
        DbSet<SaladMix> SaladMixes { get; set; }
        DbSet<Tomato> Tomatoes { get; set; }
        DbSet<Mushroom> Mushrooms { get; set; }
        DbSet<Bean> Beans { get; set; }
        DbSet<VegetableMix> VegetableMixes { get; set; }
    }
}
