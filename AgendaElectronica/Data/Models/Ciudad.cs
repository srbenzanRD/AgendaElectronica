using AgendaElectronica.Data.Response;
using System.ComponentModel.DataAnnotations;

namespace AgendaElectronica.Data.Models
{
    public class Ciudad
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;

        public CiudadResponse? ToResponse()=>new() 
        { 
            Id = Id, 
            Nombre = Nombre 
        };
    }
}
