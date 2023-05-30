using Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem;
using Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.FruitsVegetables.Vegetables;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Interfaces
{
    public interface IVegetableDbContext
    {
        DbSet<Item> Items { get; set; }
        DbSet<Eatable> Eatables { get; set; }
        DbSet<Beet> Beets { get; set; }

    }
}
