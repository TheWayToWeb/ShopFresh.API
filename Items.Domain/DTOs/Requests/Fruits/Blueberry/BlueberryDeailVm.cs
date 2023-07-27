using AutoMapper;
using Items.Domain.DTOs.Requests.Common;
using BlueberryDomain = Items.Domain.Models.Categories.Fruits.ConcreteBluBerry.BlueBerry.Blueberry;

namespace Items.Domain.DTOs.Requests.Fruits.Blueberry
{
    public class BlueberryDeailVm : IMapWith<BlueberryDomain>
    {
        public Guid ItemId { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
        public string? Maker { get; set; }
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public float Energy { get; set; }
        public int CountInPackage { get; set; }
        public int CreatedDate { get; set; }
        public float Weight { get; set; }
        public string? CoolingMode { get; set; }

        public void Mapping(Profile profile) {
            profile.CreateMap<BlueberryDomain, BlueberryDeailVm>()
                .ForMember(mapVm => mapVm.ItemId,
                    option => option.MapFrom(map => map.ItemId))
                .ForMember(mapVm => mapVm.Price,
                    option => option.MapFrom(map => map.Price))
                .ForMember(mapVm => mapVm.ImagePath,
                    option => option.MapFrom(map => map.ImagePath))
                .ForMember(mapVm => mapVm.Maker,
                    option => option.MapFrom(map => map.Maker))
                .ForMember(mapVm => mapVm.MinTemp,
                    option => option.MapFrom(map => map.MinTemp))
                .ForMember(mapVm => mapVm.MaxTemp,
                    option => option.MapFrom(map => map.MaxTemp))
                .ForMember(mapVm => mapVm.Protein,
                    option => option.MapFrom(map => map.Protein))
                .ForMember(mapVm => mapVm.Fat,
                    option => option.MapFrom(map => map.Fat))
                .ForMember(mapVm => mapVm.Sugar,
                    option => option.MapFrom(map => map.Sugar))
                .ForMember(mapVm => mapVm.Energy,
                    option => option.MapFrom(map => map.Energy))
                .ForMember(mapVm => mapVm.CountInPackage,
                    option => option.MapFrom(map => map.CountInPackage))
                .ForMember(mapVm => mapVm.CreatedDate,
                    option => option.MapFrom(map => map.CreatedDate))
                .ForMember(mapVm => mapVm.Weight,
                    option => option.MapFrom(map => map.Weight))
                .ForMember(mapVm => mapVm.CoolingMode,
                    option => option.MapFrom(map => map.CoolingMode));
        }
    }
}
