﻿using AutoMapper;
using Items.Domain.DTOs.Requests.Common;
using GrapeDomain = Items.Domain.Models.Categories.Fruits.ConcreteGrape.Grape.Grape;

namespace Items.Domain.DTOs.Requests.Fruits.Grape
{
    public class GrapeDetailVm : IMapWith<GrapeDomain>
    {
        public Guid ItemId { get; set; }
        public string? ItemName { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
        public string? Maker { get; set; }
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public float Energy { get; set; }
        public int CountInPackage { get; set; }
        public int CreatedDate { get; set; }
        public float Weight { get; set; }
        public string? CoolingMode { get; set; }

        public void Mapping(Profile profile) {
            profile.CreateMap<GrapeDomain, GrapeDetailVm>()
                .ForMember(mapVm => mapVm.ItemId,
                    opt => opt.MapFrom(map => map.ItemId))
                .ForMember(mapVm => mapVm.ItemName,
                    opt => opt.MapFrom(map => map.ItemName))
                .ForMember(mapVm => mapVm.Price,
                    opt => opt.MapFrom(map => map.Price))
                .ForMember(mapVm => mapVm.ImagePath,
                    opt => opt.MapFrom(map => map.ImagePath))
                .ForMember(mapVm => mapVm.Maker,
                    opt => opt.MapFrom(map => map.Maker))
                .ForMember(mapVm => mapVm.MinTemp,
                    opt => opt.MapFrom(map => map.MinTemp))
                .ForMember(mapVm => mapVm.MaxTemp,
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
                    opt => opt.MapFrom(map => map.CreatedDate))
                .ForMember(mapVm => mapVm.Weight,
                    opt => opt.MapFrom(map => map.Weight))
                .ForMember(mapVm => mapVm.CoolingMode,
                    opt => opt.MapFrom(map => map.CoolingMode));
        }
    }
}