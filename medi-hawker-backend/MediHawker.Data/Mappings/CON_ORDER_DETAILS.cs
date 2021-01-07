using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediHawker.Data.Mappings
{
    class CON_ORDER_DETAILS : IEntityTypeConfiguration<ConOrderDetails>
    {
        public void Configure(EntityTypeBuilder<ConOrderDetails> entity)
        {
            entity.HasKey(e => e.OrderDetailsId)
                    .HasName("PK_ORDER_DETAILS");

            entity.ToTable("CON_ORDER_DETAILS");

            entity.Property(e => e.OrderDetailsId).HasColumnName("ORDER_DETAILS_ID");

            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");

            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");

            entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");

            entity.Property(e => e.PurchaseCount).HasColumnName("PURCHASE_COUNT");

            entity.Property(e => e.TotalPrice).HasColumnName("TOTAL_PRICE");

            entity.Property(e => e.UnitPrice).HasColumnName("UNIT_PRICE");
        }
    }
}
