using AutoMapper;
using Items.Domain.Components.Entities.Common;
using Items.Domain.DTOs.Common;

namespace Items.Domain.ViewModel.EntitiesVm.Common
{
    public class ItemFoodVm : IMapWith<ItemFood>
    {
        public Guid Id { get; set; }
        public string? BrandName { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
        public float Weight { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<ItemFood, ItemFoodVm>()
                .ForMember(map => map.Id,
                    opt => opt.MapFrom(map => map.Id))
                .ForMember(map => map.BrandName,
                    opt => opt.MapFrom(map => map.Brand!.BrandName))
                .ForMember(map => map.Price,
                    opt => opt.MapFrom(map => map.Price))
                .ForMember(map => map.ImagePath,
                    opt => opt.MapFrom(map => map.ImagePath))
                .ForMember(map => map.Weight,
                    opt => opt.MapFrom(map => map.Weight));
        }
    }
}
