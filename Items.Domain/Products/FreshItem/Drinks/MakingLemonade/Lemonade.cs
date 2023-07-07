using Items.Domain.Products.FreshItem.Drinks.MakingWater;

namespace Items.Domain.Products.FreshItem.Drinks.MakingLemonade
{
    public class Lemonade : Water
    {
        public Lemonade(Guid personId, Guid itemId, string itemName, int price, string imagePath) : base(personId, itemId, itemName, price, imagePath)
        {
        }
    }
}
