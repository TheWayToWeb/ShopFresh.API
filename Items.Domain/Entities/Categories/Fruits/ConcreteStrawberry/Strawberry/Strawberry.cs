using FruitSelf = Items.Domain.Entities.Categories.Fruits.Fruit.Fruit;

namespace Items.Domain.Entities.Categories.Fruits.ConcreteStrawberry.Strawberry
{
    public class Strawberry : FruitSelf
    {
        public string? Grade { get; set; }

        public Strawberry(GrowStrawberry strawberry)
        {
            PersonId = strawberry.personId;
            ItemId = strawberry.itemId;
            Price = strawberry.price;
            ImagePath = strawberry.imagePath;
            Maker = strawberry.maker;
            MinTemp = strawberry.minTemp;
            MaxTemp = strawberry.maxTemp;
            Protein = strawberry.protein;
            Fat = strawberry.fat;
            Sugar = strawberry.sugar;
            Energy = strawberry.energy;
            CountInPackage = strawberry.countInPackage;
            CreatedDate = strawberry.createdDate;
            Weight = strawberry.weight;
            CoolingMode = strawberry.coolingMode;
            IsFarmer = strawberry.isFarmer;
            Grade = strawberry.grade;
        }
    }
}
