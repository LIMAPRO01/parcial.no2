using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TALLERMECANICA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurnosController : ControllerBase
    {
        private static List<Models.Turnos> turnos = new List<Models.Turnos>
        {
            new Models.Turnos { Id = 1, turno = "vespertino", dia = "Lunes-viernes" },
            new Models.Turnos { Id = 2, turno = "matutino", dia = "sabado, domingo" }
        };
        [HttpGet]
        public ActionResult<List<Models.Turnos>> GetAll()
        {
            return turnos;
        }
    }
}
