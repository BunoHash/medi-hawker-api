using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediHawker.Data.Mappings
{
    class MANUFACTURER : IEntityTypeConfiguration<Manufacturer>
    {
        public void Configure(EntityTypeBuilder<Manufacturer> entity)
        {
            entity.ToTable("MANUFACTURER");

            entity.Property(e => e.ManufacturerId).HasColumnName("MANUFACTURER_ID");

            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .HasColumnName("ADDRESS");

            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("EMAIL");

            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("NAME");

            entity.Property(e => e.Phone).HasColumnName("PHONE");
        }

       
    }
}
