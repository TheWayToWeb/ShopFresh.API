﻿using AutoMapper;
using Items.Domain.Components.Entities.Common;
using Items.Domain.Components.Entities.Juice;
using Items.Domain.DTOs.Common;

namespace Items.Domain.ViewModel.EntitiesVm.Juices
{
    public class JuiceVm : IMapWith<Juice>
    {
        public Guid Id { get; set; }
        public string? BrandName { get; set; }
        public string? ImagePath { get; set; }
        public int Price { get; set; }
        public int CountInPackage { get; set; }
        public int AgeLimit { get; set; }
        public List<SoldCapacity> Volume { get; set; } = new();

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Juice, JuiceVm>()
                .ForMember(map => map.Id,
                    opt => opt.MapFrom(map => map.Id))
                .ForMember(map => map.BrandName,
                    opt => opt.MapFrom(map => map.Brand!.BrandName))
                .ForMember(map => map.ImagePath,
                    opt => opt.MapFrom(map => map.ImagePath))
                .ForMember(map => map.Price,
                    opt => opt.MapFrom(map => map.Price))
                .ForMember(map => map.CountInPackage,
                    opt => opt.MapFrom(map => map.CountInPackage))
                .ForMember(map => map.AgeLimit,
                    opt => opt.MapFrom(map => map.AgeLimit))
                .ForMember(map => map.Volume,
                    opt => opt.MapFrom(map => map.Volume));
        }
    }
}
