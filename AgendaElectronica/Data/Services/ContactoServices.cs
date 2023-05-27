using AgendaElectronica.Data.Context;
using AgendaElectronica.Data.Models;
using AgendaElectronica.Data.Request;
using AgendaElectronica.Data.Response;
using Microsoft.EntityFrameworkCore;

namespace AgendaElectronica.Data.Services
{
    public class ContactoServices : IContactoServices
    {
        private readonly IAgendaElectronicaDbContext dbContext;

        public ContactoServices(IAgendaElectronicaDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Result> Crear(ContactoRequest request)
        {
            try
            {
                var contacto = Contacto.Crear(request);
                dbContext.Contactos.Add(contacto);
                await dbContext.SaveChangesAsync();
                return new Result() { Message = "Ok", Success = true };
            }
            catch (Exception E)
            {

                return new Result() { Message = E.Message, Success = false };
            }
        }
        public async Task<Result> Modificar(ContactoRequest request)
        {
            try
            {
                var contacto = await dbContext.Contactos
                    .FirstOrDefaultAsync(c => c.Id == request.Id);
                if (contacto == null)
                    return new Result() { Message = "No se encontro el contacto", Success = false };

                if (contacto.Mofidicar(request))
                    await dbContext.SaveChangesAsync();

                return new Result() { Message = "Ok", Success = true };
            }
            catch (Exception E)
            {

                return new Result() { Message = E.Message, Success = false };
            }
        }
        public async Task<Result> Eliminar(ContactoRequest request)
        {
            try
            {
                var contacto = await dbContext.Contactos
                    .FirstOrDefaultAsync(c => c.Id == request.Id);
                if (contacto == null)
                    return new Result() { Message = "No se encontro el contacto", Success = false };

                dbContext.Contactos.Remove(contacto);
                await dbContext.SaveChangesAsync();
                return new Result() { Message = "Ok", Success = true };
            }
            catch (Exception E)
            {

                return new Result() { Message = E.Message, Success = false };
            }
        }
        public async Task<Result<List<ContactoResponse>>> Consultar(string filtro)
        {
            try
            {
                var contactos = await dbContext.Contactos
                    .Include(c=>c.Ciudad)
                    .Where(c =>
                        (c.Nombre + " " + c.Telefono + " " + c.Direccion)
                        .ToLower()
                        .Contains(filtro.ToLower()
                        )
                    )
                    .Select(c => c.ToResponse())
                    .ToListAsync();
                return new Result<List<ContactoResponse>>()
                {
                    Message = "Ok",
                    Success = true,
                    Data = contactos
                };
            }
            catch (Exception E)
            {
                return new Result<List<ContactoResponse>>
                {
                    Message = E.Message,
                    Success = false
                };
            }
        }

    }
}
