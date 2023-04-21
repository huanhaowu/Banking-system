using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoreAPP.SRCore;

namespace CoreAPP.Cliente
{
    public partial class Crear : Form
    {
        public Crear()
        {
            InitializeComponent();
        }

        private void Crear_Load(object sender, EventArgs e)
        {

        }

        private void BtnCrear_Click(object sender, EventArgs e)
        {
            SRCore.wsCoreSoapClient ws = new SRCore.wsCoreSoapClient();
            CoreAPP.SRCore.Cliente cliente = new CoreAPP.SRCore.Cliente();
            cliente.Nombre = txtNombre.Text;
            cliente.Apellido = txtApellido.Text;
            cliente.TipoDocumento = cbTipoDoc.Text;
            cliente.Documento = txtDocumento.Text;
            cliente.Email = txtCorreo.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.FechaNacimiento = dtFNacimiento.Value;
            MessageBox.Show(ws.InsertarCliente(cliente));

            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            txtTelefono.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            dtFNacimiento.Value = DateTime.Now;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            this.Hide();
            customer.Show();

        }
    }
}
