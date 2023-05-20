using AgendaElectronica.Data.Request;

namespace AgendaElectronica.Data.Response
{
    public class ContactoResponse
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Direccion { get; set; } = null!;

        public ContactoRequest ToRequest() {
            return new ContactoRequest
            {
                Id = Id,
                Nombre = Nombre,
                Telefono = Telefono,
                Direccion = Direccion
            };
        }
    }
}
