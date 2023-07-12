using Items.Domain.Models.Categories.Common;

namespace Items.Domain.Models
{
    public class Water : Drink
    {
        public Water(Guid personId, Guid itemId, string itemName, int price, string imagePath)
        {
            PersonId = personId;
            ItemId = itemId;
            ItemName = itemName;
            Price = price;
            ImagePath = imagePath;
        }

        public bool IsSparkling { get; set; }
        public string? Purpose { get; set; }
    }
}
