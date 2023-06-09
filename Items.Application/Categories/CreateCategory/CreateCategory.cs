using MediatR;
using Items.Domain.Categories.Category;

namespace Items.Application.Categories.CreateCategory
{
    public class CreateCategory : IRequest<Guid>
    {
        public string? CategoryName { get; set; }
        public List<Category>? SubCategories { get; set; } = new();
    }
}
