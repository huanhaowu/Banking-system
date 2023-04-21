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

namespace CoreAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente.Customer customer = new Cliente.Customer();
            this.Hide();
            customer.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Usuarios.UsuariosV usuario = new UsuariosV();
            this.Hide();
            usuario.Show();
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtCuentaID cuenta = new txtCuentaID();
            this.Hide();
            cuenta.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Prestamos.Prestamo prestamo = new Prestamos.Prestamo();
            this.Hide();
            prestamo.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Transacciones.Transaccion transaccion = new Transacciones.Transaccion();
            this.Hide();
            transaccion.Show();
        }
    }
}
