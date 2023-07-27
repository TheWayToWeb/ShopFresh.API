using Items.Domain.Models.Categories.Vegetables;

namespace Items.Domain.Entities.Categories.Vegetables.ConcreteBroccoli.Broccoli
{
    public class Broccoli : Vegetable
    {
        public Broccoli(GrowBroccoli broccoli)
        {
            PersonId = broccoli.personId;
            ItemId = broccoli.itemId;
            Price = broccoli.price;
            ImagePath = broccoli.imagePath;
            Maker = broccoli.maker;
            MinTemp = broccoli.minTemp;
            MaxTemp = broccoli.maxTemp;
            Protein = broccoli.protein;
            Fat = broccoli.fat;
            Sugar = broccoli.sugar;
            Energy = broccoli.energy;
            CountInPackage = broccoli.countInPackage;
            CreatedDate = broccoli.createdDate;
            Weight = broccoli.weight;
            CoolingMode = broccoli.coolingMode;
            Grade = broccoli.grade;
        }
    }
}
