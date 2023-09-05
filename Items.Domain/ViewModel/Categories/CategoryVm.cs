using AutoMapper;
using Items.Domain.Components.Categories;
using Items.Domain.DTOs.Common;

namespace Items.Domain.ViewModel.Categories
{
    public class CategoryVm : IMapWith<Category>
    {
        public Guid Id { get; set; }
        public string? CategoryName { get; set; }
        public List<SubCategory> SubCategories { get; set; } = new();

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Category, CategoryVm>()
                .ForMember(map => map.Id,
                    opt => opt.MapFrom(map => map.Id))
                .ForMember(map => map.CategoryName,
                    opt => opt.MapFrom(map => map.CategoryName))
                .ForMember(map => map.SubCategories,
                    opt => opt.MapFrom(map => map.SubCategories));
        }
    }
}
