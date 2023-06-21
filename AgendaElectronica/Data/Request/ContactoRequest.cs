using AgendaElectronica.Data.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaElectronica.Data.Request;

public class ContactoRequest
{
    public int Id { get; set; }
    public int? CiudadId { get; set; }
    [Required(ErrorMessage = "El nombre del contacto es obligatorio")]
    public string Nombre { get; set; } = null!;
    [Required(ErrorMessage = "El teléfono del contacto es obligatorio")]
    public string Telefono { get; set; } = null!;
    [Required(ErrorMessage = "La dirección del contacto es obligatorio")]
    public string Direccion { get; set; } = null!;
}
public class FacturaRequest
{
    public int Id { get; set; }
    public int ContactoId { get; set; }
    public virtual ICollection<FacturaDetalleRequest> Detalles { get; set; } 
        = new List<FacturaDetalleRequest>();
    public decimal SubTotal => 
        Detalles != null ? 
        Detalles.Sum(d=>d.SubTotal)
        :
        0;
}
public class FacturaDetalleRequest
{
    public int Id { get; set; }
    public int ProductoId { get; set; }
    public string? Descripcion { get; set; }
    public int Cantidad { get; set; }
    public decimal Precio { get; set; }
    public decimal SubTotal => Cantidad * Precio;
}
public class ProductoRequest
{
    public int Id { get; set; }
    public string Codigo { get; set; } = null!;
    public string Descripcion { get; set; } = null!;
    public int Stock { get; set; }
    public decimal Precio { get; set; }
}
