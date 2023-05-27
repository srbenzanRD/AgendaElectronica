namespace AgendaElectronica.Data.Request
{
    public class ContactoRequest
    {
        public int Id { get; set; }
        public int? CiudadId { get; set; }
        public string Nombre { get; set; } = null!;
        public string Telefono { get; set; } = null!;
        public string Direccion { get; set; } = null!;
    }
}
