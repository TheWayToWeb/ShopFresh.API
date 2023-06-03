using Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.FruitsVegetables.Fruits;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Interfaces
{
    public interface IFruitDbContext : IProductDbContext
    {
        DbSet<Fruit> Fruits { get; set; }
        DbSet<Apple> Apples { get; set; }
        DbSet<Banana> Bananas { get; set; }
        DbSet<Blueberry> Blueberries { get; set; }
        DbSet<Сherries> Сherries { get; set; }
        DbSet<Citrus> Citruses { get; set; }
        DbSet<Exotic> Exotics { get; set; }
        DbSet<Grape> Grapes { get; set; }
        DbSet<Pear> Pears { get; set; }
        DbSet<Strawberry> Strawberries { get; set; } 
    }
}
