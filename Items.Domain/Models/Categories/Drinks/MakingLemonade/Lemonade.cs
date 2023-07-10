using Items.Domain.Models.Categories.Drinks.MakingWater;

namespace Items.Domain.Models.Categories.Drinks.MakingLemonade
{
    public class Lemonade : Water
    {
        public Lemonade(Guid personId, Guid itemId, string itemName, int price, string imagePath) : base(personId, itemId, itemName, price, imagePath)
        {
        }
    }
}
