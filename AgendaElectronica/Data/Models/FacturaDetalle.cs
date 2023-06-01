//using AgendaElectronica.Data.Response;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace AgendaElectronica.Data.Models;

//public class FacturaDetalle
//{
//    public FacturaDetalle()
//    {
//        Factura = new Factura();
//    }
//    [Key]
//    public int Id { get; set; }
//    public int FacturaId { get; set; }
//    public string Descripcion { get; set; } = null!;
//    public int Cantidad { get; set; }
//    [Column(TypeName = "decimal(18,2)")]
//    public decimal Precio { get; set; }

//    [ForeignKey(nameof(FacturaId))]
//    public virtual Factura Factura { get; set; }

//    [NotMapped]
//    public decimal SubTotal => Cantidad * Precio;

//    public FacturaDetalleResponse ToResponse()
//        => new()
//        {
//            Id = Id,
//            Descripcion = Descripcion,
//            Cantidad = Cantidad,
//            Precio = Precio,
//            FacturaId = FacturaId
//        };
//}
