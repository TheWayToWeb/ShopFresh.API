namespace Items.Domain.Products.Category.SubCategory.FreshGroup.FreshItem.Eggs
{
    public class Egg : Eatable
    {
        public string? Category { get; set; }
        public string? Kind { get; set; }
        public string? Package { get; set; }
        public bool IsFarmer { get; set; }
    }
}
