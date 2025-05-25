using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TALLERMECANICA.Controllers
{
    [Route("api/Servicios")]
    [ApiController]
    public class ServiciosController : ControllerBase
    {
        private static List<Models.Servicios> servicios = new List<Models.Servicios>
        {
            new Models.Servicios { id = 1, categoria = "servicio menor ", precio = 200 },
            new Models.Servicios { id = 2, categoria = "servicio neutral", precio = 500 },
            new Models.Servicios { id = 3, categoria = "servicio mayor", precio = 1000 }
        };
        [HttpGet]
        public ActionResult<List<Models.Servicios>> GetAll()
        {
            return servicios;
        }
    }
}
