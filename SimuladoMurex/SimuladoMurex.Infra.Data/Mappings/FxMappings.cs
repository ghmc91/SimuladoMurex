using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimuladoMurex.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimuladoMurex.Infra.Data.Mappings
{
    public class FxMappings : IEntityTypeConfiguration<Fx>
    {
        public void Configure(EntityTypeBuilder<Fx> builder)
        {
            builder
                .ToTable("Fx")
                .HasKey(i => i.Mo);

            builder
                .Property(i => i.Broker)
                .HasColumnType("Varchar(45)");


        }
    }
}
