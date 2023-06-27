﻿using Items.Domain.Products.FreshItem.Bread;
using Cheesecake = Items.Domain.Products.FreshItem.Bread.
using Microsoft.EntityFrameworkCore;
using Items.Domain.Products.FreshItem.Bread.MaikingBaguette;
using Items.Domain.Products.FreshItem.Bread.MakingBun;
using Items.Domain.Products.FreshItem.Bread.MakingFlapJack;
using Items.Domain.Products.FreshItem.Bread.MakingCroissant;
using Items.Domain.Products.FreshItem.Bread.MakingPuff;
using Items.Domain.Products.FreshItem.Bread.MakingToast;
using Items.Domain.Products.FreshItem.Bread.MakingSimpleCake;
using Items.Domain.Products.FreshItem.Bread.MakingSingleFood;
using Items.Domain.Products.FreshItem.Bread.MakingCottageCheesePatty;

namespace Items.Application.Interfaces
{
    public interface IBreadDbContext : IProductDbContext
    {
        DbSet<Baguette> Baguettes { get; set; }
        DbSet<Bread> Bread { get; set; }
        DbSet<Bun> Buns { get; set; }
        DbSet<Croissant> Croissants { get; set; }
        DbSet<CottageCheesePatty> CottageCheesePatties { get; set; }
        DbSet<Flapjack> Flapjacks { get; set; }
        DbSet<Puff> Puff { get; set; }
        DbSet<SingleFood> SingleFoods { get; set; }
        DbSet<Toast> Toasts { get; set; }
        DbSet<SimpleCake> SimpleCakes { get; set; }
    }
}
