﻿using AutoMapper;
using Items.Domain.Components.Entities.Common;
using Items.Domain.Components.Entities.Cream;
using Items.Domain.DTOs.Requests.Common;

namespace Items.Domain.ViewModel.Entities.Creams
{
    public class CreamDetailVm : IMapWith<Cream>
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
            profile.CreateMap<Cream, CreamDetailVm>()
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
                .ForMember(map => map.Taste,
                    opt => opt.MapFrom(map => map.Taste))
                .ForMember(map => map.CreamFats,
                    opt => opt.MapFrom(map => map.CreamFats))
                .ForMember(map => map.MilkProcessing,
                    opt => opt.MapFrom(map => map.MilkProcessing))
                .ForMember(map => map.PrimaryProduct,
                    opt => opt.MapFrom(map => map.PrimaryProduct));


        }
    }
}