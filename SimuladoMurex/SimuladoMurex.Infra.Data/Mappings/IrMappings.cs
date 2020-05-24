using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimuladoMurex.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimuladoMurex.Infra.Data.Mappings
{
    public class IrMappings : IEntityTypeConfiguration<Ir>
    {
        public void Configure(EntityTypeBuilder<Ir> builder)
        {
            builder
                .ToTable("Ir")
                .HasKey(i => i.Mo);

            builder
                .Property(i => i.Isin)
                .HasColumnType("Varchar(45)");
        }
    }
}
