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

        private void bttConfiguracion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Configuracion configuracion = new Configuracion();
            if (configuracion.ShowDialog() != DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Deposito_Load(object sender, EventArgs e)
        {

        }

        private void bttCancelarD_Click(object sender, EventArgs e)
        {
            txtMontoD.Clear();
            txtDescripD.Clear();
            txtCuentaD.Clear();
        }
    }
}
