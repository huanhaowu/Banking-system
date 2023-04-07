using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pantalla_Inicio_Sesion
{
    public partial class InciarSesion : Form
    {
        public InciarSesion()
        {
            InitializeComponent();
        }

        private void btAcceder_Click(object sender, EventArgs e)
        {
            Registrar registrar = new Registrar();
            registrar.Show();
            this.Hide();
        }
    }
}
