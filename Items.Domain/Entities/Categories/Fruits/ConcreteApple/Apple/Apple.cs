using FruitSelf = Items.Domain.Entities.Categories.Fruits.Fruit.Fruit;
using Line = Items.Domain.Entities.Categories.Common.Range;

namespace Items.Domain.Entities.Categories.Fruits.ConcreteApple.Apple
{
    public class Apple : FruitSelf
    {
        public string? Grade { get; set; }
        public List<Line>? SaleWeights { get; set; }

        public Apple(GrowApple apple)
        {
            PersonId =  apple.personId;
            ItemId =    apple.itemId;
            Price =     apple.price;
            ImagePath = apple.imagePath;
            Maker =     apple.maker;
            MinTemp =   apple.minTemp;
            MaxTemp =   apple.maxTemp;
            Protein =   apple.protein;
            Fat =       apple.fat;
            Sugar =     apple.sugar;
            Energy =    apple.energy;
            CountInPackage = apple.countInPackage;
            IsFarmer =  apple.isFarmer;
            Grade =     apple.grade;
            SaleWeights = apple.saleWeights;
        }
    }
}
