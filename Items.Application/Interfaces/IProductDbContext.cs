using Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Interfaces
{
    public interface IProductDbContext
    {
        DbSet<Item> Items { get; set; }
        DbSet<Eatable> Eatables { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
