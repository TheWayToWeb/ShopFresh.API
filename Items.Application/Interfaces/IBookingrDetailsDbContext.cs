using Items.Domain.Components.Orders;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Interfaces
{
    public interface IOrderDetailsDbContext
    {
        DbSet<BookingDetails> BookingDetails { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
