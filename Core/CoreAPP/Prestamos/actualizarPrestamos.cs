using CoreAPP.Usuarios;
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
    public partial class actualizarPrestamos : Form
    {
        public actualizarPrestamos()
        {
            InitializeComponent();
        }

        private void Btnactualizar_Click(object sender, EventArgs e)
        {
            SRCore.wsCoreSoapClient ws = new SRCore.wsCoreSoapClient();
            CoreAPP.SRCore.Prestamos prestamos = new CoreAPP.SRCore.Prestamos();
            prestamos.Cliente_ID = int.Parse(txtCliente_ID.Text);
            prestamos.Tasa_Interes = int.Parse(txtTasaInteres.Text);
            prestamos.FechaFinal = dtFFinal.Value;
            prestamos.Monto = decimal.Parse(txtMontoPrestamo.Text);
            prestamos.Banco_ID = int.Parse(cbBanco.Text);
            prestamos.Estado = int.Parse(cbEstado.Text);
            prestamos.Moneda = int.Parse(cbMoneda.Text);
            MessageBox.Show(ws.ActualizarPrestamos(int.Parse(txtPrestamo_ID.Text), prestamos));
            txtCliente_ID.Text = string.Empty;
            txtTasaInteres.Text = string.Empty;
            txtMontoPrestamo.Text = string.Empty;
            cbBanco.Text = string.Empty;
            cbEstado.Text = string.Empty;
            cbMoneda.Text = string.Empty;
            txtPrestamo_ID.Text = string.Empty;
            dtFFinal.Text = string.Empty;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Prestamo prestamo = new Prestamo();
            this.Hide();
            prestamo.Show();
        }
    }
}
