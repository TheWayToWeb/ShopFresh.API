using BeanDomain = Items.Domain.Entities.Categories.Vegetables.ConcreteBean.Bean.Bean;

namespace Items.Domain.Entities.Categories.Vegetables.ConcreteBean
{
    public interface IGrowerBean
    {
        BeanDomain CreateBean();
    }
}
