namespace Items.Domain.Products.FreshItem.Drinks.MakingKissel
{
    public class Kissel : Drink
    {
        public Kissel(Guid personId, Guid itemId, string itemName, int price, string imagePath)
        {
            PersonId = personId;
            ItemId = itemId;
            ItemName = itemName;
            Price = price;
            ImagePath = imagePath;
        }
    }
}
