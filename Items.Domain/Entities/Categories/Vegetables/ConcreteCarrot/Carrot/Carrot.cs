using Items.Domain.Models.Categories.Vegetables;
using Range = Items.Domain.Models.Categories.Common.Range;

namespace Items.Domain.Entities.Categories.Vegetables.ConcreteCarrot.Carrot
{
    public class Carrot : Vegetable
    {
        public bool IsWash { get; set; }
    }
}
