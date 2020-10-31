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
            Informacion inf = new Informacion();
            inf.apellido = Request.Form["apellido"].ToString();
            inf.nombre = Request.Form["nombre"].ToString();
            inf.fechanac = Convert.ToDateTime(Request.Form["fechanac"].ToString());
            inf.correo = Request.Form["correo"].ToString();
            inf.telefonoinfo = Convert.ToInt32(Request.Form["telefono"].ToString());
            TempData["Informacion"] = inf;
            return View(inf);
        }

        public ActionResult Checkin2()
        {
            return View();
        }
        public ActionResult SelectTravel()
        {
            ReservaIyV riv1 = new ReservaIyV();
            riv1.origeniv = Request.Form["Origeniv"].ToString();
            riv1.destinoiv = Request.Form["Destinoiv"].ToString();
            riv1.saleiv = Convert.ToDateTime(Request.Form["Salesiv"].ToString());
            riv1.regresaiv = Convert.ToDateTime(Request.Form["Regresasiv"].ToString());
            riv1.cant_adultoiv = Convert.ToInt32(Request.Form["Adultos"].ToString());
            riv1.claseiv = Request.Form["Clase"].ToString();
            riv1.aerolinea = "CoviMG";

            TempData["ReservaIyV"] = riv1;
            return View(riv1);
        }
        public ActionResult Information()
        {
            SeleccionViaje riv2 = new SeleccionViaje();
            riv2.costo1 = Convert.ToInt32(Request.Form["costoida"].ToString());
            
            TempData["SeleccionViaje"] = riv2;
            return View(riv2);
        }
        public ActionResult Insertar()
        {
            ReservaIyV riv1 = TempData["ReservaIyV"] as ReservaIyV;
            //ReservaIyV riv2 = TempData["ReservaIyV"] as ReservaIyV;
            SeleccionViaje sv1 = TempData["SeleccionViaje"] as SeleccionViaje;
            Informacion inf1 = TempData["Informacion"] as Informacion;
            ReservaIyV riv = new ReservaIyV();
            using (CoviskyEntities cov = new CoviskyEntities())
            {
                //index
                Random rdm = new Random();
                int nobol = rdm.Next(100,100001);
                riv.noboleto = nobol;
                riv.origeniv = riv1.origeniv;
                riv.destinoiv = riv1.destinoiv;
                riv.saleiv = riv1.saleiv;
                riv.regresaiv = riv1.regresaiv;
                riv.cant_adultoiv = riv1.cant_adultoiv;
                riv.claseiv = riv1.claseiv;
                riv.aerolinea = riv1.aerolinea;
                //selecttravel
                riv.costo1 = sv1.costo1;
                //info
                riv.nombre = inf1.nombre;
                riv.apellido = inf1.apellido;
                riv.fechanac = inf1.fechanac;
                riv.correo = inf1.correo;
                riv.telefonoinfo = inf1.telefonoinfo;
                //pago
                riv.notarjeta = Convert.ToInt32(Request.Form["inputtarjeta"].ToString());
                riv.fechaven = Request.Form["inputfecha"].ToString();
                riv.cvv = Convert.ToInt32(Request.Form["inputcodigo_seg"].ToString());
                riv.pais = Request.Form["inputState"].ToString();
                riv.nombretar = Request.Form["inputnombre"].ToString();
                riv.pasaporte = Request.Form["inputidentificacion"].ToString();
                riv.correotar = Request.Form["inputcorreo"].ToString();
                riv.telefonotar = Convert.ToInt32(Request.Form["inputTelefono"].ToString());
                riv.direccion = Request.Form["inputdirec"].ToString();
                riv.estado = Request.Form["inputestado"].ToString();
                riv.ciudad = Request.Form["inputCiudad"].ToString();
                riv.codigop = Convert.ToInt32(Request.Form["inputCodigo_postal"].ToString());

                var bol = new Boleto();
                bol.bol_No_Boleto = riv.noboleto;
                bol.bol_aero_ID_Origen = riv.origeniv;
                bol.bol_aero_ID_Destino = riv.destinoiv
            }
            return View(riv);
        }
    }
}