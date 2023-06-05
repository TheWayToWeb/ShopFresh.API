using Items.Domain.Categories.Category;
using Items.Domain.Categories.FreshGroup;
using Items.Domain.Categories.ParentCategory;
using Items.Domain.Categories.SubCategory;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Interfaces
{
    public interface ICategoryDbContext
    {
        DbSet<ParentCategory> ParentCategories { get; set; }
        DbSet<Category> Categories { get; set; }
        DbSet<SubCategory> SubCategories { get; set; }
        DbSet<FreshGroup> FreshGroups { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
