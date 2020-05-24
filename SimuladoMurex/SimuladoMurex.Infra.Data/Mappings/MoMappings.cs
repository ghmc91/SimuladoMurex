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




        }
    }
}
