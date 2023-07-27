using BananaDomain = Items.Domain.Entities.Categories.Fruits.ConcreteBanana.Banana.Banana;
using Line = Items.Domain.Entities.Categories.Common.Range;

namespace Items.Domain.Entities.Categories.Fruits.ConcreteBanana
{
    public class GrowBanana : IGrowerBanana
    {
        public Guid personId { get; private set; }
        public Guid itemId { get; private set; } = Guid.NewGuid();
        public int price { get; private set; }
        public string imagePath { get; private set; } = string.Empty;
        public string maker { get; private set; } = string.Empty;
        public int minTemp { get; private set; }
        public int maxTemp { get; private set; }
        public float protein { get; private set; }
        public float fat { get; private set; }
        public float sugar { get; private set; }
        public float energy { get; private set; }
        public int countInPackage { get; private set; }
        public int createdDate { get; private set; }
        public float? weight { get; private set; } = null;
        public string coolingMode { get; private set; } = string.Empty;
        public bool isFarmer { get; private set; }
        public string grade { get; private set; } = string.Empty;
        public List<Line> saleWeights { get; private set; } = new();

        public GrowBanana(Guid personId, int countInPackage, int createdDate, List<Line> saleWeights) {
            this.personId = personId;
            this.countInPackage = countInPackage;
            this.createdDate = createdDate;
            this.saleWeights = saleWeights;
        }

        public void Price(int value) => price = value;
        public void ImagePath(string value) => imagePath = value;
        public void Maker(string value) => maker = value;
        public void MinTemp(int value) => minTemp = value;
        public void MaxTemp(int value) => maxTemp = value;
        public void Protein(float value) => protein = value;
        public void Fat(float value) => fat = value;
        public void Sugar(float value) => sugar = value;
        public void Energy(float value) => energy = value;
        public void CountInPackage(int value) => countInPackage = value;
        public void CreatedDate(int value) => createdDate = value;
        public void Weight(float value) => weight = value;
        public void CoolingMode(string value) => coolingMode = value;
        public void Grade(string value) => grade = value;
        public void SaleWeight(List<Line> value) => saleWeights = value;

        public BananaDomain CreateBanana() {
            return new BananaDomain(this);
        }
    }
}
