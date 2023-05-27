using AgendaElectronica.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AgendaElectronica.Data.Context
{
    public class AgendaElectronicaDbContext : DbContext, IAgendaElectronicaDbContext
    {
        private readonly IConfiguration config;

        public AgendaElectronicaDbContext(IConfiguration config)
        {
            this.config = config;
        }
        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(config.GetConnectionString("MSSQL"));
        }
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
