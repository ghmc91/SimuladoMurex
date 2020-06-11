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
                .HasKey(i => i.MoId);


            builder
                .HasOne(m => m.Mo)
                .WithOne(c => c.Fx)
                .HasForeignKey<Mo>(m => m.MoId)
                .IsRequired();

            builder
                .Property(i => i.Broker)
                .HasColumnType("Varchar(45)");


        }
    }
}
