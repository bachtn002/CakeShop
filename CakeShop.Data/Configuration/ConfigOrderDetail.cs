﻿using CakeShop.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CakeShop.Data.Configuration
{
    public class ConfigOrderDetail : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetails");
            builder.HasKey(x => new { x.OrderId, x.ProductId });
            builder.HasOne(x => x.Order).WithMany(x => x.OrderDetails).HasForeignKey(x => x.OrderId);
            builder.HasOne(x => x.Product).WithMany(x => x.OrderDetails).HasForeignKey(x => x.ProductId);
            builder.Property(x => x.Price).HasColumnType("decimal");

        }
    }
}
