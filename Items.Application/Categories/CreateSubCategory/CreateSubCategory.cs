using MediatR;
using Items.Domain.Categories.SubCategory;

namespace Items.Application.Categories.CreateSubCategory
{
    public class CreateSubCategory : IRequest<Guid>
    {
        public Guid SubCategoryId { get; set; }
        public string? SubCategoryName { get; set; }
        public List<SubCategory>? FreshGroup { get; set; } = new();
    }
}
