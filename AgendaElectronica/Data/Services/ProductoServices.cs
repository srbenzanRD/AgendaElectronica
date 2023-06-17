using AgendaElectronica.Data.Context;
using AgendaElectronica.Data.Response;
using Microsoft.EntityFrameworkCore;

namespace AgendaElectronica.Data.Services;

public class ProductoServices : IProductoServices
{
    private readonly IAgendaElectronicaDbContext context;

    public ProductoServices(IAgendaElectronicaDbContext context)
    {
        this.context = context;
    }

    public async Task<Result<List<ProductoResponse>>> Consultar(string filtro)
    {
        try
        {
            var contactos = await context.Producto
                .Where(c =>
                    (c.Descripcion)
                    .ToLower()
                    .Contains(filtro.ToLower()
                    )
                )
                .Select(c => c.ToResponse())
                .ToListAsync();
            return new Result<List<ProductoResponse>>()
            {
                Message = "Ok",
                Success = true,
                Data = contactos
            };
        }
        catch (Exception E)
        {
            return new Result<List<ProductoResponse>>
            {
                Message = E.Message,
                Success = false
            };
        }
    }

}
