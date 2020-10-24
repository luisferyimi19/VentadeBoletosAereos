using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Covisky.Models.Clases
{
    public class Reserva
    {
        [Required]
        public string origen { get; set; }
        public string destino { get; set; }
        public DateTime sale { get; set; }
        public DateTime regresa { get; set; }
        public int cant_adulto { get; set; }
        public int cant_nino { get; set; }
        public int cant_bebe { get; set; }
        public string clase { get; set; }
    }
}