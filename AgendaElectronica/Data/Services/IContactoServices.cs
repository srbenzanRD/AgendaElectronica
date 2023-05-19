using AgendaElectronica.Data.Request;
using AgendaElectronica.Data.Response;

namespace AgendaElectronica.Data.Services
{
    public interface IContactoServices
    {
        Task<Result<List<ContactoResponse>>> Consultar(string filtro);
        Task<Result> Crear(ContactoRequest request);
        Task<Result> Eliminar(ContactoRequest request);
        Task<Result> Modificar(ContactoRequest request);
    }
}