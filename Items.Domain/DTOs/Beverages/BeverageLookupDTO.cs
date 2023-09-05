using AutoMapper;
using Items.Domain.Components.Entities.Common;
using Items.Domain.Components.Entities.Water;
using Items.Domain.DTOs.Common;

namespace Items.Domain.DTOs.Beverages
{
    public class BeverageLookupDTO : IMapWith<Beverage>
    {
        public Guid Id { get; set; }
        public string? BrandName { get; set; }
        public string? ImagePath { get; set; }
        public List<SoldCapacity> Volume { get; private set; } = new();

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Beverage, BeverageLookupDTO>()
                .ForMember(map => map.Id,
                    opt => opt.MapFrom(map => map.Id))
                .ForMember(map => map.BrandName,
                    opt => opt.MapFrom(map => map.Brand!.BrandName))
                .ForMember(map => map.ImagePath,
                    opt => opt.MapFrom(map => map.ImagePath))
                .ForMember(map => map.Volume,
                    opt => opt.MapFrom(map => map.Volume));
        }
    }
}
