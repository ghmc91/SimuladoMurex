using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimuladoMurex.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimuladoMurex.Infra.Data.Mappings
{
    public class TypologyMappings : IEntityTypeConfiguration<Typology>
    {
        public void Configure(EntityTypeBuilder<Typology> builder)
        {
            builder
                .ToTable("Typology")
                .HasKey(i => i.TypologyId);

            builder
                .Property(i => i.TypologyName)
                .HasColumnType("Varchar (20)");

        }
    }
}
