using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreAPP.Usuarios
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            SRCore.wsCoreSoapClient ws = new SRCore.wsCoreSoapClient();
            CoreAPP.SRCore.Cuentas cuentas = new CoreAPP.SRCore.Cuentas();
            cuentas.Numero_Cuenta = int.Parse(txtNoCuenta.Text);
            cuentas.Tipo_Cuenta = int.Parse(cbTipoCuenta.Text);
            cuentas.Cliente = int.Parse(txtCliente_ID.Text);
            cuentas.Moneda = int.Parse(cbMoneda.Text);
            cuentas.Monto = decimal.Parse(txtMonto.Text);
            MessageBox.Show(ws.ActualizarCuenta(int.Parse(txtCuentaID.Text), cuentas));
            txtNoCuenta.Text = string.Empty;
            txtCliente_ID.Text = string.Empty;
            cbMoneda.Text = string.Empty;
            cbTipoCuenta.Text = string.Empty;
            txtMonto.Text = string.Empty;
            txtCuentaID.Text = string.Empty;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            txtCuentaID usuario = new txtCuentaID();
            this.Hide();
            usuario.Show();
        }

        private void txtCuentaID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtCliente_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
