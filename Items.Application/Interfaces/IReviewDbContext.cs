using Items.Domain.Components.Feedback;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Interfaces
{
    public interface IReviewDbContext
    {
        DbSet<Review> Reviews { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
