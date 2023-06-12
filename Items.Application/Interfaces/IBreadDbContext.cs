using Items.Domain.Products.FreshItem.Bread;
using Cheesecake = Items.Domain.Products.FreshItem.Bread.
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Interfaces
{
    public interface IBreadDbContext : IProductDbContext
    {
        DbSet<Baguette> Baguettes { get; set; }
        DbSet<Bread> Bread { get; set; }
        DbSet<Bun> Buns { get; set; }
        DbSet<Croissant> Croissants { get; set; }
        DbSet<CottageCheesePatty> CottageCheesePatties { get; set; }
        DbSet<Flapjack> Flapjacks { get; set; }
        DbSet<Puff> Puff { get; set; }
        DbSet<SingleFood> SingleFoods { get; set; }
        DbSet<Toast> Toasts { get; set; }
        DbSet<SimpleCake> SimpleCakes { get; set; }
    }
}
