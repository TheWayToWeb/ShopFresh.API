﻿using Items.Domain.Products.Template;
using Items.Domain.Products.Templates;

namespace Items.Domain.Products.FreshItem.Drinks.MakingEnergyDrink
{
    public class MakeEnergyDrink : MakerEnergyDrink
    {
        public Guid PersonId { get; private set; }
        public Guid ItemId { get; private set; }
        public string  itemName { get; private set; } = "";
        public int  price { get; private set; } = 0;
        public string  imagePath { get; private set; } = "";
        public string  maker { get; private set; } = "";
        public int  minTemp { get; private set; } = 0;
        public int  maxTemp { get; private set; } = 0;
        public float  protein { get; private set; } = 0;
        public float  fat { get; private set; } = 0;
        public float  sugar { get; private set; } = 0;
        public float  energy { get; private set; } = 0;
        public int  countInPackage { get; private set; } = 0;
        public int  createdDate { get; private set; } = 0;
        public List<Taste>  tastes { get; private set; } = new();
        public List<Capacity>  capacities { get; private set; } = new();
        public bool  isChilled { get; private set; } = false;
        public List<SaleStatus>  sales { get; private set; } = new();
        public float  coffein { get; private set; } = 0;

        public void ItemName(string value) =>  itemName = value;
        public void Price(int value) =>  price = value;
        public void ImagePath(string value) =>  imagePath = value;
        public void Maker(string value) =>  maker = value;
        public void MinTemp(int value) =>  minTemp = value;
        public void MaxTemp(int value) =>  maxTemp = value;
        public void Protein(float value) =>  protein = value;
        public void Fat(float value) =>  fat = value;
        public void Sugar(float value) =>  sugar = value;
        public void Energy(float value) =>  energy = value;
        public void CountInPackage(int value) =>  countInPackage = value;
        public void CreatedDate(int value) =>  createdDate = value;
        public void Taste(List<Taste> value) =>  tastes.AddRange(value);
        public void Capacity(List<Capacity> value) =>  capacities.AddRange(value);
        public void IsChilled(bool value) =>  isChilled = value;
        public void SaleStatus(List<SaleStatus> value) =>  sales.AddRange(value);
        public void Coffein(float value) =>  coffein = value;

        public MakeEnergyDrink() { }

        public MakeEnergyDrink(Guid personId, string itemName, int price, string imagePath) {
                PersonId = personId;
                ItemId = Guid.NewGuid();
            this.itemName = itemName;
            this.price = price;
            this.imagePath = imagePath;
        }

        public override EnergyDrink CreateEnergyDrink()
        {
            return new EnergyDrink(
                PersonId,
                ItemId,
                itemName,
                price,
                imagePath,
                maker,
                minTemp,
                maxTemp,
                protein,
                fat,
                sugar,
                energy,
                countInPackage,
                createdDate,
                tastes,
                capacities,
                isChilled,
                sales,
                coffein
            );
        }
    }
}
