﻿using PearDomain = Items.Domain.Entities.Categories.Fruits.ConcretePear.Pear.Pear;

namespace Items.Domain.Entities.Categories.Fruits.ConcretePear
{
    public class GrowPear : IGrowerPear
    {
        public Guid personId { get; private set; }
        public Guid itemId { get; private set; }
        public int price { get; private set; }
        public string imagePath { get; private set; }
        public string maker { get; private set; }
        public int minTemp { get; private set; }
        public int maxTemp { get; private set; }
        public float protein { get; private set; }
        public float fat { get; private set; }
        public float sugar { get; private set; }
        public float energy { get; private set; }
        public int countInPackage { get; private set; }
        public int createdDate { get; private set; }
        public float weight { get; private set; }
        public string coolingMode { get; private set; }
        public bool isFarmer { get; private set; }
        public string grade { get; private set; }

        public GrowPear(Guid personId) {
            this.personId = personId;
                itemId = Guid.NewGuid();
                price = 0;
                imagePath = string.Empty;
                maker = string.Empty;
                minTemp = 0;
                maxTemp = 0;
                protein = 0;
                fat = 0;
                sugar = 0;
                energy = 0;
                countInPackage = 1;
                createdDate = 8;
                weight = 1;
                coolingMode = string.Empty;
                isFarmer = false;
                grade = string.Empty;
        }

        public void Price(int value) => price = value;
        public void ImagePath(string value) => imagePath = value;
        public void Maker(string value) => maker = value;
        public void MinTemp(int value) => minTemp = value;
        public void MaxTemp(int value) => maxTemp = value;
        public void Protein(float value) => protein = value;
        public void Fat(float value) => fat = value;
        public void Sugar(float value) => sugar = value;
        public void Energy(float value) => energy = value;
        public void CountInPackage(int value) => countInPackage = value;
        public void CreatedDate(int value) => createdDate = value;
        public void Weight(float value) => weight = value;
        public void CoolingMode(string value) => coolingMode = value;
        public void IsFarmer(bool value) => isFarmer = value;
        public void Grade(string value) => grade = value;

        public PearDomain CreatePear() {
            return new PearDomain(
                personId,
                itemId,
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
                weight,
                coolingMode,
                isFarmer,
                grade
            );
        }
    }
}
