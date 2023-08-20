using Items.Domain.Components.Entities.Categories.Fruits.ConcreteStrawberry.Strawberry;
using Items.Domain.Components.Entities.Fruits;
using Items.Domain.Components.Entities.Fruits.Fruit;
using Items.Domain.Models.Categories.Fruits;
using Items.Domain.Models.Categories.Fruits.ConcreteApple.Apple;
using Items.Domain.Models.Categories.Fruits.ConcreteBanana.Banana;
using Items.Domain.Models.Categories.Fruits.ConcreteBluBerry.BlueBerry;
using Items.Domain.Models.Categories.Fruits.ConcreteCitrus.Citrus;
using Items.Domain.Models.Categories.Fruits.ConcreteExoticFruit.ExoticFruit;
using Items.Domain.Models.Categories.Fruits.ConcreteGrape.Grape;
using Items.Domain.Models.Categories.Fruits.ConcretePear.Pear;
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
        DbSet<ExoticFruit> ExoticFruits { get; set; }
        DbSet<Grape> Grapes { get; set; }
        DbSet<Pear> Pears { get; set; }
        DbSet<Strawberry> Strawberries { get; set; } 
    }
}
