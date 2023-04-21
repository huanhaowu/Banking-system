using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreAPP.Prestamos
{
    public partial class Prestamo : Form
    {
        public Prestamo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prestamos.CrearPrestamo crearPrestamo = new Prestamos.CrearPrestamo();
            crearPrestamo.Show(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Prestamos.actualizarPrestamos actualizarPrestamos = new actualizarPrestamos();
            actualizarPrestamos.Show(this);
        }
    }
}
