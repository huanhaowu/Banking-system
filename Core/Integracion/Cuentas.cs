using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Integracion
{
    public class Cuentas
    {
        public int Numero_Cuenta { get; set; }
        public int Tipo_Cuenta { get; set; }
        public int Cliente { get; set; }
        public int Moneda { get; set; }
        public decimal Monto { get; set; }

    }
}