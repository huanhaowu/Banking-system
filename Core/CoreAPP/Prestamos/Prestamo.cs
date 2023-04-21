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
            this.Hide();
            crearPrestamo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Prestamos.actualizarPrestamos actualizarPrestamos = new actualizarPrestamos();
            this.Hide();
            actualizarPrestamos.Show();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            SRCore.wsCoreSoapClient ws = new SRCore.wsCoreSoapClient();

            if (txtPrestamo_ID.Text == "")
            {
                dgvPrestamos.DataSource = ws.ObtenerPrestamos();
            }
            else
            {
                dgvPrestamos.DataSource = ws.ObtenerClienteByID(int.Parse(txtPrestamo_ID.Text));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SRCore.wsCoreSoapClient ws = new SRCore.wsCoreSoapClient();
            MessageBox.Show(ws.BorrarPrestamos(Convert.ToInt32(txtPrestamo_ID.Text)));
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
