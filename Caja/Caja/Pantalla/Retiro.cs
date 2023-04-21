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
            this.Hide();
            Deposito deposito = new Deposito();
            if (deposito.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void bttPrestamos2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Prestamos prestamos = new Prestamos();
            if (prestamos.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void bttConfiguracion2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Configuracion configuracion = new Configuracion();
            if (configuracion.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void bttConfirmarR_Click(object sender, EventArgs e)
        {
            this.Hide();
            Configuracion configuracion = new Configuracion();
            if (configuracion.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void bttCancelarR_Click(object sender, EventArgs e)
        {
            grupoRetiro2.Hide();
            grupoRetiro2.Visible = false;
            grupoRetiro1.Show();
            grupoRetiro1.Visible = true;
            grupoBoton.Visible = false;
        }
    }
}
