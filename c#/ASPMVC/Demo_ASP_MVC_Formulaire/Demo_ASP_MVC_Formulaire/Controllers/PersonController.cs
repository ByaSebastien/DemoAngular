using Demo_ASP_MVC_Formulaire.Data;
using Demo_ASP_MVC_Formulaire.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo_ASP_MVC_Formulaire.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            IEnumerable<Person> persons = FakeDB.Persons;
            return View(persons);
        }
        public IActionResult Add()
        {
            //return View("Add_Simple_HTML",new PersonForm());
            //return View("Add_HTML_Helper", new PersonForm());
            return View("Add_Tag_Helper", new PersonForm());

        }
        [HttpPost]
        public IActionResult Add([FromForm] PersonForm personForm)
        {
            if (!ModelState.IsValid)
            {
                //return View("Add_Simple_HTML", personForm);
                //return View("Add_HTML_Helper", personForm);
                return View("Add_Tag_Helper", personForm);
            }
            else
            {
                FakeDB.Persons.Add(new Person
                {
                    Firstname = personForm.Firstname,
                    Lastname = personForm.Lastname,
                    Email = personForm.Email,
                    Id = ++FakeDB.LastId
                });
                return RedirectToAction(nameof(Index));
            }
        }
    }
}
