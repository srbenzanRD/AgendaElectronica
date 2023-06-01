//using AgendaElectronica.Data.Context;
//using AgendaElectronica.Data.Models;
//using AgendaElectronica.Data.Response;
//using Microsoft.EntityFrameworkCore;

//namespace AgendaElectronica.Data.Services;

//public class FacturaServices
//{
//    private readonly IAgendaElectronicaDbContext dbContext;

//    public FacturaServices(IAgendaElectronicaDbContext dbContext)
//    {
//        this.dbContext = dbContext;
//    }
//    public async Task<Result<List<FacturaRespose>>> Consultar()
//    {
//		try
//		{
//            var facturas = await dbContext.Facturas
//                .Select(f=>f.ToResponse())
//                .ToListAsync();
//            return new Result<List<FacturaRespose>>() { 
//                Data =  facturas, 
//                Success = true, 
//                Message = "Ok" };
//		}
//		catch (Exception E)
//		{
//            return new Result<List<FacturaRespose>>()
//            {
//                Data = null,
//                Success = false,
//                Message = E.Message
//            };
//        }
//    }
//}
