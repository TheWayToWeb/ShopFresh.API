using AutoMapper;
using Items.Domain.DTOs.Requests.Common;
using AppleDomain = Items.Domain.Models.Categories.Fruits.ConcreteApple.Apple.Apple;
using SalesLine = Items.Domain.Components.Entities.Categories.Fruits.Common.SalesLine;

namespace Items.Domain.DTOs.Requests.Fruits.Apple
{
    public class AppleDetailVm : IMapWith<AppleDomain>
    {
        public Guid ItemId { get; set; }
        public string? ItemName { get; set; }
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
        public string? Grade { get; set; }
        public List<SalesLine>? SaleWeights { get; set; }

        public void Mapping(Profile profile) {
            profile.CreateMap<AppleDomain, AppleDetailVm>()
                .ForMember(mapVm => mapVm.ItemId,
                    opt => opt.MapFrom(map => map.ItemId))
                .ForMember(mapVm => mapVm.ItemName,
                    opt => opt.MapFrom(map => map.ItemName))
                .ForMember(mapVm => mapVm.Price,
                    opt => opt.MapFrom(map => map.Price))
                .ForMember(mapVm => mapVm.ImagePath,
                    opt => opt.MapFrom(map => map.ImagePath))
                .ForMember(mapVm => mapVm.Maker,
                    opt => opt.MapFrom(map => map.Maker))
                .ForMember(mapVm => mapVm.MinTemp,
                    opt => opt.MapFrom(map => map.MinTemp))
                .ForMember(mapVm => mapVm.MaxTemp,
                    opt => opt.MapFrom(map => map.MaxTemp))
                .ForMember(mapVm => mapVm.Protein,
                    opt => opt.MapFrom(map => map.Protein))
                .ForMember(mapVm => mapVm.Fat,
                    opt => opt.MapFrom(map => map.Fat))
                .ForMember(mapVm => mapVm.Sugar,
                    opt => opt.MapFrom(map => map.Sugar))
                .ForMember(mapVm => mapVm.Energy,
                    opt => opt.MapFrom(map => map.Energy))
                .ForMember(mapVm => mapVm.CountInPackage,
                    opt => opt.MapFrom(map => map.CountInPackage))
                .ForMember(mapVm => mapVm.CreatedDate,
                    opt => opt.MapFrom(map => map.CreatedDate))
                .ForMember(mapVm => mapVm.Weight,
                    opt => opt.MapFrom(map => map.Weight))
                .ForMember(mapVm => mapVm.CoolingMode,
                    opt => opt.MapFrom(map => map.CoolingMode))
                .ForMember(mapVm => mapVm.Grade,
                    opt => opt.MapFrom(map => map.Grade))
                .ForMember(mapVm => mapVm.SaleWeights,
                    opt => opt.MapFrom(map => map.SaleWeights));
        }
    }
}
