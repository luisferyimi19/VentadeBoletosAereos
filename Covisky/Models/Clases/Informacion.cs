using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Covisky.Models.Clases
{
    public class Informacion
    {
        public string apellido { get; set; }
        public string nombre { get; set; }
        public DateTime fechanac { get; set; }
        public string correo { get; set; }
        public string confirmarcorreo { get; set; }
        public int telefonoinfo { get; set; }
    }
}