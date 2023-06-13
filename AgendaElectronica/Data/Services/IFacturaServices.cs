using AgendaElectronica.Data.Request;
using AgendaElectronica.Data.Response;

namespace AgendaElectronica.Data.Services
{
    public interface IFacturaServices
    {
        Task<Result<List<FacturaRespose>>> Consultar();
        Task<Result<FacturaRespose>> Crear(FacturaRequest request);
    }
}