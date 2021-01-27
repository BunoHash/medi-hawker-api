using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace MediHawker.Data.Mappings
{
    class CON_CONSUMERS_DETAILS : IEntityTypeConfiguration<ConsumersDetails>
    {
        public void Configure(EntityTypeBuilder<ConsumersDetails> entity)
        {
            entity.HasKey(e => e.ConsumerDetailsId)
                   .HasName("PK_CONSUMERS_DETAILS");

            entity.ToTable("CON_CONSUMERS_DETAILS");

            entity.Property(e => e.ConsumerDetailsId).HasColumnName("CONSUMER_DETAILS_ID");

            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .HasColumnName("ADDRESS");

            entity.Property(e => e.ConsumerId).HasColumnName("CONSUMER_ID");

            entity.Property(e => e.CreatedBy).HasColumnName("CREATED_BY");

            entity.Property(e => e.CreatedOn)
                .HasColumnType("datetime")
                .HasColumnName("CREATED_ON");

            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("EMAIL");

            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .HasColumnName("FIRST_NAME");

            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .HasColumnName("LAST_NAME");
        }
    }
}
