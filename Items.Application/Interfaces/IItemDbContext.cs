using Items.Domain.Components.Items;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Interfaces
{
    public interface IItemDbContext
    {
        DbSet<Item> Items { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
