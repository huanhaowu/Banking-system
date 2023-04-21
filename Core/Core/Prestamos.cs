using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core
{
    public class Prestamos
    {
        public int Cliente_ID { get; set; }
        public decimal Tasa_Interes { get; set; }
        public DateTime FechaFinal { get; set; }
        public decimal Monto { get; set; }
        public int Banco_ID { get; set; }
        public int Estado { get; set; }
        public int Moneda { get; set; }
        public decimal MontoPagar { get; set; }
    }
}