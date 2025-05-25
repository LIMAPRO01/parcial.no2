using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TALLERMECANICA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TallerController : ControllerBase
    {
        private static List<Models.Taller> talleres = new List<Models.Taller>
        {
            new Models.Taller { Id = 1, nombre = "Taller MONKEY", direccion = "zona 1 avenida elena" },
            new Models.Taller { Id = 2, nombre = "Taller EL REY", direccion = "zona 10 20-20 " },
            new Models.Taller { Id = 3, nombre = "Taller BARBER", direccion = "cuidad quetzal" }
        };
        [HttpGet]
        public ActionResult<List<Models.Taller>> GetAll()
        {
            return talleres;
        }
    }
}
