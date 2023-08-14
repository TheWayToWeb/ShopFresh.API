using Items.Domain.Entities.Categories.Vegetables.ConcreteBean.Bean;
using Items.Domain.Entities.Categories.Vegetables.ConcreteBeet.Beet;
using Items.Domain.Entities.Categories.Vegetables.ConcreteBroccoli.Broccoli;
using Items.Domain.Entities.Categories.Vegetables.ConcreteCabbage.Cabbage;
using Items.Domain.Entities.Categories.Vegetables.ConcreteCarrot.Carrot;
using Items.Domain.Entities.Categories.Vegetables.ConcreteCauliflower.Cauliflower;
using Items.Domain.Entities.Categories.Vegetables.ConcreteMushroom.Mushroom;
using Items.Domain.Entities.Categories.Vegetables.ConcretePotato.Potato;
using Items.Domain.Entities.Categories.Vegetables.ConcreteRedis.Redis;
using Items.Domain.Entities.Categories.Vegetables.ConcreteSalad.Salad;
using Items.Domain.Entities.Categories.Vegetables.ConcreteSaladMix.SaladMix;
using Items.Domain.Entities.Categories.Vegetables.ConcreteSquash.Squash;
using Items.Domain.Entities.Categories.Vegetables.ConcreteTomato.Tomato;
using Items.Domain.Entities.Categories.Vegetables.ConcreteVegetableMix.VegetableMix;
using Items.Domain.Entities.Categories.Vegetables.Vegetable;
using Microsoft.EntityFrameworkCore;

namespace Items.Application.Interfaces
{
    public interface IVegetableDbContext : IProductDbContext
    {
        DbSet<Vegetable> Vegetables { get; set; }
        DbSet<Beet> Beets { get; set; }
        DbSet<Сabbage> Сabbage { get; set; }
        DbSet<Carrot> Carrots { get; set; }
        DbSet<Cauliflower> Cauliflowers { get; set; }
        DbSet<Squash> Squashes { get; set; }
        DbSet<Potato> Potatos { get; set; }
        DbSet<Redis> Redises { get; set; }
        DbSet<Salad> Salads { get; set; }
        DbSet<SaladMix> SaladMixes { get; set; }
        DbSet<Tomato> Tomatoes { get; set; }
        DbSet<Mushroom> Mushrooms { get; set; }
        DbSet<Bean> Beans { get; set; }
        DbSet<VegetableMix> VegetableMixes { get; set; }
        DbSet<Broccoli> Broccoli { get; set; }
    }
}
