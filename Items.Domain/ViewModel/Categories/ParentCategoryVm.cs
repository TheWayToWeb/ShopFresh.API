using AutoMapper;
using Items.Domain.Components.Categories;
using Items.Domain.DTOs.Common;

namespace Items.Domain.ViewModel.Categories
{
    public class ParentCategoryVm : IMapWith<ParentCategory>
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public List<CategoryVm> Categories { get; set; } = new();

        public void Mapping(Profile profile)
        {
            profile.CreateMap<ParentCategory, ParentCategoryVm>()
                .ForMember(map => map.Id,
                    opt => opt.MapFrom(map => map.Id))
                .ForMember(map => map.Name,
                    opt => opt.MapFrom(map => map.Name))
                .ForMember(map => map.Categories,
                    opt => opt.MapFrom(map => map.Categories));
        }
    }
}
