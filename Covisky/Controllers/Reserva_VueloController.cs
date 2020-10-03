using Covisky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Covisky.Controllers
{
    public class Reserva_VueloController : Controller
    {
        // GET: Reserva_Vuelo
        public ActionResult Index()
        {
            return View();
        }
         
        public ActionResult Checkin()
        {
            return View();
        }

        public ActionResult TravelOffer()
        {
            return View();
        }

        public ActionResult Misviajes()
        {
            return View();
        }
    }
}