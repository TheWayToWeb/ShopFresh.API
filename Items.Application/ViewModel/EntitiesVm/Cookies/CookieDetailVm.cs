﻿using AutoMapper;
using Items.Domain.Components.Entities.Cookies;
using Items.Domain.DTOs.Common;

namespace Items.Domain.ViewModel.EntitiesVm.Cookies
{
    public class CookieDetailVm : IMapWith<Cookie>
    {
        public Guid Id { get; set; }
        public string? BrandName { get; set; }
        public string? ImagePath { get; set; }
        public int Price { get; set; }
        public string? GlazeType { get; set; }
        public float Weight { get; set; }
        public float Energy { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public string? Description { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Cookie, CookieDetailVm>()
                .ForMember(map => map.Id,
                    opt => opt.MapFrom(map => map.Id))
                .ForMember(map => map.BrandName,
                    opt => opt.MapFrom(map => map.Brand!.BrandName))
                .ForMember(map => map.ImagePath,
                    opt => opt.MapFrom(map => map.ImagePath))
                .ForMember(map => map.Price,
                    opt => opt.MapFrom(map => map.Price))
                .ForMember(map => map.GlazeType,
                    opt => opt.MapFrom(map => map.GlazeType))
                .ForMember(map => map.Weight,
                    opt => opt.MapFrom(map => map.Weight))
                .ForMember(map => map.Energy,
                    opt => opt.MapFrom(map => map.Energy))
                .ForMember(map => map.Protein,
                    opt => opt.MapFrom(map => map.Protein))
                .ForMember(map => map.Fat,
                    opt => opt.MapFrom(map => map.Fat))
                .ForMember(map => map.Sugar,
                    opt => opt.MapFrom(map => map.Sugar))
                .ForMember(map => map.Description,
                    opt => opt.MapFrom(map => map.Description));
        }
    }
}
