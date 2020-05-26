using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SimuladoMurex.Domain.Entities;

namespace SimuladoMurex.Infra.Data.Mappings
{
    public class MoMappings : IEntityTypeConfiguration<Mo>
    {
        public void Configure(EntityTypeBuilder<Mo> builder)
        {
            builder
                .ToTable("Mo")
                .HasKey(i => i.MoId);

            builder
                .Property(i => i.TradeDate);

            builder
                .Property(i => i.Counterparty)
                .HasColumnType("VARCHAR (45)");

            builder
                .HasOne(c => c.Cm)
                .WithOne(m => m.Mo)
                .HasForeignKey<Cm>(c => c.Mo);

            builder
                .HasOne(e => e.Eq)
                .WithOne(m => m.Mo)
                .HasForeignKey<Eq>(e => e.Mo);

            builder
                .HasOne(f => f.Fx)
                .WithOne(m => m.Mo)
                .HasForeignKey<Fx>(f => f.Mo);

            builder
                .HasOne(i => i.Ir)
                .WithOne(m => m.Mo)
                .HasForeignKey<Ir>(i => i.Mo);

            builder
                .HasOne(t => t.Typology)
                .WithMany(m => m.Mos);
        }
    }
}
