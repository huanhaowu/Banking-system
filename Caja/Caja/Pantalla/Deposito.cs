using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caja.Pantalla
{
    public partial class Deposito : Form
    {
        public Deposito()
        {
            InitializeComponent();
        }

        private void bttRetirar_Click(object sender, EventArgs e)
        {
            Retiro retiro = new Retiro();
            retiro.Show();
            this.Hide();
        }

        private void bttPrestamos_Click(object sender, EventArgs e)
        {
            Prestamos prestamos = new Prestamos();
            prestamos.Show();
            this.Hide();
        }

        private void bttConfiguracion_Click(object sender, EventArgs e)
        {
            Configuracion configuracion = new Configuracion();
            configuracion.Show();
            this.Hide();
        }
    }
}
