using AutoMapper;
using Items.Domain.Components.Items;
using Items.Domain.DTOs.Common;

namespace Items.Domain.ViewModel.EntitiesVm.Common
{
    public class ItemVm : IMapWith<Item>
    {
        public Guid Id { get; set; }
        public string? BrandName { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Item, ItemVm>()
                .ForMember(map => map.Id,
                    opt => opt.MapFrom(map => map.Id))
                .ForMember(map => map.BrandName,
                    opt => opt.MapFrom(map => map.Brand!.BrandName))
                .ForMember(map => map.Price,
                    opt => opt.MapFrom(map => map.Price))
                .ForMember(map => map.ImagePath,
                    opt => opt.MapFrom(map => map.ImagePath));
        }
    }
}
