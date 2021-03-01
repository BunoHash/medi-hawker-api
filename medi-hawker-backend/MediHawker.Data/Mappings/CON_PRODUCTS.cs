using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediHawker.Data.Mappings
{
    class CON_PRODUCTS: IEntityTypeConfiguration<Products>
    {
        public void Configure(EntityTypeBuilder<Products> entity)
        {
            entity.HasKey(e => e.ProductId)
                     .HasName("PK_PRODUCTS_1");

            entity.ToTable("CON_PRODUCTS");

            entity.Property(e => e.ProductId).HasColumnName("PRODUCT_ID");

            entity.Property(e => e.Address).HasColumnName("ADDRESS");

            entity.Property(e => e.BuyingPrice)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("BUYING_PRICE");

            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");

            entity.Property(e => e.Dose).HasColumnName("DOSE");

            entity.Property(e => e.GenericId).HasColumnName("GENERIC_ID");

            entity.Property(e => e.GenericName)
                .HasMaxLength(100)
                .HasColumnName("GENERIC_NAME");

            entity.Property(e => e.ImgPath).HasColumnName("IMG_PATH");

            entity.Property(e => e.ManufacturerId).HasColumnName("MANUFACTURER_ID");

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("NAME");

            entity.Property(e => e.PaxCount)
                .HasMaxLength(100)
                .HasColumnName("PAX_COUNT");

            entity.Property(e => e.SellingPrice)
                .HasColumnType("decimal(18, 0)")
                .HasColumnName("SELLING_PRICE");

            entity.Property(e => e.UnitPrice).HasColumnName("UNIT_PRICE");
            entity.Property(e => e.Description).HasColumnName("DESCRIPTION");
        }
    }
}
