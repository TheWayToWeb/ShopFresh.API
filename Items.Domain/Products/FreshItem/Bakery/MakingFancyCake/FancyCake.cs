namespace Items.Domain.Products.FreshItem.Bakery.FactoryFancyCookie
{
    public class FancyCake : Bakery
    {
        public string? ProductKindItSelf { get; set; }
        public string? ProductTypeItSelf { get; set; }

        public FancyCake(
            Guid personId,
            Guid itemId,
            string? itemName,
            int price,
            string? imagePath
        ) 
        {
            PersonId = personId;
            ItemId = itemId;
            ItemName = itemName;
            Price = price;
            ImagePath = imagePath;
        }
    }
}
