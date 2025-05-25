using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TALLERMECANICA.Controllers
{
    [Route("api/Mecanico")]
    [ApiController]
    public class MecanicoController : ControllerBase
    {
        private static List<Models.Mecanico> mecanicos = new List<Models.Mecanico>
        {
            new Models.Mecanico { id = 1, nombre = "MARTA", telefono = "78945612" },
            new Models.Mecanico { id = 2, nombre = "DANIEL", telefono = "78451201" },
            new Models.Mecanico { id = 3, nombre = "MARIO", telefono = "73910246" },
            new Models.Mecanico { id = 4, nombre = "ROSA", telefono = "98765421" },
            new Models.Mecanico { id = 5, nombre = "SERGIO", telefono = "88557724" }
        };
        [HttpGet]
        public ActionResult<List<Models.Mecanico>> GetAll()
        {
            return mecanicos;
        }
    }
}
