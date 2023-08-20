using Items.Domain.Brands;
using Items.Domain.Components.Entities.Common;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Interfaces
{
    public interface IProductDbContext
    {
        DbSet<Item> Items { get; set; }
        DbSet<Eat> Eat { get; set; }
        DbSet<Drink> Drinks { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
