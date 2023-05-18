using AgendaElectronica.Data.Request;
using AgendaElectronica.Data.Response;
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

        public static Contacto Crear(ContactoRequest contacto)
        => new()
        {
            Nombre = contacto.Nombre,
            Telefono = contacto.Telefono,
            Direccion = contacto.Direccion,
        };
        public bool Mofidicar(ContactoRequest contacto)
        {
            var cambio = false;
            if(Nombre != contacto.Nombre)
            {
                Nombre = contacto.Nombre;
                cambio = true;
            }
            if (Telefono != contacto.Telefono)
            {
                Telefono = contacto.Telefono;
                cambio = true;
            }
            if(Direccion != contacto.Direccion)
            {
                Direccion = contacto.Direccion;
                cambio = true;
            }
            return cambio;
        }

        public ContactoResponse ToResponse()
        => new()
        {
            Nombre = Nombre,
            Telefono = Telefono,
            Direccion = Direccion
        };
    }
}
