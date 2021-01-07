using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediHawker.Data.Mappings
{
    class CON_CONSUMERS_PURCHASE_HISTORY : IEntityTypeConfiguration<ConConsumersPurchaseHistory>
    {
        public void Configure(EntityTypeBuilder<ConConsumersPurchaseHistory> entity)
        {
            entity.HasKey(e => e.PurchaseHistoryId)
                    .HasName("PK_CONSUMERS_PURCHASE_HISTORY");

            entity.ToTable("CON_CONSUMERS_PURCHASE_HISTORY");

            entity.Property(e => e.PurchaseHistoryId).HasColumnName("PURCHASE_HISTORY_ID");

            entity.Property(e => e.ConsumerId).HasColumnName("CONSUMER_ID");

            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");

            entity.Property(e => e.OrderId).HasColumnName("ORDER_ID");
        }
    }
}
