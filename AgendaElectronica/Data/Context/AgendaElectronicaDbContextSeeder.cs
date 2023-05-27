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
        }
    }
}
