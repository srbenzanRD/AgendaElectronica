using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaElectronica.Data.Response;

public class FacturaDetalleResponse
{
    public int Id { get; set; }
    public int FacturaId { get; set; }
    public ProductoResponse Producto { get; set; } = null!;
    public int Cantidad { get; set; }
    public decimal Precio { get; set; }

    [NotMapped]
    public decimal SubTotal => Cantidad * Precio;
}
