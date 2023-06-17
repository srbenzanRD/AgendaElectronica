namespace AgendaElectronica.Data.Response;

public class ProductoResponse
{
    public int Id { get; set; }
    public string Codigo { get; set; } = null!;
    public string Descripcion { get; set; } = null!;
    public int Stock { get; set; }
    public decimal Precio { get; set; }

    public string CodigoDescripcion => $"({Codigo}) {Descripcion}";
}