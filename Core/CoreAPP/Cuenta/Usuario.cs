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
    public partial class txtCuentaID : Form
    {
        public txtCuentaID()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CrearCuenta cuenta = new Usuarios.CrearCuenta();
            this.Hide();
            cuenta.Show();

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            Update update = new Update();
            this.Hide();
            update.Show();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            SRCore.wsCoreSoapClient ws = new SRCore.wsCoreSoapClient();
            if (txtCuenta_ID.Text == "")
            {
                MessageBox.Show("Ingrese un ID");
            }
            else
            {
                dgvCuentas.DataSource = ws.ObtenerCuentas(int.Parse(txtCuenta_ID.Text));
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SRCore.wsCoreSoapClient ws = new SRCore.wsCoreSoapClient();
            MessageBox.Show(ws.BorrarCliente(int.Parse(txtCuenta_ID.Text)));
        }

        private void txtCuenta_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }
    }
}
