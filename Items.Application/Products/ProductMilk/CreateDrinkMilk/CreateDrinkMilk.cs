﻿using Items.Domain.Components.Entities.Categories.Common;
using MediatR;

namespace Items.Application.Products.ProductMilk.CreateDrinkingMilk
{
    public class CreateDrinkMilk : IRequest<Guid>
    {
        public string? ItemName { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }
        public List<SoldCapacity>? Capacity { get; set; } = new();
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public float Energy { get; set; }
        public int CountInPackage { get; set; }
        public DateOnly BeforeDate { get; set; }
        public bool IsLactoseFree { get; set; }
        public bool IsFarmer { get; set; }
        public bool IsVegan { get; set; }
        public string? Taste { get; set; }
        public List<FatContentProduct> FatContent { get; set; } = new();
        public bool IsBestseller { get; set; }
    }
}
