using Items.Domain.Products.Templates;

namespace Items.Domain.Products.FreshItem.Drinks.MakingEnergyDrink
{
    public class EnergyDrink : Drink
    {
        public List<SaleStatus>? Sales { get; set; } = new();
        public float Coffein { get; set; }

        public EnergyDrink(Guid personId, Guid itemId, string itemName, int price, string imagePath)
        {
            PersonId = personId;
            ItemId = itemId;
            ItemName = itemName;
            Price = price;
            ImagePath = imagePath;
        }
    }
}
