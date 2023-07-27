using FruitSelf = Items.Domain.Entities.Categories.Fruits.Fruit.Fruit;
using Line = Items.Domain.Entities.Categories.Common.Range;

namespace Items.Domain.Entities.Categories.Fruits.ConcreteBanana.Banana
{
    public class Banana : FruitSelf
    {
        public string? Grade { get; set; }
        public List<Line> SaleWeights { get; set; } = new();

        public Banana(GrowBanana banana)
        {
            PersonId =  banana.personId;
            ItemId =    banana.itemId;
            Price =     banana.price;
            ImagePath = banana.imagePath;
            Maker =     banana.maker;
            MinTemp =   banana.minTemp;
            MaxTemp =   banana.maxTemp;
            Protein =   banana.protein;
            Fat =       banana.fat;
            Sugar =     banana.sugar;
            Energy =    banana.energy;
            CountInPackage = banana.countInPackage;
            CreatedDate = banana.createdDate;
            CoolingMode = banana.coolingMode;
            IsFarmer =  banana.isFarmer;
            Grade =     banana.grade;
            SaleWeights = banana.saleWeights;

        }
    }
}
