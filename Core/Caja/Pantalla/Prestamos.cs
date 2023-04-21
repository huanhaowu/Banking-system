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
    public partial class Prestamos : Form
    {
        public Prestamos()
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

        private void bttConfiguracion3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Configuracion configuracion = new Configuracion();
            if (configuracion.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void bttConfirmarP1_Click(object sender, EventArgs e)
        {
            Prestamos2 prestamos = new Prestamos2();
            this.Hide();
            if (prestamos.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void bttConfirmarP_Click(object sender, EventArgs e)
        {

        }

        private void bttCancelarP_Click(object sender, EventArgs e)
        {

        }
    }
}
