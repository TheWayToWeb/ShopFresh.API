using Cheesecake = Items.Domain.Products.FreshItem.Bread.
using Microsoft.EntityFrameworkCore;
using Items.Domain.Products.FreshItem.Bread.MakingFlapJack;
using Items.Domain.Models.Categories.Bread;
using Items.Domain.Models.Categories.Bread.MakingCroissant;
using Items.Domain.Models.Categories.Bread.MakingPuff;
using Items.Domain.Models.Categories.Bread.MakingSimpleCake;
using Items.Domain.Models.Categories.Bread.MakingSingleFood;
using Items.Domain.Models.Categories.Bread.MakingToast;
using Items.Domain.Models.Categories.Bread.Baguette;
using Items.Domain.Models.Categories.Bread.Bun;
using Items.Domain.Models.Categories.Bread.CottageCheesePatty;

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
