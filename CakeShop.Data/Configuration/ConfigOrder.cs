using CakeShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CakeShop.Data.Configuration
{
    public class ConfigOrder : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Orders");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();
            builder.Property(x => x.OrderDate).IsRequired();
            builder.Property(x => x.ShipAddress).IsRequired().HasMaxLength(500);
            builder.Property(x => x.ShipEmail).IsRequired().HasMaxLength(100).IsUnicode(false);
            builder.Property(x => x.ShipName).IsRequired().HasMaxLength(100);
            builder.Property(x => x.ShipPhoneNumber).IsRequired().HasMaxLength(50);
            builder.HasOne(x => x.User).WithMany(x => x.Orders).HasForeignKey(x => x.UserId);
        }
    }
}
