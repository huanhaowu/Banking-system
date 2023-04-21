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
            this.Hide();
            Deposito deposito = new Deposito();
            if (deposito.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void bttRetirar3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Retiro retiro = new Retiro();
            if (retiro.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void bttPrestamos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prestamos prestamos = new Prestamos();
            if (prestamos.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void bttMontoInicial_Click(object sender, EventArgs e)
        {
            MontoInicial montoInicial = new MontoInicial();
            montoInicial.ShowDialog();
        }

        private void bttCuadre_Click(object sender, EventArgs e)
        {
            CuadreTransaccion cuadreTransaccion = new CuadreTransaccion();
            cuadreTransaccion.ShowDialog();
        }

        private void bttLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            IniciarSesion iniciarSesion = new IniciarSesion();
            if (iniciarSesion.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void bttReciboTransa_Click(object sender, EventArgs e)
        {

        }
    }
}
