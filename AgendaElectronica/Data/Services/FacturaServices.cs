using AgendaElectronica.Data.Context;
using AgendaElectronica.Data.Models;
using AgendaElectronica.Data.Request;
using AgendaElectronica.Data.Response;
using Microsoft.EntityFrameworkCore;

namespace AgendaElectronica.Data.Services;

public class FacturaServices : IFacturaServices
{
    private readonly IAgendaElectronicaDbContext dbContext;

    public FacturaServices(IAgendaElectronicaDbContext dbContext)
    {
        this.dbContext = dbContext;
    }
    public async Task<Result<List<FacturaRespose>>> Consultar()
    {
        try
        {
            var facturas = await dbContext.Facturas
                .Include(f => f.Contacto)
                .Include(f => f.Detalles)
                .ThenInclude(d => d.Producto)
                .Select(f => f.ToResponse())
                .ToListAsync();
            return new Result<List<FacturaRespose>>()
            {
                Data = facturas,
                Success = true,
                Message = "Ok"
            };
        }
        catch (Exception E)
        {
            return new Result<List<FacturaRespose>>()
            {
                Data = null,
                Success = false,
                Message = E.Message
            };
        }
    }

    public async Task<Result<FacturaRespose>> Crear(FacturaRequest request)
    {
        try
        {
            var factura = Factura.Crear(request);
            dbContext.Facturas.Add(factura);
            await dbContext.SaveChangesAsync();
            return new Result<FacturaRespose>()
            {
                Data = factura.ToResponse(),
                Success = true,
                Message = "Ok"
            };
        }
        catch (Exception E)
        {
            return new Result<FacturaRespose>()
            {
                Data = null,
                Success = false,
                Message = E.Message
            };
        }
    }
}
