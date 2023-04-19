using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja
{
    internal static class Program
    {
        // CONNECTION STRING 
        // conn = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\msi\OneDrive - INTEC\INTEC\Trimestre 7\Desarrollo de software III\Proyecto Final\Proyecto-Banco\Proyecto-Banco\Caja\DbCaja.mdf;Integrated Security=True"

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new InicioSesion());
        }
    }
}
