using AgendaElectronica.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AgendaElectronica.Data.Context
{
    public interface IAgendaElectronicaDbContext
    {
        public DbSet<Contacto> Contactos { get; set; }

        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}