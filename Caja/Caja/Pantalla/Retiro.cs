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
    public partial class Retiro : Form
    {
        public Retiro()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bttConfirmarR1_Click(object sender, EventArgs e)
        {
            grupoRetiro1.Hide();
            grupoRetiro1.Visible = false;
            grupoRetiro2.Show();
            grupoRetiro2.Visible = true;
            grupoBoton.Visible = true;
        }

        private void Retiro_Load(object sender, EventArgs e)
        {

        }

        private void bttDepositar2_Click(object sender, EventArgs e)
        {
            Deposito deposito2 = new Deposito();
            deposito2.Show();
            this.Hide();
        }

        private void bttPrestamos2_Click(object sender, EventArgs e)
        {
            Prestamos prestamos2 = new Prestamos();
            prestamos2.Show();
            this.Hide();
        }

        private void bttConfiguracion2_Click(object sender, EventArgs e)
        {
            Configuracion configuracion2 = new Configuracion();
            configuracion2.Show();
            this.Hide();
        }

        private void bttConfirmarR_Click(object sender, EventArgs e)
        {

        }
    }
}
