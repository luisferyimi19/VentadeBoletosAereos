using Covisky.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web;

namespace Covisky
{
    public class Obtener
    {
        private CoviskyEntities _context;
        public Obtener()
        {
            _context = new CoviskyEntities();
        }
        public List<Pais> ObtenerPais()
        {
            List<Pais> lista = _context.Pais.ToList();
            return lista;
        }
    }
}