﻿using MediatR;
using System.Runtime.Serialization.Formatters;

namespace Items.Application.Products.FruisVegetables.Vegetables.CreateBeet
{
    public class CreateBeet : IRequest<Guid>
    {
        public string? ItemName { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }
        public float? Weight { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public float Energy { get; set; }
        public int CountInPackage { get; set; }
        public DateOnly BeforeDate { get; set; }
        public string? ShortName { get; set; }
        public string? Grade { get; set; }
    }
}