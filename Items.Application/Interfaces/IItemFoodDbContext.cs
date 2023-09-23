using Items.Domain.Components.Items;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Interfaces
{
    public interface IItemFoodDbContext
    {
        DbSet<ItemFood> ItemFoods { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
