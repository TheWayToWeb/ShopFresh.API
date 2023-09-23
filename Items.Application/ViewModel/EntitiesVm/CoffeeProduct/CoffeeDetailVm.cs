using AutoMapper;
using Items.Domain.Components.Entities.Coffee;
using Items.Domain.Components.Entities.Common;
using Items.Domain.DTOs.Common;

namespace Items.Domain.ViewModel.EntitiesVm.CoffeeProduct
{
    public class CoffeeDetailVm : IMapWith<Coffee>
    {
        public Guid Id { get; set; }
        public string? BrandName { get; set; }
        public string? ImagePath { get; set; }
        public int Price { get; set; }
        public string? Technology { get; set; }
        public string? Intencity { get; set; }
        public List<FlavorName> Tastes { get; set; } = new();
        public string? Description { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public float Energy { get; set; }
        public bool IsCoffeinFree { get; set; }
        public string? Maker { get; set; }
        public int CreatedDate { get; set; }


        public void Mapping(Profile profile)
        {
            profile.CreateMap<Coffee, CoffeeDetailVm>()
                .ForMember(map => map.Id,
                    opt => opt.MapFrom(map => map.Id))
                .ForMember(map => map.BrandName,
                    opt => opt.MapFrom(map => map.Brand!.BrandName))
                .ForMember(map => map.ImagePath,
                    opt => opt.MapFrom(map => map.ImagePath))
                .ForMember(map => map.Price,
                    opt => opt.MapFrom(map => map.Price))
                .ForMember(map => map.Technology,
                    opt => opt.MapFrom(map => map.Technology))
                .ForMember(map => map.Intencity,
                    opt => opt.MapFrom(map => map.Intencity))
                .ForMember(map => map.Tastes,
                    opt => opt.MapFrom(map => map.Tastes))
                .ForMember(map => map.Description,
                    opt => opt.MapFrom(map => map.Description))
                .ForMember(map => map.Protein,
                    opt => opt.MapFrom(map => map.Protein))
                .ForMember(map => map.Fat,
                    opt => opt.MapFrom(map => map.Fat))
                .ForMember(map => map.Sugar,
                    opt => opt.MapFrom(map => map.Sugar))
                .ForMember(map => map.Energy,
                    opt => opt.MapFrom(map => map.Energy))
                .ForMember(map => map.IsCoffeinFree,
                    opt => opt.MapFrom(map => map.IsCoffeinFree))
                .ForMember(map => map.Maker,
                    opt => opt.MapFrom(map => map.Maker))
                .ForMember(map => map.CreatedDate,
                    opt => opt.MapFrom(map => map.CreatedDate));
        }
    }
}
