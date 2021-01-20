using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediHawker.Data.Mappings
{
    public class CON_CONSUMERS : IEntityTypeConfiguration<ConConsumers>
    {
        public void Configure(EntityTypeBuilder<ConConsumers> entity)
        {
            entity.HasKey(e => e.ConsumerId)
                    .HasName("PK_Consumers");

            entity.ToTable("CON_CONSUMERS");

            entity.Property(e => e.ConsumerId).HasColumnName("CONSUMER_ID");

            entity.Property(e => e.CartItemCount).HasColumnName("CART_ITEM_COUNT");

            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");

            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .HasColumnName("PASSWORD");

            entity.Property(e => e.Phone)
                .HasMaxLength(100)
                .HasColumnName("PHONE");

            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .HasColumnName("USER_NAME");
        }
    }
}
