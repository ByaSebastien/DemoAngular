using Exercice_3_List.Data;
using Exercice_3_List.Models;
using Microsoft.AspNetCore.Mvc;

namespace Exercice_3_List.Controllers
{
    public class PlatController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<Plat> plats = FakeDB.Plats;
            return View(plats);
        }
        public IActionResult Create()
        {
            return View(new PlatInter());
        }
        [HttpPost]
        public IActionResult Create(PlatInter platinter)
        {
            if (!ModelState.IsValid)
            {
                return View(new PlatInter());
            }
            else
            {
                TempData["Name"] = platinter.Name;
                TempData["Number"] = platinter.NombreIngredients;
                return RedirectToAction("Add");
            }
        }
        public IActionResult Add()
        {

            return View(new PlatForm
            {
                Name = (string)TempData["Name"],
                NombreIngredients = (int)(TempData["Number"] ?? 5)
            });
        }
        [HttpPost]
        public IActionResult Add([FromForm] PlatForm platform)
        {
            if (!ModelState.IsValid)
            {
                return View(platform);
            }
            else
            {
                FakeDB.Plats.Add(new Plat
                {
                    Id = Guid.NewGuid(),
                    Name = platform.Name,
                    Origin = platform.Origin,
                    Type = platform.Type,
                    Description = platform.Description,
                    Ingredients = platform.Ingredients,
                });
                return RedirectToAction(nameof(Index));
            }
        }
        public IActionResult Detail(Guid id)
        {
            Plat plat = FakeDB.Plats.SingleOrDefault(p => p.Id == id);
            if (plat is not null)
            {
                return View(plat);
            }
            return NotFound();
        }
        public IActionResult Remove(Guid id)
        {
            Plat plat = FakeDB.Plats.SingleOrDefault(p => p.Id == id);
            if (plat is not null)
            {
                FakeDB.Plats.Remove(plat);
                return RedirectToAction(nameof(Index));
            }
            return NotFound();
        }
        public IActionResult Edit(Guid id)
        {
            Plat plat = FakeDB.Plats.SingleOrDefault(p => p.Id == id);
            return View(plat);
        }
        [HttpPost]
        public IActionResult Edit([FromForm]Plat editPlat)
        {
            if (!ModelState.IsValid)
            {
                return View(editPlat);
            }
            else
            {
                Plat plat = FakeDB.Plats.SingleOrDefault(p => p.Id == editPlat.Id);
                plat.Id = editPlat.Id;
                plat.Name = editPlat.Name;
                plat.Description = editPlat.Description;
                plat.Ingredients = editPlat.Ingredients;
                plat.Origin = editPlat.Origin;
                plat.Type = editPlat.Type;
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
