using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using TP33.Models;

namespace TP33.Controllers
{

    public class PersonController : Controller
    {

        [Route("Person/")]
        public IActionResult all()
        {
            Personal_info personal_Info = new Personal_info();

            return View(personal_Info.GetAllPerson());
        }

        [Route("Person/{id:int}")]
        public IActionResult index(int id)
        {
            Personal_info personal_Info = new Personal_info();

            return View(personal_Info.GetPerson(id));
        }

        [HttpGet]
        
        public IActionResult search()
        {
            ViewBag.notFound = false;
            return View();
        }

        [HttpPost]
        
        public  IActionResult search(string first_name , string country)
        {
            Personal_info pi = new Personal_info();
            List<Person> list = pi.GetAllPerson();

            foreach(Person p in list)
            {
                if(p.FirstName==first_name && p.Country == country)
                {
                    return RedirectToAction("index", new { id = p.Id }); 
                }
            }


            ViewBag.notFound = true;
            return View();

            

        }

    }


}
