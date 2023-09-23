using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Items.Domain.Components.Items;

namespace Items.Persistance.EntityTypeConfiguration
{
    public class ShopConfiguration : IEntityTypeConfiguration<Item>
    {
        public void Configure(EntityTypeBuilder<Item> builder)
        {
            builder.HasKey(item => item.ItemId);
            builder.HasIndex(item => item.ItemId).IsUnique();
            builder.Property(item => item.Brand).HasMaxLength(128);
        }
    }
}