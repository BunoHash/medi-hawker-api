using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediHawker.Data.Mappings
{
    class CON_PRODUCTS : IEntityTypeConfiguration<ConProducts>
    {
        public void Configure(EntityTypeBuilder<ConProducts> entity)
        {
            entity.HasKey(e => e.ProductId)
                    .HasName("PK_PRODUCTS_1");

            entity.ToTable("CON_PRODUCTS");

            entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");

            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");

            entity.Property(e => e.Dose).HasColumnName("DOSE");

            entity.Property(e => e.GenericName)
                .HasMaxLength(100)
                .HasColumnName("GENERIC_NAME");

            entity.Property(e => e.ManufacturerId).HasColumnName("MANUFACTURER_ID");

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("NAME");

            entity.Property(e => e.PaxCount)
                .HasMaxLength(100)
                .HasColumnName("PAX_COUNT");

            entity.Property(e => e.UnitPrice).HasColumnName("UNIT_PRICE");
        }
    }
}
