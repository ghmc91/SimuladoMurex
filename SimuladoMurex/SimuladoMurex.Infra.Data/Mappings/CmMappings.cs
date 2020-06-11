using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimuladoMurex.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SimuladoMurex.Infra.Data.Mappings
{
    public class CmMappings : IEntityTypeConfiguration<Cm>
    {
        public void Configure(EntityTypeBuilder<Cm> builder)
        {
            builder
                .ToTable("Cm")
                .HasKey(i => i.MoId);


            builder
                .HasOne(m => m.Mo)
                .WithOne(c => c.Cm)
                .HasForeignKey<Mo>(m => m.MoId)
                .IsRequired();

            builder
                .Property(i => i.Currency)
                .HasColumnType("Varchar (45)");

            builder
                .Property(i => i.Notional)
                .HasColumnType("Varchar (45)");

            builder
                .Property(i => i.Settlement);
                

        }
    }
}
