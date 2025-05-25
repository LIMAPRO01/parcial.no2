using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TALLERMECANICA.Controllers
{
    [Route("api/Repuestos")]
    [ApiController]
    public class RepuestosController : ControllerBase
    {
        private static List<Models.Repuestos> repuestos = new List<Models.Repuestos>
        {
            new Models.Repuestos { id = 1, nombre = "pastillas de freno", precio =40},
            new Models.Repuestos { id = 2, nombre = "fricciones de freno", precio = 30},
            new Models.Repuestos { id = 3, nombre = "filtro de aire", precio = 15},
            new Models.Repuestos { id = 4, nombre = "llanta semi eslinck", precio =800},
            new Models.Repuestos { id = 5, nombre = "timon pro-traper", precio = 150 }
           
        };
        [HttpGet]
        public ActionResult<List<Models.Repuestos>> GetAll()
        {
            return repuestos;
        }
    }
}
