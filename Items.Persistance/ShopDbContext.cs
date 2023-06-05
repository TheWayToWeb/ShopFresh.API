using Microsoft.EntityFrameworkCore;
using Items.Application.Interfaces;
using Items.Domain;
using Items.Persistance.EntityTypeConfiguration;
using Items.Domain.Products.Category.SubCategory.ItemCategory.Items.Cheese;
using Items.Domain.Products.FreshItem;
using Items.Domain.Products.FreshItem.MilkProducts;
using Items.Domain.Products.FreshItem.FrozenFood.Ice_cream;

namespace Items.Persistance
{
    public class ShopDbContext : DbContext, IFruitDbContext
    {
        public DbSet<Item> Items { get; set; }
        public DbSet<Cheese1> Cheeses { get; set; }
        public DbSet<Cookie> Cookies { get; set; }
        public DbSet<Cream> Creams { get; set; }
        public DbSet<GameConsole> GameConsoles { get; set; }
        public DbSet<Gamepad> Gamepads { get; set; }
        public DbSet<HerbalDrink> HerbalDrinks { get; set; }
        public DbSet<IceCream> IceCreams { get; set; }
        public DbSet<Paper> Papers { get; set; }

        public ShopDbContext(DbContextOptions<ShopDbContext> options) : base(options) {
            
        }

        protected override void OnModelCreating(ModelBuilder builder) {
            builder.ApplyConfiguration(new ShopConfiguration());
            base.OnModelCreating(builder);
        }
    }
}
