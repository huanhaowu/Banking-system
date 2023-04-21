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
    public partial class CrearCuenta : Form
    {
        public CrearCuenta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SRCore.wsCoreSoapClient ws = new SRCore.wsCoreSoapClient();
            SRCore.Cuentas cuentas = new SRCore.Cuentas();
            cuentas.Numero_Cuenta = int.Parse(txtNoCuenta.Text);
            cuentas.Tipo_Cuenta = int.Parse(cbTipoCuenta.Text);
            cuentas.Cliente = int.Parse(txtClienteID.Text);
            cuentas.Moneda = int.Parse(cbMoneda.Text);
            MessageBox.Show(ws.CrearCuenta(cuentas));
            txtNoCuenta.Text = string.Empty;
            txtClienteID.Text = string.Empty;
            cbMoneda.Text = string.Empty;
            cbTipoCuenta.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCuentaID usuario = new txtCuentaID();
            this.Hide();
            usuario.Show();
        }

        private void txtClienteID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
