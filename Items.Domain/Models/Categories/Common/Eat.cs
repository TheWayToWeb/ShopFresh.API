namespace Items.Domain.Models.Categories.Common
{
    public abstract class Eat : Item
    {
        public float? Weight { get; set; }
        public string? CoolingMode { get; set; }
        public bool IsFarmer { get; set; }
    }
}
