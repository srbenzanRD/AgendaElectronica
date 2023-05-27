using AgendaElectronica.Data.Response;

namespace AgendaElectronica.Data.Services
{
    public interface ICiudadesServices
    {
        Task<Result<List<CiudadResponse>>> Consultar();
    }
}