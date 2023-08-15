using AutoMapper;
using Items.Domain.DTOs.Requests.Common;
using FruitDomain = Items.Domain.Components.Entities.Categories.Fruits.Fruit.Fruit;

namespace Items.Domain.DTOs.Requests.Fruits.Fruit
{
    public class FruitDetailsVm : IMapWith<FruitDomain>
    {
        public Guid ItemId { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
        public string? Maker { get; set; }
        public int MinTemp { get; set; }
        public int Maxtemp { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public float Energy { get; set; }
        public int CountInPackage { get; set; }
        public int CreatedDate { get; set; }

        public void Mapping(Profile profile) {
            profile.CreateMap<FruitDomain, FruitDetailsVm>()
                .ForMember(mapVm => mapVm.ItemId,
                    opt => opt.MapFrom(map => map.ItemId))
                .ForMember(mapVm => mapVm.Price,
                    opt => opt.MapFrom(map => map.Price))
                .ForMember(mapVm => mapVm.ImagePath,
                    opt => opt.MapFrom(map => map.ImagePath))
                .ForMember(mapvm => mapvm.Maker,
                    opt => opt.MapFrom(map => map.Maker))
                .ForMember(mapVm => mapVm.MinTemp,
                    opt => opt.MapFrom(map => map.MinTemp))
                .ForMember(mapVm => mapVm.Maxtemp,
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
                    opt => opt.MapFrom(map => map.CreatedDate));
        }
    }
}
