using AutoMapper;
using Items.Domain.Components.Entities.Common;
using Items.Domain.Components.Entities.Fruits;
using Items.Domain.DTOs.Requests.Common;
using Items.Domain.ViewModel.EntitiesVm.Common;

namespace Items.Domain.ViewModel.EntitiesVm.Fruits
{
    public class FruitDetailVm : ItemVmBase, IMapWith<Fruit>
    {
        public string? Grade { get; set; }
        public string? FormRelease { get; set; }
        public string? CoolingMode { get; set; }
        public string? SkinColor { get; set; }
        public bool ByWeight { get; set; }
        public List<SalesRange> SalesWeights { get; set; } = new();

        public void Mapping(Profile profile)
        {

            profile.CreateMap<Fruit, FruitDetailVm>()
                .ForMember(map => map.Id,
                    opt => opt.MapFrom(map => map.Id))
                .ForMember(map => map.BrandName,
                    opt => opt.MapFrom(map => map.Brand!.BrandName))
                .ForMember(map => map.Price,
                    opt => opt.MapFrom(map => map.Price))
                .ForMember(map => map.ImagePath,
                    opt => opt.MapFrom(map => map.ImagePath))
                .ForMember(map => map.Maker,
                    opt => opt.MapFrom(map => map.Maker))
                .ForMember(map => map.CountInPackage,
                    opt => opt.MapFrom(map => map.CountInPackage))
                .ForMember(map => map.Weight,
                    opt => opt.MapFrom(map => map.Weight))
                .ForMember(map => map.Description,
                    opt => opt.MapFrom(map => map.Description))
                .ForMember(map => map.IsFarmer,
                    opt => opt.MapFrom(map => map.IsFarmer))
                .ForMember(map => map.Protein,
                    opt => opt.MapFrom(map => map.Protein))
                .ForMember(map => map.Fat,
                    opt => opt.MapFrom(map => map.Fat))
                .ForMember(map => map.Sugar,
                    opt => opt.MapFrom(map => map.Sugar))
                .ForMember(map => map.Energy,
                    opt => opt.MapFrom(map => map.Energy))
                .ForMember(map => map.CreatedDate,
                    opt => opt.MapFrom(map => map.CreatedDate))
                .ForMember(map => map.MinTemp,
                    opt => opt.MapFrom(map => map.MinTemp))
                .ForMember(map => map.MaxTemp,
                    opt => opt.MapFrom(map => map.MaxTemp))
                .ForMember(map => map.Grade,
                    opt => opt.MapFrom(map => map.Grade))
                .ForMember(map => map.FormRelease,
                    opt => opt.MapFrom(map => map.FormRelease))
                .ForMember(map => map.CoolingMode,
                    opt => opt.MapFrom(map => map.CoolingMode))
                .ForMember(map => map.SkinColor,
                    opt => opt.MapFrom(map => map.SkinColor))
                .ForMember(map => map.ByWeight,
                    opt => opt.MapFrom(map => map.ByWeight))
                .ForMember(map => map.SalesWeights,
                    opt => opt.MapFrom(map => map.SalesWeights));
        }
    }
}
