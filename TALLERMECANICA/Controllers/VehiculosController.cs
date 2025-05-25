using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TALLERMECANICA.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehiculosController : ControllerBase
    {
        private static List<Models.Vehiculos> vehiculos = new List<Models.Vehiculos>
        {
            new Models.Vehiculos { id = 1, marca = "KAWUASAKI", modelo = "ninja zxr" },
            new Models.Vehiculos { id = 2, marca = "SUSUKI", modelo = "hayabusa" },
            new Models.Vehiculos { id = 3, marca = "YAMAHA", modelo = "deportiva r3" },
            new Models.Vehiculos { id = 4, marca = "DUCATI", modelo = "Stritfire"},
            new Models.Vehiculos { id = 5, marca = "honda", modelo = "cbrr 600" }
            };
        [HttpGet]
        public ActionResult<List<Models.Vehiculos>> GetAll()
        {
            return vehiculos;
        }
    }
}
