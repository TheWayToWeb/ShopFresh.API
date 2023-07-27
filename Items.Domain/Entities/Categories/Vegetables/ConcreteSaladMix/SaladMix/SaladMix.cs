using Items.Domain.Entities.Categories.Vegetables.ConcreteSalad.Salad;
using Items.Domain.Models.Categories.Vegetables;

namespace Items.Domain.Entities.Categories.Vegetables.ConcreteSaladMix.SaladMix
{
    public class SaladMix : Vegetable
    {
        public List<Salad> GreeneryKinds { get; set; } = new();
    }
}
