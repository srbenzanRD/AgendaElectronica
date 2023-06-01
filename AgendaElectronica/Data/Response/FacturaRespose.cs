using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaElectronica.Data.Response;

public class FacturaRespose
{
    public int Id { get; set; }
    public int ContactoId { get; set; }
    public DateTime Fecha { get; set; }
    public ContactoResponse Contacto { get; set; }
    public virtual ICollection<FacturaDetalleResponse> Detalles { get; set; }

    [NotMapped]
    public decimal SubTotal =>
        Detalles != null ? //IF
        Detalles.Sum(d => d.SubTotal) //Verdadero
        :
        0;//Falso
}
