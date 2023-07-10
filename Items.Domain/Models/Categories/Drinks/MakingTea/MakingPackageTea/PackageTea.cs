using Items.Domain.Models.Categories.Common;
using Items.Domain.Models.Categories.Drinks.MakingTea;

namespace Items.Domain.Models.Categories.Drinks.MakingTea.MakingPackageTea
{
    public class PackageTea : Tea
    {
        public int SachetCount { get; set; }

        public PackageTea(
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
            string grade,
            string kindOfTea,
            int sashetCount
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
            Grade = grade;
            KindOfTea = kindOfTea;
            SachetCount = sashetCount;
        }
    }
}
