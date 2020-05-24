using Microsoft.EntityFrameworkCore;
using SimuladoMurex.Domain.Entities;
using SimuladoMurex.Infra.Data.Extensions;

namespace SimuladoMurex.Infra.Data.Context
{
    public class SimuladoMurexContext : DbContext
    {
        public SimuladoMurexContext(DbContextOptions<SimuladoMurexContext> options)
            : base(options)
        {

        }

        public DbSet<Mo> Mos { get; set; }
        public DbSet<Cm> Cms { get; set; }
        public DbSet<Eq> Eqs { get; set; }
        public DbSet<Fx> Fxs { get; set; }
        public DbSet<Ir> Irs { get; set; }
        public DbSet<Typology> Typologies { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.LoadMappings();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseMySql("server=127.0.0.1;user id=root;database=simuladomurex");
        }
    }
}
