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
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void bttDepositar3_Click(object sender, EventArgs e)
        {
            Deposito deposito = new Deposito();
            deposito.Show();
            this.Hide();
        }

        private void bttRetirar3_Click(object sender, EventArgs e)
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

        private void bttMontoInicial_Click(object sender, EventArgs e)
        {
            MontoInicial montoInicial = new MontoInicial();
            montoInicial.Show();
        }

        private void bttCuadre_Click(object sender, EventArgs e)
        {
            CuadreTransaccion cuadreTransaccion = new CuadreTransaccion();
            cuadreTransaccion.Show();
        }

        private void bttLogout_Click(object sender, EventArgs e)
        {
            IniciarSesion iniciarSesion = new IniciarSesion();
            iniciarSesion.Show();
            this.Close();
        }
    }
}
