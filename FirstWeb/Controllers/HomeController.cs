using FirstWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWeb.Controllers
{
    //[Route("/[action]")]
    //[Route("/")]
    public class HomeController : Controller
    {
        //[Route("[action]/page/{cat?}")]        
        GuestList g = new GuestList();
        public IActionResult Index(string? cat="12")
        {
            ViewBag.cat = cat;
            return View();
        }

        [HttpGet]
        public IActionResult Guest()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Guest(Guest ReCGuest)
        {
            g.AddGuest(ReCGuest);
            return View("Thank", ReCGuest);
        }

        [Route("All")]
        public IActionResult AllGuests()
        {
          
            return View(g.AllGuests());
        }
        [Route("[action]")]
        public ContentResult Test(int? Id)
        {
          
            return Content("<html> <h1> Welcome </h1> </html>");
        }
    }
}
