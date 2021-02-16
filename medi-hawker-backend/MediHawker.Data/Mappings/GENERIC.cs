using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediHawker.Data.Mappings
{
    public class GENERIC :IEntityTypeConfiguration<Generic>
    {
        public void Configure(EntityTypeBuilder<Generic> entity)
        {

            entity.ToTable("GENERIC");

            entity.Property(e => e.Id).HasColumnName("ID");

            entity.Property(e => e.Description).HasColumnName("DESCRIPTION");
            entity.Property(e => e.Pharmacology).HasColumnName("PHARMACOLOGY");
            entity.Property(e => e.Indication).HasColumnName("INDICATION");

            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("NAME");
        }
    }
}
