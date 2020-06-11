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
                .HasKey(i => i.MoId);


            builder
                .HasOne(m => m.Mo)
                .WithOne(c => c.Eq)
                .HasForeignKey<Mo>(m => m.MoId)
                .IsRequired();
        }
    }
}
