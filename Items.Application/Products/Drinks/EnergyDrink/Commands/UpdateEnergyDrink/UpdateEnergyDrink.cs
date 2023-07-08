﻿using Items.Domain.Products.Template;
using Items.Domain.Products.Templates;
using MediatR;

namespace Items.Application.Products.Drinks.EnergyDrink.Commands.UpdateEnergyDrink
{
    public class UpdateEnergyDrink : IRequest<Unit>
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
        public string ItemName { get; set; } = "";
        public int Price { get; set; }
        public string ImagePath { get; set; } = "";
        public string Maker { get; set; } = "";
        public int MinTemp { get; set; }
        public int MaxTemp { get; set; }
        public float Protein { get; set; }
        public float Fat { get; set; }
        public float Sugar { get; set; }
        public float Energy { get; set; }
        public int CountInPackage { get; set; }
        public int CreatedDate { get; set; }
        public List<Taste> Tastes { get; set; } = new();
        public List<Capacity> Capacities { get; set; } = new();
        public bool IsChilled { get; set; }
        public List<SaleStatus> Sales { get; set; } = new();
        public float Coffein { get; set; }
    }
}
