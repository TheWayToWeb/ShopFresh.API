using Items.Domain.Models.Categories.Vegetables;

namespace Items.Domain.Entities.Categories.Vegetables.ConcreteRedis.Redis
{
    public class Redis : Vegetable
    {
        public string? SkinColor { get; set; }
    }
}
