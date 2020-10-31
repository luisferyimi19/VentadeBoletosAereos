using Covisky.Models;
using Covisky.Models.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;

namespace Covisky.Controllers
{
    public class Reserva_VueloController : Controller
    {
        Obtener _ob = new Obtener();
        // GET: Reserva_Vuelo
        public ActionResult Index()
        {
            return View();
        }
         
        public ActionResult ObtenerPaises()
        {
            List<Pais> lista = _ob.ObtenerPais();
            var resultado = lista.Select(x=> new Models.Clases.ListaPais{ 
                id = x.pai_ID,
                nombre = x.pai_Nombre
            });
            return Json(new { data = resultado }, JsonRequestBehavior.AllowGet);
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

        public ActionResult Miles()
        {
            return View();
        }

        public ActionResult FlyStatus()
        {
            return View();
        }

        public ActionResult PickASit()
        {
            return View();
        }

        public ActionResult Pago()
        {
            return View();
        }

        public ActionResult Checkin2()
        {
            return View();
        }
        string ori,des = "";
        public ActionResult SelectTravel()
        {
            ReservaIyV riv = new ReservaIyV();
            riv.origeniv = Request.Form["Origeniv"].ToString();
            riv.destinoiv = Request.Form["Destinoiv"].ToString();

            ori = riv.origeniv;
            des = riv.destinoiv;
            return View(riv);
        }
        public ActionResult Information()
        {
            return View();
        }
        public ActionResult Insertar()
        {
            ReservaIyV riv = new ReservaIyV();
            using (CoviskyEntities cov = new CoviskyEntities())
            {
                //index
                riv.noboleto = 100;
                //riv.origeniv = Request.Form["Origeniv"].ToString();
                SelectTravel();
                riv.origeniv = ori;
                //riv.destinoiv = Request.Form["Destinoiv"].ToString();
                //riv.saleiv = Convert.ToDateTime(Request.Form["Salesiv"].ToString());
                //riv.regresaiv = Convert.ToDateTime(Request.Form["Regresasiv"].ToString());
                //riv.cant_adultoiv = Convert.ToInt32(Request.Form["Adultos"].ToString());
                //riv.claseiv = Request.Form["Economicaiv"].ToString();
                //selecttravel
                //riv.costo1 = Convert.ToInt32(Request.Form["economicaida"].ToString());
                //info
                //riv.nombre = Request.Form["nombre"].ToString();
                //riv.apellido = Request.Form["apellido"].ToString();
                //riv.fechanac = Convert.ToDateTime(Request.Form["fechanac"].ToString());
                //riv.correo = Request.Form["correo"].ToString();
                //riv.telefonoinfo = Convert.ToInt32(Request.Form["telefono"].ToString());
                //pago
                //riv.notarjeta = Convert.ToInt32(Request.Form["inputtarjeta"].ToString());
                //riv.fechaven = Request.Form["inputfecha"].ToString();
                //riv.cvv = Convert.ToInt32(Request.Form["inputcodigo_seg"].ToString());
                //riv.nopasaporte = Convert.ToInt64(Request.Form["inputidentificacion"].ToString());
                //riv.aerolinea = "CoviskyUMG";
                //riv.pais = Request.Form["inputpais"].ToString();
                //riv.direccion = Request.Form["inputdirec"].ToString();
            }
            return View(riv);
        }
    }
}