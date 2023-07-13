using Items.Domain.Models.Categories.Common;
using Items.Domain.Models.Categories.Drinks.ConcreteWater.Water;

namespace Items.Domain.Models.Categories.Drinks.ConcreteLemonade.Lemonade
{
    public class Lemonade : Water
    {
        public Lemonade(Guid personId, Guid itemId, string itemName, int price, string imagePath, string maker, int minTemp, int maxTemp, float protein, float fat, float sugar, float energy, int countInPackage, int createdDate, List<Taste> tastes, List<Capacity> capacities, bool isChilled, bool isSparkling, string purpose)
        {
            PersonId = personId;
            ItemId = itemId;
            ItemName = itemName;
            Price = price;
            ImagePath = imagePath;
            Maker = maker;
            MinTemp = minTemp;
            MaxTemp = maxTemp;
            Protein = protein;
            Fat = fat;
            Sugar = sugar;
            Energy = energy;
            CountInPackage = countInPackage;
            CreatedDate = createdDate;
            Tastes = tastes;
            Capacities = capacities;
            IsChilled = isChilled;
            IsSparkling = isSparkling;
            Purpose = purpose;
        }

        public Guid PersonId { get; }
        public Guid ItemId { get; }
        public string ItemName { get; }
        public int Price { get; }
        public string ImagePath { get; }
        public string Maker { get; }
        public int MinTemp { get; }
        public int MaxTemp { get; }
        public float Protein { get; }
        public float Fat { get; }
        public float Sugar { get; }
        public float Energy { get; }
        public int CountInPackage { get; }
        public int CreatedDate { get; }
        public List<Taste> Tastes { get; }
        public List<Capacity> Capacities { get; }
        public bool IsChilled { get; }
        public bool IsSparkling { get; }
        public string Purpose { get; }
    }
}
