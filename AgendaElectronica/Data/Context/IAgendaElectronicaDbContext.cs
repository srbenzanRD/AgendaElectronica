using AgendaElectronica.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AgendaElectronica.Data.Context
{
    public interface IAgendaElectronicaDbContext
    {
        public DbSet<Contacto> Contactos { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<FacturaDetalle> FacturasDetalles { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}