//using AgendaElectronica.Data.Response;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;

//namespace AgendaElectronica.Data.Models;

//public class Factura
//{
//    public Factura()
//    {
//        Contacto = new Contacto();
//        Detalles = new List<FacturaDetalle>();
//    }
//    [Key]
//    public int Id { get; set; }
//    public int ContactoId { get; set; }
//    public DateTime Fecha { get; set; }
//    [ForeignKey(nameof(ContactoId))]
//    public virtual Contacto Contacto { get; set; }
//    public virtual ICollection<FacturaDetalle> Detalles { get; set; }

//    [NotMapped]
//    public decimal SubTotal =>
//        Detalles != null ? //IF
//        Detalles.Sum(d => d.SubTotal) //Verdadero
//        :
//        0;//Falso

//    public FacturaRespose ToResponse()
//        => new()
//        {
//            Id = Id,
//            ContactoId = ContactoId,
//            Fecha = Fecha,
//            Contacto = Contacto.ToResponse(),
//            Detalles = Detalles.Select(d=>d.ToResponse()).ToList()
//        };
//}
