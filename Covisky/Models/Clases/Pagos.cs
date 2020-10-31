using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Covisky.Models.Clases
{
    public class Pagos
    {
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
        public int telefonotar { get; set; }
    }
}