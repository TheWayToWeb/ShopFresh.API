using AutoMapper;
using Items.Domain.Components.Entities.Coffee;
using Items.Domain.Components.Entities.Common;
using Items.Domain.DTOs.Requests.Common;
using Items.Domain.ViewModel.Entities.Common;

namespace Items.Domain.ViewModel.Entities.CoffeeProduct
{
    public class CoffeeDetailVm : ItemVmBase, IMapWith<Coffee>
    {
        public List<ProductTaste> Tastes { get; set; } = new();
        public string? TypeCoffee { get; set; }
        public string? KindCoffee { get; set; }
        public string? ConsistencyRelease { get; set; }
        public string? Сomposition { get; set; }
        public string? IntencityRelease { get; set; }
        public bool IsCoffeinFrree { get; set; }


        public void Mapping(Profile profile)
        {
            profile.CreateMap<Coffee, CoffeeDetailVm>()
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
                .ForMember(map => map.Tastes,
                    opt => opt.MapFrom(map => map.Tastes))
                .ForMember(map => map.TypeCoffee,
                    opt => opt.MapFrom(map => map.TypeCoffee))
                .ForMember(map => map.KindCoffee,
                    opt => opt.MapFrom(map => map.KindCoffee))
                .ForMember(map => map.ConsistencyRelease,
                    opt => opt.MapFrom(map => map.ConsistencyRelease))
                .ForMember(map => map.Сomposition,
                    opt => opt.MapFrom(map => map.Composition))
                .ForMember(map => map.IntencityRelease,
                    opt => opt.MapFrom(map => map.IntencityRelease))
                .ForMember(map => map.IsCoffeinFrree,
                    opt => opt.MapFrom(map => map.IsCoffeinFree));
        }
    }
}
