using Labo_ASP_MVC.Data;
using Labo_ASP_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace Labo_ASP_MVC.Controllers
{
    public class WhiskyController : Controller
    {
        public IActionResult Index()
        {
            IList<Whisky> whiskies = FakeDB.Whiskies;
            return View(whiskies);
        }
        public IActionResult Detail(int id)
        {
            IList<Whisky> whiskies = FakeDB.Whiskies;
            Whisky whisky = whiskies.SingleOrDefault(w => w.Id == id);
            return View(whisky);
        }
    }
}
