using AutoMapper;
using Items.Domain.Components.Entities.Common;
using Items.Domain.Components.Entities.Juices;
using Items.Domain.DTOs.Common;

namespace Items.Domain.ViewModel.EntitiesVm.Juices
{
    public class JuiceDetailVm : IMapWith<Juice>
    {
        public Guid Id { get; set; }
        public string? BrandName { get; set; }
        public string? ImagePath { get; set; }
        public int Price { get; set; }
        public List<ProductTaste> Tastes { get; set; } = new();
        public List<SoldCapacity> Volume { get; set; } = new();
        public int MinTemp { get; set; }
        public string? Description { get; set; }
        public bool IsCold { get; set; }
        public int CreatedDate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Juice, JuiceDetailVm>()
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
                .ForMember(map => map.Volume,
                    opt => opt.MapFrom(map => map.Volume))
                .ForMember(map => map.MinTemp,
                    opt => opt.MapFrom(map => map.MinTemp))
                .ForMember(map => map.Description,
                    opt => opt.MapFrom(map => map.Description))
                .ForMember(map => map.IsCold,
                    opt => opt.MapFrom(map => map.IsCold))
                .ForMember(map => map.CreatedDate,
                    opt => opt.MapFrom(map => map.CreatedDate));
        }
    }
}
