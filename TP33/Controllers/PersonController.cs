using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TP33.Services;

namespace TP33.Controllers
{

    public class PersonController : Controller
    {
        
        // GET: Person/all
        public ActionResult all()
        {
            var personService = new PersonService();

            return View(personService.GetAllPerson());
        }

        
    }
}
