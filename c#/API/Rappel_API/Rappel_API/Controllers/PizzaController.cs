using BLL;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Rappel_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private IPizzaService _Service;
        public PizzaController(IPizzaService service)
        {
            _Service = service;
        }

        public IActionResult GetAll()
        {
            IEnumerable<Pizza> pizzas = _Service.GetAll();
            return Ok(pizzas);
        }
    }

}
