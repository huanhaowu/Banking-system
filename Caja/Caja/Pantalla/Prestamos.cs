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
            Deposito deposito3 = new Deposito();
            deposito3.Show();
            this.Hide();
        }

        private void bttRetirar3_Click(object sender, EventArgs e)
        {
            Retiro retiro3 = new Retiro();
            retiro3.Show();
            this.Hide();
        }

        private void bttConfiguracion3_Click(object sender, EventArgs e)
        {
            Configuracion configuracion3 = new Configuracion();
            configuracion3.Show();
            this.Hide();
        }

        private void bttConfirmarP1_Click(object sender, EventArgs e)
        {
            grupoPrestamos1.Hide();
            grupoPrestamos2.Show();
            grupoPrestamos2.Visible = true;
        }

        private void bttPagar1_Click(object sender, EventArgs e)
        {
            grupoPrestamos2.Hide(); 
            grupoPrestamos3.Show();
            grupoPrestamos3.Visible = true;
        }
    }
}
