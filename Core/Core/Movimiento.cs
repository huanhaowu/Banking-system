using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core
{
    public class Movimiento
    {
        public DateTime Fecha { get; set; }
        public string Tipo { get; set; }
        public string Monto { get; set; }
        public string Moneda { get; set; }
    }
}