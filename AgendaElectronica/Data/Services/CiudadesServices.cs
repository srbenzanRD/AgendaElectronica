using AgendaElectronica.Data.Context;
using AgendaElectronica.Data.Response;
using Microsoft.EntityFrameworkCore;

namespace AgendaElectronica.Data.Services
{
    public class CiudadesServices : ICiudadesServices
    {
        private readonly IAgendaElectronicaDbContext dbContext;

        public CiudadesServices(IAgendaElectronicaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task<Result<List<CiudadResponse>>> Consultar()
        {
            try
            {
                var contactos = await dbContext.Ciudades
                    .Select(c => c.ToResponse())
                    .ToListAsync();
                return new Result<List<CiudadResponse>>()
                {
                    Message = "Ok",
                    Success = true,
                    Data = contactos!
                };
            }
            catch (Exception E)
            {
                return new Result<List<CiudadResponse>>
                {
                    Message = E.Message,
                    Success = false
                };
            }
        }

    }
}
