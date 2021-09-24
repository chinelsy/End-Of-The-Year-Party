using EndOfTheYearParty.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;

namespace EndOfTheYearParty.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]  
        public ViewResult RsvpForm()
        {
            return View();
        }

        
        [HttpPost]
        public ViewResult RsvpForm(PartyGuestResponse partyGuestResponse)
        {
            if (ModelState.IsValid)
            {
                Repository.AddResponse(partyGuestResponse);
                return View("Thanks", partyGuestResponse);
            }
           
            {
                return View();
            }
        }

        
        public ViewResult GuestResponses() 
        {
            return View(Repository.Responses.Where(r => r.WillAttend == true));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
