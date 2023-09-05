using AutoMapper;
using Items.Domain.Components.Entities.Cheeses;
using Items.Domain.Components.Entities.Common;
using Items.Domain.DTOs.Common;
using Items.Domain.ViewModel.EntitiesVm.Common;

namespace Items.Domain.ViewModel.EntitiesVm.Cheeses
{
    public class CheeseDetailVm : ItemVmCommon, IMapWith<Cheese>
    {
        public List<ProductTaste> Tastes { get; set; } = new();
        public string? FormRelease { get; set; }
        public string? PrimaryProduct { get; set; }
        public List<SalesRange> SaleWeights { get; set; } = new();
        public bool InParts { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Cheese, CheeseDetailVm>()
                .ForMember(map => map.Id,
                    opt => opt.MapFrom(map => map.Id))
                .ForMember(map => map.BrandName,
                    opt => opt.MapFrom(map => map.Brand!.BrandName))
                .ForMember(map => map.ImagePath,
                    opt => opt.MapFrom(map => map.ImagePath))
                .ForMember(map => map.Price,
                    opt => opt.MapFrom(map => map.Price))
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
                .ForMember(map => map.Tastes,
                    opt => opt.MapFrom(map => map.Tastes))
                .ForMember(map => map.FormRelease,
                    opt => opt.MapFrom(map => map.FormRelease))
                .ForMember(map => map.PrimaryProduct,
                    opt => opt.MapFrom(map => map.PrimaryProduct))
                .ForMember(map => map.SaleWeights,
                    opt => opt.MapFrom(map => map.SalesWeights))
                .ForMember(map => map.InParts,
                    opt => opt.MapFrom(map => map.InParts));

        }
    }
}
