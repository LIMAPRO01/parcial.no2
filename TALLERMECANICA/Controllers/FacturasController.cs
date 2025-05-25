using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TALLERMECANICA.Controllers
{
    [Route("api/Facturas")]
    [ApiController]
    public class FacturasController : ControllerBase
    {
       
            private static List<Models.Facturas> facturas = new List<Models.Facturas>
        {
            new Models.Facturas { Id = 1, nombreCliente = "EDUARDO", nombreRepuesto = "pastillas de freno" },
            new Models.Facturas { Id = 2, nombreCliente = "JOSE", nombreRepuesto = "fricciones de freno" },
            new Models.Facturas { Id = 3, nombreCliente = "PERLA", nombreRepuesto = "filtro de aire" },
            new Models.Facturas { Id = 4, nombreCliente = "MARIO", nombreRepuesto = "llanta semi eslinck" },
            new Models.Facturas { Id = 5, nombreCliente = "PAMELA", nombreRepuesto = "timon pro-traper" }
        };
            [HttpGet]
            public ActionResult<List<Models.Facturas>> GetAll()
            {
                return facturas;
            }
        }
}
