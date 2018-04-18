using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment_1_John_Linehan.Models;

namespace Assignment_1_John_Linehan.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult SendCard()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SendCard(Models.SendCard sendCard)
        {
            if (ModelState.IsValid)
            {
                return View("BirthdayCard", sendCard);
            }
            else
            {
                return View();
            }
        }

    }
}