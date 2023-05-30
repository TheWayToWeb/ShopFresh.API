namespace Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem
{
    public abstract class Item
    {
        public Guid PersonId { get; set; }
        public Guid ItemId { get; set; }
        public string? ItemName { get; set; }
        public string? Brand { get; set; }
        public int Price { get; set; }
        public string? ImagePath { get; set; }
        public string? Maker { get; set; }
    }
}