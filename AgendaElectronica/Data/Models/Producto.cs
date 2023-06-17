using AgendaElectronica.Data.Request;
using AgendaElectronica.Data.Response;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaElectronica.Data.Models;

public class Producto
{
    [Key]
    public int Id { get; set; }
    public string Codigo { get; set; } = null!;
    public string Descripcion { get; set; } = null!;
    public int Stock { get; set; }
    [Column(TypeName ="decimal(18,2)")]
    public decimal Precio { get; set; }
    public Producto Crear(ProductoRequest request) => new() {
        Codigo = request.Codigo,
        Descripcion = request.Descripcion,
        Stock = request.Stock,
        Precio = request.Precio,
    };
    public ProductoResponse ToResponse() => new() { 
        Id = Id, 
        Codigo = Codigo,
        Descripcion = Descripcion,
        Stock = Stock,
        Precio = Precio
    };
}
