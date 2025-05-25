using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TALLERMECANICA.Controllers
{
    [Route("api/Clientes")]
    [ApiController]
    public class ClientesController : ControllerBase
    {
        private static List<Models.Clientes> clientes = new List<Models.Clientes>
        {
            new Models.Clientes { id = 1, nombre = "EDUARDO", telefono = "87456987" },
            new Models.Clientes { id = 2, nombre = "JOSE", telefono = "98452361" },
            new Models.Clientes { id = 3, nombre = "PERLA", telefono = "78451201" },
            new Models.Clientes { id = 4, nombre = "MARIO", telefono = "98453216"},
            new Models.Clientes { id = 5, nombre = "PAMELA", telefono = "54659887"}
        };
        [HttpGet]
        public ActionResult<List<Models.Clientes>> GetAll()
        {
            return clientes;
        }
    }
}
