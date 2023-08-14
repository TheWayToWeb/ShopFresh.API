using Items.Domain.Entities.Categories.Vegetables.ConcreteCauliflower.Cauliflower;
using Items.Domain.Entities.Categories.Vegetables.Vegetable;
using SelfCauliflower = Items.Domain.Entities.Categories.Vegetables.ConcreteCauliflower.Cauliflower.Cauliflower;

namespace Items.Domain.Entities.Categories.Vegetables.ConcreteCauliflower
{
    public interface IBuilderCauliflower : IVegetable, ICauliflower
    {
        void SetPrice(int value);
        void SetImagePath(string value);
        void SetMaker(string value);
        void SetMinTemp(int value);
        void SetMaxTemp(int value);
        void SetProtein(float value);
        void SetFat(float value);
        void SetSugar(float value);
        void SetEnergy(float value);
        void SetCountInPackage(int value);
        void SetCreatedDate(int value);
        void SetWeight(float value);
        void SetCoolingMode(string value);
        SelfCauliflower CreateCauliflower();
    }
}
