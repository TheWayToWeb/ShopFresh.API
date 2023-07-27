using AppleDomain = Items.Domain.Entities.Categories.Fruits.ConcreteApple.Apple.Apple;
using Line = Items.Domain.Entities.Categories.Common.Range;

namespace Items.Domain.Entities.Categories.Fruits.ConcreteApple
{
    public class GrowApple : IGrowerApple
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

        protected GrowApple(Guid personId, int countInPackage, int createdDate, List<Line> saleWeights) {
            this.personId = personId;
            this.countInPackage = countInPackage;
            this.createdDate = createdDate;
            this.saleWeights = saleWeights;
        }

        protected void Price(int value) => price = value;
        protected void ImagePath(string value) => imagePath = value;
        protected void Maker(string value) => maker = value;
        protected void MinTemp(int value) => minTemp = value;
        protected void MaxTemp(int value) => maxTemp = value;
        protected void Protein(float value) => protein = value;
        protected void Fat(float value) => fat = value;
        protected void Sugar(float value) => sugar = value;
        protected void Energy(float value) => energy = value;
        protected void CountInPackage(int value) => countInPackage = value;
        protected void CreatedDate(int value) => createdDate = value;
        protected void Weight(float value) => weight = value;
        protected void CoolingMode(string value) => coolingMode = value;
        protected void Grade(string value) => grade = value;
        protected void SaleWeights(List<Line> value) => saleWeights.AddRange(value);

        public AppleDomain CreateApple() {
            return new AppleDomain(this);
        }
    }
}
