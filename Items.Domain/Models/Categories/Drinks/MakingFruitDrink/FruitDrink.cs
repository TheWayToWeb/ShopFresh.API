using Items.Domain.Models.Categories.Drinks.MakingJuice;

namespace Items.Domain.Models.Categories.Drinks.MakingFruitDrink
{
    public class FruitDrink : Juice
    {
        public FruitDrink(Guid personId, Guid itemId, string itemName, int price, string imagePath) : base(personId, itemId, itemName, price, imagePath)
        {
        }
    }
}
