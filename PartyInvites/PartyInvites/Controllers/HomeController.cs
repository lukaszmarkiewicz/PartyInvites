using PartyInvites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 17 ? "Dzień Dobry" : "Dobry Wieczór";
            return View();
        }
        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                //do zriobiena: wyślij zawartość gusetResponse do Organizatora przyjęcia
                return View("Thanks", guestResponse);
            }
            else
            { //błąd kontroli poprawności, więc ponownie wyświetlamy formularz wprowadzania danych
                return View();
            }
            
        }
    }
}