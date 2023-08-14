using Items.Domain.Entities.Categories.Vegetables.ConcretePotato.Potato;
using Items.Domain.Entities.Categories.Vegetables.Vegetable;
using SelfPotato = Items.Domain.Entities.Categories.Vegetables.ConcretePotato.Potato.Potato;

namespace Items.Domain.Entities.Categories.Vegetables.ConcretePotato
{
    public interface IBuilderPotato : IVegetable, IPotato
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
        void SetFarmer(bool value);
        void SetCoolingMode(string value);
        SelfPotato CreatePotato();
    }
}
