﻿using AutoMapper;
using Items.Domain.Components.Entities.Eggs;
using Items.Domain.DTOs.Common;

namespace Items.Domain.ViewModel.EntitiesVm.BirdEggs
{
    public class EggsDetailVm : IMapWith<Egg>
    {
        public Guid Id { get; set; }
        public string? BrandName { get; set; }
        public string? ImagePath { get; set; }
        public int CountInPackage { get; set; }
        public string? Kind { get; set; }
        public string? Category { get; set; }
        public string? Description { get; set; }
        public int Price { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public float Energy { get; set; }
        public float MinTemp { get; set; }
        public float MaxTemp { get; set; }
        public bool IsFarmer { get; set; }
        public int CreatedDate { get; set; }
        public float Weight { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Egg, EggsDetailVm>()
                .ForMember(map => map.Id,
                    opt => opt.MapFrom(map => map.Id))
                .ForMember(map => map.BrandName,
                    opt => opt.MapFrom(map => map.Brand!.BrandName))
                .ForMember(map => map.ImagePath,
                    opt => opt.MapFrom(map => map.ImagePath))
                .ForMember(map => map.CountInPackage,
                    opt => opt.MapFrom(map => map.CountInPackage))
                .ForMember(map => map.Kind,
                    opt => opt.MapFrom(map => map.Kind))
                .ForMember(map => map.Category,
                    opt => opt.MapFrom(map => map.Category))
                .ForMember(map => map.Description,
                    opt => opt.MapFrom(map => map.Description))
                .ForMember(map => map.Price,
                    opt => opt.MapFrom(map => map.Price))
                .ForMember(map => map.Protein,
                    opt => opt.MapFrom(map => map.Protein))
                .ForMember(map => map.Fat,
                    opt => opt.MapFrom(map => map.Fat))
                .ForMember(map => map.Sugar,
                    opt => opt.MapFrom(map => map.Sugar))
                .ForMember(map => map.Energy,
                    opt => opt.MapFrom(map => map.Energy))
                .ForMember(map => map.MinTemp,
                    opt => opt.MapFrom(map => map.MinTemp))
                .ForMember(map => map.MaxTemp,
                    opt => opt.MapFrom(map => map.MaxTemp))
                .ForMember(map => map.IsFarmer,
                    opt => opt.MapFrom(map => map.IsFarmer))
                .ForMember(map => map.CreatedDate,
                    opt => opt.MapFrom(map => map.CreatedDate))
                .ForMember(map => map.Weight,
                    opt => opt.MapFrom(map => map.Weight));
        }
    }
}
