using AgendaElectronica.Data.Request;
using AgendaElectronica.Data.Response;
using Microsoft.AspNetCore.ResponseCaching;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AgendaElectronica.Data.Models
{
    public class Contacto
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Direccion { get; set; } = null!;
        public int? CiudadId { get; set; }
        [ForeignKey("CiudadId")]
        public virtual Ciudad? Ciudad { get; set; }

        public static Contacto Crear(ContactoRequest contacto)
        => new()
        {
            Nombre = contacto.Nombre,
            Telefono = contacto.Telefono,
            Direccion = contacto.Direccion,
            CiudadId = contacto.CiudadId
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
            if(CiudadId != contacto.CiudadId)
            {
                CiudadId = contacto.CiudadId;
                cambio = true;
            }
            return cambio;
        }

        public ContactoResponse ToResponse()
        => new()
        {
            Id = Id,
            Nombre = Nombre,
            Telefono = Telefono,
            Direccion = Direccion,
            CiudadId = CiudadId,
            Ciudad = Ciudad != null? Ciudad!.ToResponse():null
        };
    }
}
