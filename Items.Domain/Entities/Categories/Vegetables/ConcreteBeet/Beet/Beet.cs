using Items.Domain.Models.Categories.Vegetables;

namespace Items.Domain.Entities.Categories.Vegetables.ConcreteBeet.Beet
{
    public class Beet : Vegetable
    {
        public Beet(GrowBeet beet)
        {
            PersonId = beet.personId;
            ItemId = beet.itemId;
            Price = beet.price;
            ImagePath = beet.imagePath;
            Maker = beet.maker;
            MinTemp = beet.minTemp;
            MaxTemp = beet.maxTemp;
            Protein = beet.protein;
            Fat = beet.fat;
            Sugar = beet.sugar;
            Energy = beet.energy;
            CountInPackage = beet.countInPackage;
            CreatedDate = beet.createdDate;
            Weight = beet.weight;
            CoolingMode = beet.coolingMode;
            IsFarmer = beet.isFarmer;
            Grade = beet.grade;
            IsSlicingShape = beet.isSlicingShape;
        }
    }
}
