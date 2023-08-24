using AutoMapper;
using Items.Domain.Components.Entities.Common;
using Items.Domain.Components.Entities.Cream;
using Items.Domain.DTOs.Requests.Common;

namespace Items.Domain.ViewModel.Entities.Creams
{
    public class CreamVm : IMapWith<CreamVm>
    {
        public Guid Id { get; set; }
        public string? BrandName { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
        public string? Maker { get; set; }
        public int CountInPackage { get; set; }
        public float Weight { get; set; }
        public string? Description { get; set; }
        public bool IsFarmer { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public float Energy { get; set; }
        public int CreatedDate { get; set; }
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }
        public string? Taste { get; set; }
        public List<FatContentProduct> CreamFats { get; set; } = new();
        public string? MilkProcessing { get; set; }
        public string? PrimaryProduct { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Cream, CreamVm>()
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
                .ForMember

        }
    }
}
