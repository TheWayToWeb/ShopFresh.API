﻿using AutoMapper;
using Items.Domain.Components.Entities.Common;
using Items.Domain.Components.Entities.Vegetables;
using Items.Domain.DTOs.Common;

namespace Items.Domain.DTOs.Vegetables
{
    public class VegetableLookupDTO : IMapWith<Vegetable>
    {
        public Guid Id { get; set; }
        public string? BrandName { get; set; }
        public string? ImagePath { get; set; }
        public int Price { get; set; }
        public float Weight { get; set; }
        public bool ByWeight { get; set; }
        public List<SalesRange> SalesWeights { get; set; } = new();

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Vegetable, VegetableLookupDTO>()
                .ForMember(map => map.Id,
                    opt => opt.MapFrom(map => map.Id))
                .ForMember(map => map.BrandName,
                    opt => opt.MapFrom(map => map.Brand!.BrandName))
                .ForMember(map => map.ImagePath,
                    opt => opt.MapFrom(map => map.ImagePath))
                .ForMember(map => map.Price,
                    opt => opt.MapFrom(map => map.Price))
                .ForMember(map => map.Weight,
                    opt => opt.MapFrom(map => map.Weight))
                .ForMember(map => map.ByWeight,
                    opt => opt.MapFrom(map => map.ByWeight))
                .ForMember(map => map.SalesWeights,
                    opt => opt.MapFrom(map => map.SalesWeights));
        }
    }
}
