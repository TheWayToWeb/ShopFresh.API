using broccoliDomain = Items.Domain.Entities.Categories.Vegetables.ConcreteBroccoli.Broccoli.Broccoli;

namespace Items.Domain.Entities.Categories.Vegetables.ConcreteBroccoli
{
    public interface IGrowerBroccoli
    {
        void SetPrice(int value);
        void SetImagePath(string value);
        void SetMaker(string value);
        void SetMinTemp(int value);
        void SetMaxTemp(int value);
        void SetProtein(float value);
        void SetFat(float value);
        void SetEnergy(float value);
        void SetCountInPackage(int value);
        void SetCreatedDate(int value);
        void SetWeight(float value);
        void SetCoolingMode(string value);
        void SetGrade(string value);
        broccoliDomain CreateBroccoli();
    }
}
