using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoreAPP.Cliente
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SRCore.wsCoreSoapClient ws = new SRCore.wsCoreSoapClient();
            CoreAPP.SRCore.Cliente cliente = new CoreAPP.SRCore.Cliente
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Direccion = txtDireccion.Text,
                Telefono = txtTelefono.Text,
                Email = txtCorreo.Text,
                FechaNacimiento = dtFNacimiento.Value
            };
            MessageBox.Show(ws.ActualizarCliente(int.Parse(txtClienteID.Text) ,cliente));
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            dtFNacimiento.Value = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente.Customer customer = new Cliente.Customer();
            this.Hide();
            customer.Show();
        }

        private void txtClienteID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
