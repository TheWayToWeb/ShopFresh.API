using AutoMapper;
using Items.Domain.Components.Entities.Common;
using Items.Domain.Components.Entities.SoyMilk;
using Items.Domain.DTOs.Common;

namespace Items.Domain.ViewModel.EntitiesVm.SoyDrinks
{
    public class SoyMilkDetailVm : IMapWith<SoyMilk>
    {
        public Guid Id { get; set; }
        public string? BrandName { get; set; }
        public string? ImagePath { get; set; }
        public int Price { get; set; }
        public List<FlavorName> Tastes { get; set; } = new();
        public string? SoyMilkKind { get; set; }
        public float FatContent { get; set; }
        public float MinTemp { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public float Energy { get; set; }
        public int CreatedDate { get; set; }
        public float Volume { get; set; }
        public string? Maker { get; set; }
        public string? Description { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<SoyMilk, SoyMilkDetailVm>()
                .ForMember(map => map.Id,
                    opt => opt.MapFrom(map => map.Id))
                .ForMember(map => map.BrandName,
                    opt => opt.MapFrom(map => map.Brand!.BrandName))
                .ForMember(map => map.ImagePath,
                    opt => opt.MapFrom(map => map.ImagePath))
                .ForMember(map => map.Price,
                    opt => opt.MapFrom(map => map.Price))
                .ForMember(map => map.Tastes,
                    opt => opt.MapFrom(map => map.Tastes))
                .ForMember(map => map.SoyMilkKind,
                    opt => opt.MapFrom(map => map.SoyMilkKind))
                .ForMember(map => map.FatContent,
                    opt => opt.MapFrom(map => map.FatContent))
                .ForMember(map => map.MinTemp,
                    opt => opt.MapFrom(map => map.MinTemp))
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
                .ForMember(map => map.Volume,
                    opt => opt.MapFrom(map => map.Volume))
                .ForMember(map => map.Maker,
                    opt => opt.MapFrom(map => map.Maker))
                .ForMember(map => map.Description,
                    opt => opt.MapFrom(map => map.Description));
        }
    }
}
