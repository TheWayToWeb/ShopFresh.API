using Items.Domain.Components.Orders;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Interfaces
{
    public interface IOrderDbContext
    {
        DbSet<Booking> Bookings { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
