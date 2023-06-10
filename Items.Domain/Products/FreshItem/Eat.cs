namespace Items.Domain.Products.FreshItem
{
    public abstract class Eat : Item
    {
        public string? Shape { get; set; }
        public float? Weight { get; set; }
        public string? Contain { get; set; }
        public string? CoolingMode { get; set; }
        public bool IsFarmer { get; set; }
    }
}
