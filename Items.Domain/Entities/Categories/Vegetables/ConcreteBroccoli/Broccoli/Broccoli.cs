using Items.Domain.Models.Categories.Vegetables;

namespace Items.Domain.Entities.Categories.Vegetables.ConcreteBroccoli.Broccoli
{
    public class Broccoli : Vegetable
    {
        public Broccoli(GrowBroccoli broccoli)
        {
            PersonId = broccoli.PersonId;
            ItemId = broccoli.ItemId;
            Price = broccoli.Price;
            ImagePath = broccoli.ImagePath;
            Maker = broccoli.Maker;
            MinTemp = broccoli.MinTemp;
            MaxTemp = broccoli.MaxTemp;
            Protein = broccoli.Protein;
            Fat = broccoli.Fat;
            Sugar = broccoli.Sugar;
            Energy = broccoli.Energy;
            CountInPackage = broccoli.CountInPackage;
            CreatedDate = broccoli.CreatedDate;
            Weight = broccoli.Weight;
            CoolingMode = broccoli.CoolingMode;
            Grade = broccoli.Grade;
        }
    }
}
