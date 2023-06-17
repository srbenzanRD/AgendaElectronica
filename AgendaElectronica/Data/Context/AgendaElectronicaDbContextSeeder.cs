using AgendaElectronica.Data.Models;

namespace AgendaElectronica.Data.Context
{
    public class AgendaElectronicaDbContextSeeder
    {
        public static async Task Inicializar(AgendaElectronicaDbContext dbContext)
        {
            if (!dbContext.Ciudades.Any())
            {
                var ciudades = new List<Ciudad>() { 
                    new Ciudad(){ Nombre = "Cotuí"},
                    new Ciudad(){ Nombre = "La Mata"},
                    new Ciudad(){ Nombre = "La Bija"},
                    new Ciudad(){ Nombre = "Angelina"},
                    new Ciudad(){ Nombre = "Fantino"},
                    new Ciudad(){ Nombre = "Cevicos"},
                
                };
                dbContext.Ciudades.AddRange(ciudades);
                await dbContext.SaveChangesAsync();
            }
            if (!dbContext.Producto.Any())
            {
                var productos = new List<Producto>() {
                    new Producto(){ Descripcion = "Yuca", Codigo = "Y1", Precio = 100m, Stock = 10 },
                    new Producto(){ Descripcion = "Platano", Codigo = "P1", Precio = 100m, Stock = 10 },
                    new Producto(){ Descripcion = "Batata", Codigo = "B1", Precio = 100m, Stock = 10 },
                    new Producto(){ Descripcion = "Ñame", Codigo = "M1", Precio = 100m, Stock = 10 },
                    new Producto(){ Descripcion = "Pipiota", Codigo = "PI1", Precio = 100m, Stock = 10 },
                    new Producto(){ Descripcion = "Guineo", Codigo = "G1", Precio = 100m, Stock = 10 },
                };
                dbContext.Producto.AddRange(productos);
                await dbContext.SaveChangesAsync();
            }
        }
    }
}
