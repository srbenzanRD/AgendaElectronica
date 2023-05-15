using System.ComponentModel.DataAnnotations;

namespace AgendaElectronica.Data.Models
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Direccion { get; set; } = null!;
    }
}
