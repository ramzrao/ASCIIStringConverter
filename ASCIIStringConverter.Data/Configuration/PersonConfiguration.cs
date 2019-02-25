using ASCIIStringConverter.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ASCIIStringConverter.Data.Configuration
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {

            builder.Property(e => e.Id).HasColumnName("PersonID");

            builder.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(15);
            builder.Property(e => e.FirstName)
                .IsRequired()
                .HasMaxLength(15);

        }
    }
}
