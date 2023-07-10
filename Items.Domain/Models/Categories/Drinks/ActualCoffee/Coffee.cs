using Items.Domain.Models.Categories.Common;

namespace Items.Domain.Models.Categories.Drinks.ActualCoffee
{
    public class Coffee : Drink
    {
        public string? TypeCoffee { get; set; }
        public string? KindOfCofee { get; set; }
        public string? Consistency { get; set; }
        public string? Composition { get; set; }
        public string? TasteIntensity { get; set; }
        public bool IsCoffeinFree { get; set; }
        public string KindOfCoffee { get; }

        public Coffee(
            Guid personId,
            Guid itemId,
            string itemName,
            int price,
            string imagePath,
            string maker,
            int minTemp,
            int maxTemp,
            float protein,
            float fat,
            float sugar,
            float energy,
            int countInPackage,
            int createdDate,
            List<Taste> tastes,
            List<Capacity> capacities,
            bool isChilled,
            string typeCoffee,
            string kindOfCoffee,
            string consistency,
            string composition,
            string tasteIntensity,
            bool isCoffeinFree
        )
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
            TypeCoffee = typeCoffee;
            KindOfCoffee = kindOfCoffee;
            Consistency = consistency;
            Composition = composition;
            TasteIntensity = tasteIntensity;
            IsCoffeinFree = isCoffeinFree;
        }
    }
}
