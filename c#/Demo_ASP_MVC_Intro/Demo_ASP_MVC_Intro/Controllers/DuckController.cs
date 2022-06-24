using Demo_ASP_MVC_Intro.Data;
using Demo_ASP_MVC_Intro.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo_ASP_MVC_Intro.Controllers
{
    public class DuckController : Controller
    {
        public IActionResult Index()
        {
            ViewData["number"] = new Random().Next(0, 43);

            ViewBag.Message = "Message dans le controlleur";

            return View();
        }
        public IActionResult Liste()
        {
            IEnumerable<Duck> ducks = FakeDB.Ducks;



            return View(ducks);
        }
        public IActionResult Detail()
        {
            return View();
        }
    }
}
