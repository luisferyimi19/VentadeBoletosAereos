using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Covisky.Models.Clases
{
    public class ReservaIyV
    {
        public int noboleto { get; set; }
        public string origeniv { get; set; }
        public string destinoiv { get; set; }
        public DateTime saleiv { get; set; }
        public DateTime regresaiv { get; set; }
        public int cant_adultoiv { get; set; }
        public int cant_ninoiv { get; set; }
        public int cant_bebeiv { get; set; }
        public string claseiv { get; set; }
        public string aerolinea { get; set; }
        public int costo1 { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public DateTime fechanac { get; set; }
        public string correo { get; set; }
        public string confirmarcorreo { get; set; }
        public int telefonoinfo { get; set; }
        public int notarjeta { get; set; }
        public string fechaven { get; set; }
        public int cvv { get; set; }
        public string nombretar { get; set; }
        public string pasaporte { get; set; }
        public long nopasaporte { get; set; }
        public string correotar { get; set; }
        public string confirmartar { get; set; }
        public string direccion { get; set; }
        public string pais { get; set; }
        public string estado { get; set; }
        public string ciudad { get; set; }
        public int codigop { get; set; }
    }
}