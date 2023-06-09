using MediatR;
using Items.Domain.Categories.SubCategory;

namespace Items.Application.Categories.CreateSubCategory
{
    public class CreateSubCategory : IRequest<Guid>
    {
        public string? SubCategoryName { get; set; }
        public List<SubCategory>? FreshGroups { get; set; } = new();
    }
}
