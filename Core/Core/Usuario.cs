using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Core
{
    public class Usuario
    {
        public int UsuarioId { get; set; }
        public int ClienteId { get; set; }
        public string NombreUser { get; set; }
        public string Password { get; set; }
        public int PerfilId { get; set; }
        public DateTime FCreacion { get; set; }
    }
}