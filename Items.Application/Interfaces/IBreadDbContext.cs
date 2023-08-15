using Cheesecake = Items.Domain.Products.FreshItem.Bread.
using Microsoft.EntityFrameworkCore;
using Items.Domain.Products.FreshItem.Bread.MakingFlapJack;
using Items.Domain.Components.Entities.Categories.Bread;
using Items.Domain.Components.Entities.Categories.Bread.Baguette;
using Items.Domain.Components.Entities.Categories.Bread.Bun;
using Items.Domain.Components.Entities.Categories.Bread.CottageCheesePatty;
using Items.Domain.Components.Entities.Categories.Bread.MakingCroissant;
using Items.Domain.Components.Entities.Categories.Bread.MakingPuff;
using Items.Domain.Components.Entities.Categories.Bread.MakingSimpleCake;
using Items.Domain.Components.Entities.Categories.Bread.MakingSingleFood;
using Items.Domain.Components.Entities.Categories.Bread.MakingToast;

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
