using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediHawker.Data.Mappings
{
    class CART : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> entity)
        {
            entity.ToTable("CART");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.CartItemId).HasColumnName("CART_ITEM_ID");

            entity.Property(e => e.ConsumerId).HasColumnName("CONSUMER_ID");

            entity.Property(e => e.ProductCount).HasColumnName("PRODUCT_COUNT");

            entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");

            entity.Property(e => e.SellingPrice)
                .HasColumnName("SELLING_PRICE")
                .HasColumnType("decimal(18, 0)");

            entity.Property(e => e.TotalPrice)
                .HasColumnName("TOTAL_PRICE")
                .HasColumnType("decimal(18, 0)");
        }

       
    }
}
