namespace Items.Domain.Products.FreshItem.Bakery.FactoryGingerbread
{
    public class Gingerbread : Bakery
    {
        public string? ProductKindItSelf { get; set; }

        public Gingerbread(Guid personId, Guid itemId, string? itemName, int price, string? imagePath)
        {
            PersonId = personId;
            ItemId = itemId;
            ItemName = itemName;
            Price = price;
            ImagePath = imagePath;
        }
    }
}
