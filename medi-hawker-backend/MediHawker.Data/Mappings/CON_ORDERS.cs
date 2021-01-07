using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediHawker.Data.Mappings
{
    class CON_ORDERS : IEntityTypeConfiguration<ConOrders>
    {
        public void Configure(EntityTypeBuilder<ConOrders> entity)
        {
            entity.HasKey(e => e.OrderId)
                    .HasName("PK_ORDERS");

            entity.ToTable("CON_ORDERS");

            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");

            entity.Property(e => e.ConsumerId).HasColumnName("CONSUMER_ID");

            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");

            entity.Property(e => e.ItemCount).HasColumnName("ITEM_COUNT");

            entity.Property(e => e.TotalPrice).HasColumnName("TOTAL_PRICE");
        }
    }
}
