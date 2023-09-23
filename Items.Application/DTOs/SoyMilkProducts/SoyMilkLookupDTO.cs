using AutoMapper;
using Items.Domain.Components.Entities.Common;
using Items.Domain.Components.Entities.SoyMilk;
using Items.Domain.DTOs.Common;

namespace Items.Domain.DTOs.SoyMilkProducts
{
    public class SoyMilkLookupDTO : IMapWith<SoyMilk>
    {
        public Guid Id { get; set; }
        public string? BrandName { get; set; }
        public string? ImagePath { get; set; }
        public int Price { get; set; }
        public List<SoldCapacity> Volume { get; private set; } = new();

        public void Mapping(Profile profile)
        {
            profile.CreateMap<SoyMilk, SoyMilkLookupDTO>()
                .ForMember(map => map.Id,
                    opt => opt.MapFrom(map => map.Id))
                .ForMember(map => map.BrandName,
                    opt => opt.MapFrom(map => map.Brand!.BrandName))
                .ForMember(map => map.ImagePath,
                    opt => opt.MapFrom(map => map.ImagePath))
                .ForMember(map => map.Price,
                    opt => opt.MapFrom(map => map.Price))
                .ForMember(map => map.Volume,
                    opt => opt.MapFrom(map => map.Volume));
        }
    }
}
