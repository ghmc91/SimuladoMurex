using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimuladoMurex.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimuladoMurex.Infra.Data.Mappings
{
    public class EqMappings : IEntityTypeConfiguration<Eq>
    {
        public void Configure(EntityTypeBuilder<Eq> builder)
        {
            builder
                .ToTable("Eq")
                .HasKey(i => i.Mo);
        }
    }
}
