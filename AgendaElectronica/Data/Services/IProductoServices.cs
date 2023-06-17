using AgendaElectronica.Data.Response;

namespace AgendaElectronica.Data.Services
{
    public interface IProductoServices
    {
        Task<Result<List<ProductoResponse>>> Consultar(string filtro);
    }
}