using AutoMapper;
using Items.Domain.Components.Categories;
using Items.Domain.Components.Entities.Common;
using Items.Domain.DTOs.Common;

namespace Items.Domain.ViewModel.Categories
{
    public class SubCategoryVm : IMapWith<SubCategory>
    {
        public Guid Id { get; set; }
        public string? SubCategoryName { get; set; }
        public List<Item> Items { get; set; } = new();

        public void Mapping(Profile profile)
        {
            profile.CreateMap<SubCategory, SubCategoryVm>()
                .ForMember(map => map.Id,
                    opt => opt.MapFrom(map => map))
                .ForMember(map => map.SubCategoryName,
                    opt => opt.MapFrom(map => map.SubCategoryName))
                .ForMember(map => map.Items,
                    opt => opt.MapFrom(map => map.Items));
        }
    }
}
