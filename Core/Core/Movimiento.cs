using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core
{
    public class Movimiento
    {
        public int Id { get; set; }
        public int Tipo_Transaccion { get; set; }
        public int IdCuenta { get; set; }
        public int IdCuentaDestino { get; set; }
        public DateTime Fecha { get; set; }
        public int Monto { get; set; }
        public int Moneda { get; set; }
    }
}