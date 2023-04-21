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
                dgvPrestamos.Visible = true;
                txtData.Visible = false;
                dgvPrestamos.DataSource = ws.ObtenerPrestamos();
            }
            if (txtPrestamo_ID.Text != "")
            {
                txtData.Visible = true;
                dgvPrestamos.Visible = false;
                SRCore.Prestamos prestamo = new SRCore.Prestamos();
                prestamo = ws.ObtenerPrestamosByID(int.Parse(txtPrestamo_ID.Text));
                txtData.Text = ("Cliente ID : " + prestamo.Cliente_ID + "\n" +
                                    "Tasa Interes : " + prestamo.Tasa_Interes + "\n" +
                                    "Fecha Final : " + prestamo.FechaFinal + "\n" +
                                    "Monto Prestamo : " + prestamo.Monto + "\n" +
                                    "Banco ID : " + prestamo.Banco_ID + "\n" +
                                    "Estado : " + prestamo.Estado + "\n" +
                                    "Moneda : " + prestamo.Moneda + "\n" +
                                    "Monto a Pagar : " + prestamo.MontoPagar + "\n"
                    );
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
