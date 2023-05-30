namespace Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.Cheese
{
    public class Cheese : Item
    {
        //hard, curd, semi-hard
        public string? Kind { get; set; }
        //cheddar, tilsiter
        public string? Type { get; set; }
        //sliced, portioned, toast
        public string? Shape { get; set; }
        public string? Raw { get; set; }
        public bool IsFarmer { get; set; }
    }
}
