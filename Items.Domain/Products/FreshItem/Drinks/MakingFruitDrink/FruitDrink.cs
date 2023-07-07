using Items.Domain.Products.FreshItem.Drinks.MakingJuice;

namespace Items.Domain.Products.FreshItem.Drinks.MakingFruitDrink
{
    public class FruitDrink : Juice
    {
        public FruitDrink(Guid personId, Guid itemId, string itemName, int price, string imagePath) : base(personId, itemId, itemName, price, imagePath)
        {
        }
    }
}
